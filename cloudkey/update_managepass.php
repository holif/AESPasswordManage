<?php
	$username = $_GET['username'];
	$password = $_GET['password'];
	$newpass = $_GET['newpass'];
	
	$log = "\r\n".date('Y-m-d H:i:s')."	";
	$fh=fopen("./total_data/".$username."/cloudkey.log","a");

	if(CheckUser($username,$password)==3){
		$mail = UpdatePass($username,$newpass);
		$log = $log."update manage password success.";
		echo $mail;
	} else {
		$log = $log."update manage password fails.";
		echo "error";
	}
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

<?php
	function CheckUser($username,$password)
	{
		$dir="./total_data/";
		$user_dir=$dir.$username;
		if(!file_exists($user_dir)){
			return 1;
		}
		
		$user_input_password=md5($password); //加密用户输入的密码
		$user_passfile_dir=$user_dir."/pass.key"; //读取密钥文件
		$server_password=file($user_passfile_dir); //获取服务器储存的密码
		
		if($user_input_password==$server_password[0])
				return 3;
		else
				return 2;	
	}
?>