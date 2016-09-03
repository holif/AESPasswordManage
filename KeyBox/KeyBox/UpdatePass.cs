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
    public partial class UpdatePass : CCSkinMain
    {
        private ListPass listpass;
        private string username;
        private string password;
        private Record record ;
        private string key;
        public UpdatePass(ListPass listpass,string username, string password ,Record record)
        {
            
            this.username = username;
            this.password = password;
            this.listpass = listpass;
            this.record = record;
            InitializeComponent();
        }

        private void UpdatePass_Load(object sender, EventArgs e)
        {
            text_title.Text = this.record.title;
            text_zhanghao.Text = this.record.zhanghao;
        }

        private void Btn_return_Click(object sender, EventArgs e)
        {
            this.listpass.Hide();
            listpass.Show();
            this.Close();
        }

        private void text_mima_Enter(object sender, System.EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = XMLDealTool.getKeyPath();
            dlg.Filter = "密钥文件|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                key = KeyConvert.GetKeyByImage(dlg.FileName);

                string url = XMLDealTool.getUrlPath() + "cloudkey/getpass.php";
                string data = "username=" + this.username + "&password=" + this.password + "&key=" + key + "&num=" + this.record.num;
                string result = HttpGet.HttpGet_test(url, data);
                if (result.Equals("error"))
                {
                    MessageBox.Show("无效密钥！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                text_mima.Text = dlg.FileName;
            }
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            string nmima = text_nmima.Text;
            string cnmima = text_ncmima.Text;
            string lable = Encrypt.StringToBase64string(text_lable.Text); ;

            if (nmima.Equals(cnmima) && nmima != "")
            {
                string keypath = XMLDealTool.getKeyPath() + "\\" + this.record.title + ".png";
                string nkey = KeyConvert.CreateKey(keypath);
                nmima = Encrypt.AESEncrypt(nmima, nkey);
                nmima = Encrypt.StringToBase64string(nmima);
                string url = XMLDealTool.getUrlPath() + "cloudkey/update_pass.php";
                string data = "username=" + this.username + "&password=" + this.password + "&key=" + nkey + "&num=" + this.record.num + "&mima=" + nmima + "&lable=" + lable;
                string result = HttpGet.HttpGet_test(url, data);
                if (result.IndexOf("ok")!=-1)
                {
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    text_nmima.ResetText();
                    text_ncmima.ResetText();
                    text_lable.ResetText();
                }
                else
                {
                    MessageBox.Show("修改失败，请重新登录后再进行修改！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("请检查输入的新密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
