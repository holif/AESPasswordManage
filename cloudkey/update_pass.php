<?php
	include "CheckUser.php";
	
	$name=$_GET['username'];//登录账号
	$password=$_GET['password'];//登录密码
	$key=md5($_GET['key']);
	
	$status = CheckUser($name,$password);
	$log = "\r\n".date('Y-m-d H:i:s')."	"."update password ";
	
	if($status==3)
	{
		$num=$_GET['num'];
		$mima = $_GET['mima'];
		$lable = $_GET['lable'];
		
		$dir="./total_data/".$name."/pass_list/".$num."/";

		$file=fopen($dir.$key.".password", 'w');
		fwrite($file,$mima);
		fclose($file);
		
		$file=fopen($dir."lable.dat", 'w');
		fwrite($file,$lable);
		fclose($file);
		
		echo "ok";
		
		$log = $log."success.";
	} elseif($status==2){
		$log = $log."fail:password error.";
		echo "error:pass error";
	}else {
		echo "error:no user";
		exit;
	}
	$fh=fopen("./total_data/".$name."/cloudkey.log","a");
	fwrite($fh,$log);
	fclose($fh);	
?>
