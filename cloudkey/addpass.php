<?php	
	$name=$_GET['username'];//登录账号
	$password=$_GET['password'];//登录密码
	if(CheckUser($name,$password)!=3)
	{
		echo "error";
		exit;
	}
	$title=$_GET['title'];//标题	
	$zhanghao=$_GET['zhanghao'];//账号
	
	$key=md5($_GET['key']);//key密钥
	$mima=$_GET['mima'];//记录中的密码
	
	$lable=$_GET['lable'];//留言	
	$dir='./total_data/'.$name.'/pass_list/';	
	$num = file_number($dir)+1;//计算要创建的记录是第几个文件夹
	$lable_dir=$dir.$num.'/';
	
	mkdir($lable_dir,0777);//根据数字创建记录文件夹
	//mkdir($lable_dir.$pswd,0777);
	$file=fopen($lable_dir."/title.dat", 'w');
	fwrite($file,$title);
	fclose($file);
	$file=fopen($lable_dir."/zhanghao.dat", 'w');
	fwrite($file,$zhanghao);
	fclose($file);
	$file=fopen($lable_dir.$key.".password", 'w');
	fwrite($file,$mima);
	fclose($file);
	$file=fopen($lable_dir."/lable.dat", 'w');
	fwrite($file,$lable);
	fclose($file);
	
	$log = "\r\n".date('Y-m-d H:i:s')."	"."add password.";
	$fh=fopen("./total_data/".$name."/cloudkey.log","a");
	fwrite($fh,$log);
	fclose($fh);	
	
	print "ok";
?>
<?php
	function file_number($directory)
	{  
		$number = 0; //统计文件个数  
		if(!empty($directory))//如果目录存在  
		{ 	 
			$file_array=scandir($directory);
			$number=count($file_array)-2;
		}
		return $number;  
	}
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