<?php
	$name=$_GET['username'];
	$password=$_GET['password'];
	if(CheckUser($name,$password)!=3)
	{
		echo "error";
		exit;
	}
	header('Content-type:text/json');
	$list['list']=list_lable($name);
	
	$log = date('Y-m-d H:i:s')."	"."get password list.\r\n";
	$fh=fopen("./total_data/".$name."/cloudkey.log","a");
	fwrite($fh,$log);
	fclose($fh);
	
	echo json_encode($list);
?>

<?php
	function list_lable($name)//获取用户所有的记录值
	{
		$list=array();
		$j=0;
		$dir='./total_data/'.$name.'/pass_list/';
		$dirArray=scandir($dir);//获取pass_list下的文件夹数组即1，2，3...
		$len=count($dirArray);
		
		for($i=2;$i<count($dirArray);$i++)//遍历每个记录
		{
			$list[$j]=getFile($dir.$dirArray[$i].'/');
			$list[$j]["num"]=$dirArray[$i];
			$j++;
		}
		return $list;
	}
	
	function getFile($dir) //获取指定记录中的三个文件内容
	{
		$fileArray=array('title'=>"",'zhanghao'=>"",'lable'=>"");
		$filename=array('title'=>$dir.'title.dat','zhanghao'=>$dir.'zhanghao.dat','lable'=>$dir.'lable.dat');
		
		foreach($filename as $index=>$value)
		{
			$handle=fopen($value,"rb");
			$contents=fread($handle, filesize($value));
			fclose($handle);
			$fileArray[$index]=$contents;
		}
		return $fileArray;
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