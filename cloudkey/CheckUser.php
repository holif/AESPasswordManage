<?php
	function CheckUser($username,$password)
	{
		/*
		*   return 参数
		*
		* 1 密钥文件路径错误，即用户不存在
		* 2 密码错误
		* 3 登录成功
		*/
		$dir="./total_data/";
		$user_dir=$dir.$username;	
		$user_input_password=md5($password); //加密用户输入的密码
		$user_passfile_dir=$user_dir."/pass.key"; //读取密钥文件
		if(file_exists($user_passfile_dir)){
			$server_password=file($user_passfile_dir); //获取服务器储存的密码
			if($user_input_password==$server_password[0]){
				return 3;
			}
			else{
				return 2;
			}				
		} else{
			return 1; 
		}
		
	}
?>