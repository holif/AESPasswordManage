<?php

	include "CheckUser.php";
	
	$name=$_GET['username'];//登录账号
	$password=$_GET['password'];//登录密码
	$key=md5($_GET['key']);
	
	$status = CheckUser($username,$password);
	$log = "\r\n".date('Y-m-d H:i:s')."	"."parsed password ";
	if($status == 3)
	{
		$num=$_GET['num'];
		$dir="./total_data/".$name."/pass_list/".$num."/".$key.".password";
		$file=fopen($dir, 'r');
		$mima=fread($file, filesize($dir));
		fclose($file);
		echo $mima;
		
		$log = $log."success.";
	} elseif($status == 2){
		$log = $log."fail:password error.";
		echo "error:pass error";
	} else {
		echo "error:no user";
		exit;
	}

	$fh=fopen("./total_data/".$name."/cloudkey.log","a");
	fwrite($fh,$log);
	fclose($fh);
?>