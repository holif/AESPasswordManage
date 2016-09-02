using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CCWin;
namespace KeyBox
{
    public partial class Register : CCSkinMain
    {
        public Register(Login login )
        {
            InitializeComponent();

            this.login = login;
            //this.SetDesktopLocation(500,250);
        }
        private Login login;
        public void KeyBox_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void skinButton_Register_Click(object sender, EventArgs e)
        {
            string username = Register_username.Text;
            string pass = Register_pswd.Text;
            string passinfo = Register_pswdinfo.Text;
            string mail = Register_email.Text;
            Regex r = new Regex("^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@(\\w+\\.)+\\w{2,5})\\s*$");
            if(!r.IsMatch(mail))
            {
                MessageBox.Show("邮箱格式有误！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (username != "" && pass != "" && passinfo != "" && mail != "")
            {
                if (pass.Equals(passinfo))
                {
                    //创建Email对象
                    Email email = new Email();
                    email.mailFrom = "admin@baal.xyz";
                    email.mailPwd = "huo136276";
                    email.mailSubject = "注册成功";
                    email.mailBody = "请妥善保管您的账号与密码：" + username + "&" + pass;
                    email.isbodyHtml = true;    
                    email.host = "smtp.ym.163.com";
                    email.mailTo = mail;

                    string url = XMLDealTool.getUrlPath() + "cloudkey/signin.php";
                    username = Encrypt.GetMd5Hash(username);
                    pass = Encrypt.StringToBase64string(pass);
                    string data = "username=" + username + "&password=" + pass+"&Email="+mail;
                    string result = HttpGet.HttpGet_test(url, data);

                    if (result.IndexOf("Error") == -1)
                    {
                        if (email.Send())
                        {
                            MessageBox.Show("注册成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        this.Hide();
                        login.Show();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("注册失败！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("两次输入的密码不一致！", "ERROR",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("请填写完整信息！", "WARN",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }
        private void KeyBox_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }
    }
}
