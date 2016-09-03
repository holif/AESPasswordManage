namespace KeyBox
{
    partial class UpManagePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpManagePass));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.text_password = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.text_npass = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.text_cnpass = new CCWin.SkinControl.SkinWaterTextBox();
            this.Btn_update = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(47, 81);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "当前密码";
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(125, 81);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(118, 21);
            this.text_password.TabIndex = 1;
            this.text_password.UseSystemPasswordChar = true;
            this.text_password.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_password.WaterText = "";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(49, 147);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(44, 17);
            this.skinLabel2.TabIndex = 2;
            this.skinLabel2.Text = "新密码";
            // 
            // text_npass
            // 
            this.text_npass.Location = new System.Drawing.Point(125, 147);
            this.text_npass.Name = "text_npass";
            this.text_npass.Size = new System.Drawing.Size(118, 21);
            this.text_npass.TabIndex = 3;
            this.text_npass.UseSystemPasswordChar = true;
            this.text_npass.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_npass.WaterText = "";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(46, 207);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(56, 17);
            this.skinLabel3.TabIndex = 4;
            this.skinLabel3.Text = "确认密码";
            // 
            // text_cnpass
            // 
            this.text_cnpass.Location = new System.Drawing.Point(125, 203);
            this.text_cnpass.Name = "text_cnpass";
            this.text_cnpass.Size = new System.Drawing.Size(118, 21);
            this.text_cnpass.TabIndex = 5;
            this.text_cnpass.UseSystemPasswordChar = true;
            this.text_cnpass.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_cnpass.WaterText = "";
            // 
            // Btn_update
            // 
            this.Btn_update.BackColor = System.Drawing.Color.Transparent;
            this.Btn_update.BaseColor = System.Drawing.Color.Silver;
            this.Btn_update.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_update.DownBack = null;
            this.Btn_update.Location = new System.Drawing.Point(49, 273);
            this.Btn_update.MouseBack = null;
            this.Btn_update.Name = "Btn_update";
            this.Btn_update.NormlBack = null;
            this.Btn_update.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_update.Size = new System.Drawing.Size(75, 28);
            this.Btn_update.TabIndex = 6;
            this.Btn_update.Text = "确认修改";
            this.Btn_update.UseVisualStyleBackColor = false;
            this.Btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BaseColor = System.Drawing.Color.Silver;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.Location = new System.Drawing.Point(166, 273);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton2.Size = new System.Drawing.Size(75, 29);
            this.skinButton2.TabIndex = 7;
            this.skinButton2.Text = "返回";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // UpManagePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(295, 329);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.Btn_update);
            this.Controls.Add(this.text_cnpass);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.text_npass);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.skinLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpManagePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改管理密码";
            this.Load += new System.EventHandler(this.UpManagePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinWaterTextBox text_password;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinWaterTextBox text_npass;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinWaterTextBox text_cnpass;
        private CCWin.SkinControl.SkinButton Btn_update;
        private CCWin.SkinControl.SkinButton skinButton2;
    }
}