<?php

	$uname = $_GET['username'];
	$pword = $_GET['password'];
	$email = $_GET['Email'];

	if(CheckUser($uname)!=0){
		adduser($uname,$pword,$email);
		echo "success";
	} else {
		echo "Error,username exist";
	}

	function CheckUser($username){
		$dir="./total_data/";
		$user_dir=$dir.$username;
		$result=1;//可以注册
		if(file_exists($user_dir))
		{
			$result=0;
		}
		return $result;
	}
	
	function adduser($username,$password,$email)
	{
		$password=md5($password);
		$dir="./total_data/";
		$user_info_dir=$dir.$username;
		$user_pass_dir=$user_info_dir."/pass_list";
		//创建用户根目录
		//创建根目录下的 pass.key info.dat
		//创建根目录下的pass_list目录
		mkdir($user_info_dir);
		$fpass=fopen($user_info_dir."/pass.key","w");
		fprintf($fpass,"%s",$password);
		fclose($fpass);
		$fpass=fopen($user_info_dir."/info.dat","w");
		fprintf($fpass,"%s",$email);
		fclose($fpass);
		
		$log = "\r\n".date('Y-m-d H:i:s')."	"."sigin in cloudkey user.";
		$fpass=fopen($user_info_dir."/cloudkey.log","w");
		fprintf($fpass,"%s",$log);
		fclose($fpass);
		
		mkdir($user_pass_dir);
	}
?>
