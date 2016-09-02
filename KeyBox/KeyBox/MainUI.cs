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
    public partial class MainUI : CCSkinMain
    {
        public MainUI()
        {
            InitializeComponent();
        }
        private string username;
        private string password;

        public void setUserPass(string name,string pass)
        {
            username = name;
            password = pass;
        }
        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {

        }
        private void KeyBox_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_addPass_Click(object sender, EventArgs e)
        {
            AddPass andpass = new AddPass(this,this.username,this.password);
            this.Hide();
            andpass.Show();
        }

        private void Btn_getPass_Click(object sender, EventArgs e)
        {
            ListPass listpass = new ListPass(this,this.username,this.password);
            this.Hide();
            listpass.Show();
        }

        private void Btn_upMngPass_Click(object sender, EventArgs e)
        {
            UpManagePass managepass = new UpManagePass(this,this.username,this.password);
            this.Hide();
            managepass.Show();
        }

        private void setKeyPath_Click(object sender, EventArgs e)
        {
            SetKeyPath keypath = new SetKeyPath();
            keypath.Show();
        }

        private void Btn_log_Click(object sender, EventArgs e)
        {
            LookLog looklog = new LookLog(username, password, this);
            this.Hide();
            looklog.Show();
        }
    }
}
