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
	$mima = $_GET['mima'];
	$lable = $_GET['lable'];
	
	$dir="./total_data/".$name."/pass_list/".$num."/";

	$file=fopen($dir.$key.".password", 'w');
	fwrite($file,$mima);
	fclose($file);
	
	$file=fopen($dir."lable.dat", 'w');
	fwrite($file,$lable);
	fclose($file);
	
	$log = "\r\n".date('Y-m-d H:i:s')."	"."update password.";
	$fh=fopen("./total_data/".$name."/cloudkey.log","a");
	fwrite($fh,$log);
	fclose($fh);
	
	echo "ok";
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