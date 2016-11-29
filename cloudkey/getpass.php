<?php

	include "CheckUser.php";
	
	$name=$_GET['username'];//登录账号
	$password=$_GET['password'];//登录密码
	$key=md5($_GET['key']);
	
	$status = CheckUser($name,$password);
	
	$log = "\r\n".date('Y-m-d H:i:s')."	"."parsed password ";
	
	if($status == 3)
	{
		$num=$_GET['num'];
		$dir="./total_data/".$name."/pass_list/".$num."/".$key.".password";
		$file=fopen($dir, 'r');
		$mima=fread($file, filesize($dir));
		fclose($file);
		
		$log = $log."success.";
		writelog($name,$log);
		echo $mima;
	} elseif($status == 2){
		$log = $log."fail:password error.";
		writelog($name,$log);
		echo "error:pass error";
		exit;
	} else {
		$log = $log."error:no user";
		writelog($name,$log);
		echo "error:no user";
		exit;
	}

	function writelog($name,$log){
		$fh=fopen("./total_data/".$name."/cloudkey.log","a");
		fwrite($fh,$log);
		fclose($fh);		
	}
	
?>
