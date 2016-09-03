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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KeyBox
{
    public partial class ListPass : CCSkinMain
    {
        private string username;
        private string password;
        private MainUI mainui;

        private List<Record> listRecord = new List<Record>();
        private Record selectedRecord = new Record();

        private ComboBox comboBox;

        public ListPass(MainUI mainui ,string username, string password)
        {
            this.username = username;
            this.password = password;
            this.mainui = mainui;
            InitializeComponent();
        }

        private void ListPass_Load(object sender, EventArgs e)
        {
            this.comboBox = comboBox_key;

            string url = XMLDealTool.getUrlPath() + "cloudkey/userinfolist.php";
            string data = "username=" + username + "&password=" + password;
            string result = HttpGet.HttpGet_test(url, data);
            string jsonArrayText= "";

            JObject jo = JObject.Parse(result);
            //jo.Properties().Select(item => item.Value);
            string[] values = jo.Properties().Select(item =>item.Value.ToString()).ToArray();
            foreach (string s in values)
            {
                jsonArrayText += s;
            }

            JArray ja = (JArray)JsonConvert.DeserializeObject(jsonArrayText);
            
            foreach (JObject jobj in ja)
            {
                Record record = new Record();
                record.title = Encrypt.Base64ToString(jobj["title"].ToString());
                record.zhanghao = Encrypt.Base64ToString(jobj["zhanghao"].ToString());
                record.lable = Encrypt.Base64ToString(jobj["lable"].ToString());
                record.num = Int32.Parse(jobj["num"].ToString());

                comboBox.Items.Add(record.title);

                listRecord.Add(record);
            }

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainui.Show();
            this.Close();
        }

        private void Btn_jiexi_Click(object sender, EventArgs e)
        {
            int num = selectedRecord.num;
            string mima="";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = XMLDealTool.getKeyPath();
            dlg.Filter = "密钥文件|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string key = KeyConvert.GetKeyByImage(dlg.FileName);


                string url = XMLDealTool.getUrlPath() + "cloudkey/getpass.php";
                string data = "username=" + username + "&password=" + password + "&key=" + key + "&num=" + num;
                string result = HttpGet.HttpGet_test(url, data);
                if (result.IndexOf("error") != -1) 
                {
                    MessageBox.Show("解析失败，请检查密钥图片是否正确！" , "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //MessageBox.Show("您的账号密码是：" + result, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = Encrypt.Base64ToString(result);
                mima = Encrypt.AESDecrypt(result, key);
                if (mima.IndexOf("error") != -1)
                {
                    MessageBox.Show("解析失败，请检查密钥图片是否正确！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else 
            {
                return;
            }
            MessageBox.Show("您的账号密码是："+mima, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);      
        }

        private void Btn_updatePass_Click(object sender, EventArgs e)
        {

            UpdatePass pass = new UpdatePass(this, this.username, this.password, this.selectedRecord);
            this.Hide();
            pass.Show();
        }

        private void comboBox_key_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecttitle = this.comboBox.SelectedItem.ToString();

            this.selectedRecord = listRecord.Find(
                delegate(Record record)
                {
                    return record.title.Equals(selecttitle);
                });
            if (selectedRecord != null)
            {
                text_title.Text = selecttitle;
                text_zhanghao.Text = selectedRecord.zhanghao;
                text_lable.Text = selectedRecord.lable;
            }
        }
    }
}
