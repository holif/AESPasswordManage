using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using System.IO;

namespace KeyBox
{
    public partial class AddPass : CCSkinMain
    {
        private MainUI mainui;
        private string username;
        private string password;
        public AddPass(MainUI mainui,string username,string password)
        {
            this.username = username;
            this.password = password;
            this.mainui = mainui;
            InitializeComponent();
        }

        private void AddPass_Load(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            string title = text_title.Text;
            string zhanghao = text_zhanghao.Text;
            string mima = text_mima.Text;
            string conmima = text_conmima.Text;
            string lable = text_lable.Text;




            if (mima.Equals(conmima) && title != "" && zhanghao != "" && mima != "")
            {
                string keypath = XMLDealTool.getKeyPath()+"\\"+title+".png";
                string key = KeyConvert.CreateKey(keypath);
                mima = Encrypt.AESEncrypt(mima,key);
                mima = Encrypt.StringToBase64string(mima);
                title = Encrypt.StringToBase64string(title);
                zhanghao = Encrypt.StringToBase64string(zhanghao);
                lable = Encrypt.StringToBase64string(lable);

                string url = XMLDealTool.getUrlPath() + "cloudkey/addpass.php";
                string data = "username=" + username + "&password=" + password + "&title=" + title + "&zhanghao=" + zhanghao;
                data = data + "&key=" + key + "&mima=" + mima + "&lable=" + lable;
                string result = HttpGet.HttpGet_test(url, data);

                if (result.IndexOf("ok") != -1)
                {
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    text_title.ResetText();
                    text_zhanghao.ResetText();
                    text_mima.ResetText();
                    text_conmima.ResetText();
                    text_lable.ResetText();
                }
                else 
                {
                    //添加失败删除key图片
                    File.Delete(keypath);
                    MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("请输入完整的账号信息！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void skinButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            mainui.Show();
            this.Close();
        }
    }
}
