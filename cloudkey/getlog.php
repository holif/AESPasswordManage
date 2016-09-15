<?php

	include "CheckUser.php";
	
	$name=$_GET['username'];//登录账号
	$password=$_GET['password'];//登录密码
	if(CheckUser($name,$password)!=3)
	{
		echo "error";
		exit;
	}
	
	$dir="./total_data/".$name."/cloudkey.log";
	$file=fopen($dir, 'r');
	$log=fread($file, filesize($dir));
	fclose($file);
	echo $log;
?>