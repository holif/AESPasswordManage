<?php
	$name=$_GET['username'];//登录账号
	$password=$_GET['password'];//登录密码
	$key=md5($_GET['key']);
	if(CheckUser($name,$password)!=3)
	{
		echo "error";
		exit;
	}
	$num=$_GET['num'];
	$dir="./total_data/".$name."/pass_list/".$num."/".$key.".password";
	$file=fopen($dir, 'r');
	$mima=fread($file, filesize($dir));
	fclose($file);
	
	$log = date('Y-m-d H:i:s')."	"."parsed password. rn";
	$fh=fopen("./total_data/".$name."/cloudkey.log","a");
	fwrite($fh,$log);
	fclose($fh);
	
	echo $mima;
?>

<?php
	function CheckUser($username,$password)
	{
		$dir="./total_data/";
		$user_dir=$dir.$username;	
		$user_input_password=md5($password); //加密用户输入的密码
		$user_passfile_dir=$user_dir."/pass.key"; //读取密钥文件
		$server_password=file($user_passfile_dir); //获取服务器储存的密码
		if($user_input_password==$server_password[0])
			return 3;
		else
			return 2;
	}
?>