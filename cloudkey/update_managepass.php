<?php

	include "CheckUser.php";

	$username = $_GET['username'];
	$password = $_GET['password'];
	$newpass = $_GET['newpass'];
	
	$log = "\r\n".date('Y-m-d H:i:s')."update manage password ";

	$status = CheckUser($username,$password);
	
	if($status==3){
		$mail = UpdatePass($username,$newpass);
		$log = $log."success.";
		echo $mail;
	} elseif($status == 2){
		$log = $log."fail:password error.";
		echo "error:password error";
	} else{
		echo "error:nouser";
		exit;
	}
	$fh=fopen("./total_data/".$username."/cloudkey.log","a");
	fwrite($fh,$log);
	fclose($fh);
?>


<?php
	function UpdatePass($username,$newpass){
		$newpass=md5($newpass);
		$dir="./total_data/";
		$user_info_dir=$dir.$username;
		$fpass=fopen($user_info_dir."/pass.key","w");
		fprintf($fpass,"%s",$newpass);
		fclose($fpass);
		
		$fmail=fopen($user_info_dir."/info.dat","r");
		$mail=fread($fmail, filesize($user_info_dir."/info.dat"));
		fclose($fmail);
		
		return $mail;
	}
?>
