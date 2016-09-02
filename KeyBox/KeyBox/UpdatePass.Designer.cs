namespace KeyBox
{
    partial class UpdatePass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePass));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.text_title = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.text_zhanghao = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.text_mima = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.text_nmima = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.text_ncmima = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.text_lable = new CCWin.SkinControl.SkinTextBox();
            this.Btn_update = new CCWin.SkinControl.SkinButton();
            this.Btn_return = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(30, 54);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "标题";
            // 
            // text_title
            // 
            this.text_title.Location = new System.Drawing.Point(102, 52);
            this.text_title.Name = "text_title";
            this.text_title.ReadOnly = true;
            this.text_title.Size = new System.Drawing.Size(114, 21);
            this.text_title.TabIndex = 1;
            this.text_title.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_title.WaterText = "";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(31, 93);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 2;
            this.skinLabel2.Text = "账号";
            // 
            // text_zhanghao
            // 
            this.text_zhanghao.Location = new System.Drawing.Point(102, 91);
            this.text_zhanghao.Name = "text_zhanghao";
            this.text_zhanghao.ReadOnly = true;
            this.text_zhanghao.Size = new System.Drawing.Size(114, 21);
            this.text_zhanghao.TabIndex = 3;
            this.text_zhanghao.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_zhanghao.WaterText = "";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(25, 133);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(56, 17);
            this.skinLabel3.TabIndex = 4;
            this.skinLabel3.Text = "密钥路径";
            // 
            // text_mima
            // 
            this.text_mima.Location = new System.Drawing.Point(102, 132);
            this.text_mima.Name = "text_mima";
            this.text_mima.ReadOnly = true;
            this.text_mima.Size = new System.Drawing.Size(114, 21);
            this.text_mima.TabIndex = 5;
            this.text_mima.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_mima.WaterText = "";
            this.text_mima.Enter += new System.EventHandler(this.text_mima_Enter);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(26, 177);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(44, 17);
            this.skinLabel4.TabIndex = 6;
            this.skinLabel4.Text = "新密码";
            // 
            // text_nmima
            // 
            this.text_nmima.Location = new System.Drawing.Point(102, 173);
            this.text_nmima.Name = "text_nmima";
            this.text_nmima.Size = new System.Drawing.Size(114, 21);
            this.text_nmima.TabIndex = 7;
            this.text_nmima.UseSystemPasswordChar = true;
            this.text_nmima.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_nmima.WaterText = "";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(24, 220);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(56, 17);
            this.skinLabel5.TabIndex = 8;
            this.skinLabel5.Text = "确认密码";
            // 
            // text_ncmima
            // 
            this.text_ncmima.Location = new System.Drawing.Point(102, 216);
            this.text_ncmima.Name = "text_ncmima";
            this.text_ncmima.Size = new System.Drawing.Size(114, 21);
            this.text_ncmima.TabIndex = 9;
            this.text_ncmima.UseSystemPasswordChar = true;
            this.text_ncmima.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_ncmima.WaterText = "";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(30, 274);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(32, 17);
            this.skinLabel6.TabIndex = 10;
            this.skinLabel6.Text = "备注";
            // 
            // text_lable
            // 
            this.text_lable.BackColor = System.Drawing.Color.Transparent;
            this.text_lable.DownBack = null;
            this.text_lable.Icon = null;
            this.text_lable.IconIsButton = false;
            this.text_lable.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.text_lable.IsPasswordChat = '\0';
            this.text_lable.IsSystemPasswordChar = false;
            this.text_lable.Lines = new string[0];
            this.text_lable.Location = new System.Drawing.Point(102, 263);
            this.text_lable.Margin = new System.Windows.Forms.Padding(0);
            this.text_lable.MaxLength = 32767;
            this.text_lable.MinimumSize = new System.Drawing.Size(28, 28);
            this.text_lable.MouseBack = null;
            this.text_lable.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.text_lable.Multiline = true;
            this.text_lable.Name = "text_lable";
            this.text_lable.NormlBack = null;
            this.text_lable.Padding = new System.Windows.Forms.Padding(5);
            this.text_lable.ReadOnly = false;
            this.text_lable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_lable.Size = new System.Drawing.Size(114, 60);
            // 
            // 
            // 
            this.text_lable.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_lable.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_lable.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.text_lable.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.text_lable.SkinTxt.Multiline = true;
            this.text_lable.SkinTxt.Name = "BaseText";
            this.text_lable.SkinTxt.Size = new System.Drawing.Size(104, 50);
            this.text_lable.SkinTxt.TabIndex = 0;
            this.text_lable.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_lable.SkinTxt.WaterText = "";
            this.text_lable.TabIndex = 11;
            this.text_lable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_lable.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_lable.WaterText = "";
            this.text_lable.WordWrap = true;
            // 
            // Btn_update
            // 
            this.Btn_update.BackColor = System.Drawing.Color.Transparent;
            this.Btn_update.BaseColor = System.Drawing.Color.Silver;
            this.Btn_update.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_update.DownBack = null;
            this.Btn_update.Location = new System.Drawing.Point(34, 344);
            this.Btn_update.MouseBack = null;
            this.Btn_update.Name = "Btn_update";
            this.Btn_update.NormlBack = null;
            this.Btn_update.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_update.Size = new System.Drawing.Size(75, 27);
            this.Btn_update.TabIndex = 12;
            this.Btn_update.Text = "修改记录";
            this.Btn_update.UseVisualStyleBackColor = false;
            this.Btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // Btn_return
            // 
            this.Btn_return.BackColor = System.Drawing.Color.Transparent;
            this.Btn_return.BaseColor = System.Drawing.Color.Silver;
            this.Btn_return.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_return.DownBack = null;
            this.Btn_return.Location = new System.Drawing.Point(141, 344);
            this.Btn_return.MouseBack = null;
            this.Btn_return.Name = "Btn_return";
            this.Btn_return.NormlBack = null;
            this.Btn_return.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_return.Size = new System.Drawing.Size(75, 27);
            this.Btn_return.TabIndex = 13;
            this.Btn_return.Text = "返回";
            this.Btn_return.UseVisualStyleBackColor = false;
            this.Btn_return.Click += new System.EventHandler(this.Btn_return_Click);
            // 
            // UpdatePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(269, 388);
            this.Controls.Add(this.Btn_return);
            this.Controls.Add(this.Btn_update);
            this.Controls.Add(this.text_lable);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.text_ncmima);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.text_nmima);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.text_mima);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.text_zhanghao);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.text_title);
            this.Controls.Add(this.skinLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdatePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码记录";
            this.Load += new System.EventHandler(this.UpdatePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinWaterTextBox text_title;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinWaterTextBox text_zhanghao;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinWaterTextBox text_mima;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinWaterTextBox text_nmima;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinWaterTextBox text_ncmima;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinTextBox text_lable;
        private CCWin.SkinControl.SkinButton Btn_update;
        private CCWin.SkinControl.SkinButton Btn_return;
    }
}