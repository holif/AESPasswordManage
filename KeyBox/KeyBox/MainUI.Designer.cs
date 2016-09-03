namespace KeyBox
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.Btn_upMngPass = new CCWin.SkinControl.SkinButton();
            this.Btn_getPasslist = new CCWin.SkinControl.SkinButton();
            this.Btn_addPass = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.setKeyPath = new CCWin.SkinControl.SkinButton();
            this.Btn_log = new CCWin.SkinControl.SkinButton();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // Btn_upMngPass
            // 
            this.Btn_upMngPass.BackColor = System.Drawing.Color.Transparent;
            this.Btn_upMngPass.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_upMngPass.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_upMngPass.DownBack = null;
            this.Btn_upMngPass.Location = new System.Drawing.Point(322, 106);
            this.Btn_upMngPass.MouseBack = null;
            this.Btn_upMngPass.Name = "Btn_upMngPass";
            this.Btn_upMngPass.NormlBack = null;
            this.Btn_upMngPass.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_upMngPass.Size = new System.Drawing.Size(93, 37);
            this.Btn_upMngPass.TabIndex = 3;
            this.Btn_upMngPass.Text = "修改管理密码";
            this.Btn_upMngPass.UseVisualStyleBackColor = false;
            this.Btn_upMngPass.Click += new System.EventHandler(this.Btn_upMngPass_Click);
            // 
            // Btn_getPasslist
            // 
            this.Btn_getPasslist.BackColor = System.Drawing.Color.Transparent;
            this.Btn_getPasslist.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_getPasslist.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_getPasslist.DownBack = null;
            this.Btn_getPasslist.Location = new System.Drawing.Point(191, 104);
            this.Btn_getPasslist.MouseBack = null;
            this.Btn_getPasslist.Name = "Btn_getPasslist";
            this.Btn_getPasslist.NormlBack = null;
            this.Btn_getPasslist.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_getPasslist.Size = new System.Drawing.Size(97, 39);
            this.Btn_getPasslist.TabIndex = 2;
            this.Btn_getPasslist.Text = "查看密码列表";
            this.Btn_getPasslist.UseVisualStyleBackColor = false;
            this.Btn_getPasslist.Click += new System.EventHandler(this.Btn_getPass_Click);
            // 
            // Btn_addPass
            // 
            this.Btn_addPass.BackColor = System.Drawing.Color.Transparent;
            this.Btn_addPass.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_addPass.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_addPass.DownBack = null;
            this.Btn_addPass.Location = new System.Drawing.Point(66, 104);
            this.Btn_addPass.MouseBack = null;
            this.Btn_addPass.Name = "Btn_addPass";
            this.Btn_addPass.NormlBack = null;
            this.Btn_addPass.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_addPass.Size = new System.Drawing.Size(93, 39);
            this.Btn_addPass.TabIndex = 1;
            this.Btn_addPass.Text = "添加密码记录";
            this.Btn_addPass.UseVisualStyleBackColor = false;
            this.Btn_addPass.Click += new System.EventHandler(this.Btn_addPass_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(195, 47);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(93, 19);
            this.skinLabel1.TabIndex = 4;
            this.skinLabel1.Text = "选择操作";
            // 
            // setKeyPath
            // 
            this.setKeyPath.BackColor = System.Drawing.Color.Transparent;
            this.setKeyPath.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.setKeyPath.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.setKeyPath.DownBack = null;
            this.setKeyPath.Location = new System.Drawing.Point(66, 174);
            this.setKeyPath.MouseBack = null;
            this.setKeyPath.Name = "setKeyPath";
            this.setKeyPath.NormlBack = null;
            this.setKeyPath.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.setKeyPath.Size = new System.Drawing.Size(95, 34);
            this.setKeyPath.TabIndex = 5;
            this.setKeyPath.Text = "设置Key路径";
            this.setKeyPath.UseVisualStyleBackColor = false;
            this.setKeyPath.Click += new System.EventHandler(this.setKeyPath_Click);
            // 
            // Btn_log
            // 
            this.Btn_log.BackColor = System.Drawing.Color.Transparent;
            this.Btn_log.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_log.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_log.DownBack = null;
            this.Btn_log.Location = new System.Drawing.Point(191, 174);
            this.Btn_log.MouseBack = null;
            this.Btn_log.Name = "Btn_log";
            this.Btn_log.NormlBack = null;
            this.Btn_log.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_log.Size = new System.Drawing.Size(97, 34);
            this.Btn_log.TabIndex = 6;
            this.Btn_log.Text = "查看操作日志";
            this.Btn_log.UseVisualStyleBackColor = false;
            this.Btn_log.Click += new System.EventHandler(this.Btn_log_Click);
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.Location = new System.Drawing.Point(322, 174);
            this.skinButton3.MouseBack = null;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton3.Size = new System.Drawing.Size(93, 34);
            this.skinButton3.TabIndex = 7;
            this.skinButton3.Text = "安全退出";
            this.skinButton3.UseVisualStyleBackColor = false;
            this.skinButton3.Click += new System.EventHandler(this.skinButton3_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(473, 264);
            this.Controls.Add(this.skinButton3);
            this.Controls.Add(this.Btn_log);
            this.Controls.Add(this.setKeyPath);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.Btn_addPass);
            this.Controls.Add(this.Btn_getPasslist);
            this.Controls.Add(this.Btn_upMngPass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主菜单";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton Btn_upMngPass;
        private CCWin.SkinControl.SkinButton Btn_getPasslist;
        private CCWin.SkinControl.SkinButton Btn_addPass;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton setKeyPath;
        private CCWin.SkinControl.SkinButton Btn_log;
        private CCWin.SkinControl.SkinButton skinButton3;
    }
}