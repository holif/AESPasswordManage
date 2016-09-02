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
    public partial class LookLog : CCSkinMain
    {
        private string username;
        private string password;
        private MainUI mainui;

        public LookLog(string username,string password,MainUI mainui)
        {
            this.username = username;
            this.password = password;
            this.mainui = mainui;
            InitializeComponent();
        }

        private void LookLog_Load(object sender, EventArgs e)
        {
            string url = XMLDealTool.getUrlPath() + "cloudkey/getlog.php";
            string data = "username=" + username + "&password=" + password;
            string result = HttpGet.HttpGet_test(url, data);
            waterText.Text = result;
        }

        private void Btn_ruturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainui.Show();
            this.Close();
        }
    }
}
