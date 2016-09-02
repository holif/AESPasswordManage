using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace KeyBox
{
    public partial class UpManagePass : CCSkinMain
    {
        private MainUI mainui;
        private string username;
        private string password;
        public UpManagePass(MainUI mainui,string username,string password)
        {
            this.username = username;
            this.password = password;
            this.mainui = mainui;
            InitializeComponent();
        }

        private void UpManagePass_Load(object sender, EventArgs e)
        {
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainui.Show();
            this.Close();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            string password = text_password.Text;
            string npass = text_npass.Text;
            string cnpass = text_cnpass.Text;

            Email email = new Email();
            email.mailFrom = "admin@baal.xyz";
            email.mailPwd = "huo136276";
            email.mailSubject = "提示：修改登陆密码";
            email.mailBody = "您的登陆密码已修改为：" + npass + ",若非本人操作请立即锁定账号，以免造成不必要的损失。";
            email.isbodyHtml = true;
            email.host = "smtp.ym.163.com";

            password = Encrypt.StringToBase64string(password);
            npass = Encrypt.StringToBase64string(npass);
            cnpass = Encrypt.StringToBase64string(cnpass);

            if (this.password.Equals(password) && npass.Equals(cnpass))
            {
                string url = XMLDealTool.getUrlPath()+"cloudkey/update_managepass.php";
                string data = "username=" + username + "&password=" + password + "&newpass="+npass;
                string result = HttpGet.HttpGet_test(url, data);

                if (result.IndexOf("error") == -1)
                {
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    email.mailTo = result;
                    email.Send();

                    this.Hide();
                    mainui.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败，请注意输入！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
