# AESPasswordManage
结合AES与图片密钥的密码存储系统<br/><br/>
<h3>1.系统说明</h3>
  系统客户端与服务端分别使用C#、PHP开发，开发工具是VS2010，运行环境为.NET4。<br/>使用的第三方库：<a href="http://www.cskin.net/">CSkin.dll</a>、<a href="http://www.newtonsoft.com/json">Newtonsoft.Json.dll</a>。<br/><br/>
  <b>加密过程：</b>在预设好的长度为36的数字与英文字母组合的字符数组中，可重复地选取32个字符作为AES加密密钥，并将密钥写入图片中交与用户保存。<br/>
<h3>2.导入本地开发环境</h3>
  <b>&middot;</b> 将项目导入VS中，添加项目依赖的库；<br/>
  <b>&middot;</b> 将cloudkey文件夹直接复制到Web服务器上并修改执行权限；<br/>
  <b>&middot;</b> 修改VS项目中的配置文件config.xml中的url为服务器地址（注：配置文件中的path为图片密钥的输出路径）；<br/>
  <b>&middot;</b> 修改Register.cs与UpManagePass.cs中的以下三项内容：<br/>
  &nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;email.mailFrom = "发送地址";<br/>
  &nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;email.mailPwd = "*******";<br/>
  &nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;email.host = "smtp.163.com";<br/>
  <b>&middot;</b> 编译运行。<br/>
<h3>3.下载运行系统</h3>
  <a href="https://github.com/holif/AESPasswordManage/releases/download/v1.0/AESPasswordManage.zip">下载可执行文件 </a>，修改path路径，双击即可运行。<br/><br/>
