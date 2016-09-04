# AESPasswordManage
结合AES与图片密钥的密码存储系统<br/><br/>
<h3>1.系统说明</h3>
  系统客户端与服务端分别使用C#、PHP开发，开发工具是VS2010，运行环境为.NET4。<br/>使用的第三方库：<a href="http://www.cskin.net/">CSkin.dll</a>、<a href="http://www.newtonsoft.com/json">Newtonsoft.Json.dll</a>。<br/><br/>
  <b>加密过程：</b>在预设好的长度为36的数字与英文字母组合的字符数组中，可重复地选取32个字符作为AES加密密钥，并将密钥写入图片中交与用户保存。<br/>
<h3>2.配置开发环境</h3>
  将项目导入VS中，添加项目依赖的库，将cloudkey文件夹直接复制到Web服务器上，修改VS项目中的配置文件config.xml中的url为服务器地址（注：配置文件中的path为图片密钥的输出路径），即可运行项目。<br/>
<h3>3.运行项目</h3>
  下载项目，修改path路径，双击运行即可，运行效果如下。<br/>
