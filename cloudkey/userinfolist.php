<?php
	header('Content-type:text/json');
	include "CheckUser.php";
	$name=$_GET['username'];
	$password=$_GET['password'];
	
	$log = "\r\n".date('Y-m-d H:i:s')."	"."get passwords list";
	
	if(file_exists("./total_data/".$name."/cloudkey.log"))
	{		
		if(CheckUser($name,$password)!=3)
		{
			$log = $log." fail.";
			echo "get passwords error";
		} else {
			$list['list']=list_lable($name);
			echo json_encode($list);
			$log = $log.".";
		}	
		$fh=fopen("./total_data/".$name."/cloudkey.log","a");
		fwrite($fh,$log);
		fclose($fh);
	} else {
		echo "error:no user";
		exit;
	}
		

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
	
	function getFile($dir){ //获取指定记录中的三个文件内容
	
		$fileArray=array('title'=>"",'zhanghao'=>"",'lable'=>"");
		$filename=array('title'=>$dir.'title.dat','zhanghao'=>$dir.'zhanghao.dat','lable'=>$dir.'lable.dat');
		
		foreach($filename as $index=>$value){
			
			$handle=fopen($value,"rb");
			$contents=fread($handle, filesize($value));
			fclose($handle);
			$fileArray[$index]=$contents;
		}
		return $fileArray;
	}
?>