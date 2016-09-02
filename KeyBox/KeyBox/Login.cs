using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using CCWin;

namespace KeyBox
{
    public partial class Login :CCSkinMain
    {
        public Login()
        {
            InitializeComponent();
            if (!checkNet()) 
            {
                netStatus.Text = "网络未连接";
            }
        }

        private bool checkNet() {
            System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
            System.Net.NetworkInformation.PingOptions options = new System.Net.NetworkInformation.PingOptions();
            options.DontFragment = true;
            string data = "Test Data!";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 1000; // Timeout 时间，单位：毫秒  
            System.Net.NetworkInformation.PingReply reply = p.Send("www.baidu.com", timeout, buffer, options);
            if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                return true;
            else
                return false; 
        }

        private void skinTextBox2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void skinButton_register_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            this.Hide();
            register.Show();
        }

        private void skinButton_login_Click(object sender, EventArgs e)
        {
            string username = Encrypt.GetMd5Hash(Login_username.Text);
            string password = Login_password.Text;

            password = Encrypt.StringToBase64string(password);

            string url = XMLDealTool.getUrlPath() + "cloudkey/login_check.php";
            string data = "username="+username+"&password="+password;
            string result = HttpGet.HttpGet_test(url, data);
   
            if (result.IndexOf("ok")!=-1)
            { 
                MainUI mainui = new MainUI();
                this.Visible = false;
                mainui.setUserPass(username, password);
                mainui.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("密码错误", result, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
