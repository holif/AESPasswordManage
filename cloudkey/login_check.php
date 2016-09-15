<?php
	include "CheckUser.php";
	
	if(($_GET['username']!="")&&($_GET['password']!=""))
	{
		$status=CheckUser($_GET['username'],$_GET['password']);
		/*
		 1:无用户
		 2:密码错误
		 3:登录成功
		*/
		$log = "\r\n".date('Y-m-d H:i:s')."	";
		$fh=fopen("./total_data/".$_GET['username']."/cloudkey.log","a");

		switch($status){
			case 1: print "nouser"; $log=$log."Login Failure CauseBy NoUser."; break;
			case 2: print "nopass"; $log=$log."Login Failure CauseBy the password validation fails."; break;
			case 3: print "ok"; $log=$log."Login Success."; break;
		}

		fwrite($fh,$log);
		fclose($fh);
	}
?>
