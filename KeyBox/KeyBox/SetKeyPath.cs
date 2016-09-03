using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using System.Xml;

namespace KeyBox
{
    public partial class SetKeyPath : CCSkinMain
    {
        public SetKeyPath()
        {
            InitializeComponent();
        }

        private void SetKeyPath_Load(object sender, EventArgs e)
        {

        }

        private void Btn_setpath_Click(object sender, EventArgs e)
        {
            string keypath = text_keyPath.Text;

            if (keypath == "")
            {
                MessageBox.Show("请输入路径！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            XMLDealTool.setKeyPath(keypath);

            MessageBox.Show("设置成功" , "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void Btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_keyPath_Enter(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string path = fbd.SelectedPath;
                text_keyPath.Text = path;
            }
        }
    }
}
