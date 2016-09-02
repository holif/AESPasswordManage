<?php
	if(CheckUser($_GET['username'])==0)
		print "Error: User exists";
	else
	{
		adduser($_GET['username'],$_GET['password'],$_GET['Email']);
		print "Now Successful !";
	}			
?>

<?php
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
		
		$log = date('Y-m-d H:i:s')."	"."sigin in cloudkey user.\r\n";
		$fpass=fopen($user_info_dir."/cloudkey.log","w");
		fprintf($fpass,"%s",$log);
		fclose($fpass);
		
		mkdir($user_pass_dir);
	}
?>