namespace KeyBox
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.Login_username = new CCWin.SkinControl.SkinTextBox();
            this.Login_password = new CCWin.SkinControl.SkinTextBox();
            this.Login_login = new CCWin.SkinControl.SkinButton();
            this.skinButton_register = new CCWin.SkinControl.SkinButton();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.netStatus = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.skinLabel1.Location = new System.Drawing.Point(64, 150);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(49, 14);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "账  号";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.skinLabel2.Location = new System.Drawing.Point(63, 206);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(49, 14);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "密  码";
            // 
            // Login_username
            // 
            this.Login_username.BackColor = System.Drawing.Color.Transparent;
            this.Login_username.DownBack = null;
            this.Login_username.Icon = null;
            this.Login_username.IconIsButton = false;
            this.Login_username.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.Login_username.IsPasswordChat = '\0';
            this.Login_username.IsSystemPasswordChar = false;
            this.Login_username.Lines = new string[] {
        "用户名"};
            this.Login_username.Location = new System.Drawing.Point(163, 143);
            this.Login_username.Margin = new System.Windows.Forms.Padding(0);
            this.Login_username.MaxLength = 32767;
            this.Login_username.MinimumSize = new System.Drawing.Size(28, 28);
            this.Login_username.MouseBack = null;
            this.Login_username.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.Login_username.Multiline = false;
            this.Login_username.Name = "Login_username";
            this.Login_username.NormlBack = null;
            this.Login_username.Padding = new System.Windows.Forms.Padding(5);
            this.Login_username.ReadOnly = false;
            this.Login_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Login_username.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.Login_username.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login_username.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_username.SkinTxt.Font = new System.Drawing.Font("楷体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_username.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.Login_username.SkinTxt.Name = "BaseText";
            this.Login_username.SkinTxt.Size = new System.Drawing.Size(175, 15);
            this.Login_username.SkinTxt.TabIndex = 0;
            this.Login_username.SkinTxt.Text = "用户名";
            this.Login_username.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Login_username.SkinTxt.WaterText = "";
            this.Login_username.TabIndex = 2;
            this.Login_username.Text = "用户名";
            this.Login_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Login_username.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Login_username.WaterText = "";
            this.Login_username.WordWrap = true;
            // 
            // Login_password
            // 
            this.Login_password.BackColor = System.Drawing.Color.Transparent;
            this.Login_password.DownBack = null;
            this.Login_password.Icon = null;
            this.Login_password.IconIsButton = false;
            this.Login_password.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.Login_password.IsPasswordChat = '●';
            this.Login_password.IsSystemPasswordChar = true;
            this.Login_password.Lines = new string[] {
        "12345678"};
            this.Login_password.Location = new System.Drawing.Point(163, 198);
            this.Login_password.Margin = new System.Windows.Forms.Padding(0);
            this.Login_password.MaxLength = 32767;
            this.Login_password.MinimumSize = new System.Drawing.Size(28, 28);
            this.Login_password.MouseBack = null;
            this.Login_password.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.Login_password.Multiline = false;
            this.Login_password.Name = "Login_password";
            this.Login_password.NormlBack = null;
            this.Login_password.Padding = new System.Windows.Forms.Padding(5);
            this.Login_password.ReadOnly = false;
            this.Login_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Login_password.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.Login_password.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login_password.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_password.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.Login_password.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.Login_password.SkinTxt.Name = "BaseText";
            this.Login_password.SkinTxt.PasswordChar = '●';
            this.Login_password.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.Login_password.SkinTxt.TabIndex = 0;
            this.Login_password.SkinTxt.Text = "12345678";
            this.Login_password.SkinTxt.UseSystemPasswordChar = true;
            this.Login_password.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Login_password.SkinTxt.WaterText = "";
            this.Login_password.TabIndex = 3;
            this.Login_password.Text = "12345678";
            this.Login_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Login_password.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Login_password.WaterText = "";
            this.Login_password.WordWrap = true;
            this.Login_password.Paint += new System.Windows.Forms.PaintEventHandler(this.skinTextBox2_Paint);
            // 
            // Login_login
            // 
            this.Login_login.BackColor = System.Drawing.Color.Transparent;
            this.Login_login.BaseColor = System.Drawing.Color.Silver;
            this.Login_login.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Login_login.DownBack = null;
            this.Login_login.ForeColor = System.Drawing.Color.DimGray;
            this.Login_login.Location = new System.Drawing.Point(99, 253);
            this.Login_login.MouseBack = null;
            this.Login_login.Name = "Login_login";
            this.Login_login.NormlBack = null;
            this.Login_login.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Login_login.Size = new System.Drawing.Size(77, 32);
            this.Login_login.TabIndex = 4;
            this.Login_login.Text = "登  陆";
            this.Login_login.UseVisualStyleBackColor = false;
            this.Login_login.Click += new System.EventHandler(this.skinButton_login_Click);
            // 
            // skinButton_register
            // 
            this.skinButton_register.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_register.BaseColor = System.Drawing.Color.Silver;
            this.skinButton_register.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_register.DownBack = null;
            this.skinButton_register.ForeColor = System.Drawing.Color.DimGray;
            this.skinButton_register.Location = new System.Drawing.Point(235, 253);
            this.skinButton_register.MouseBack = null;
            this.skinButton_register.Name = "skinButton_register";
            this.skinButton_register.NormlBack = null;
            this.skinButton_register.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton_register.Size = new System.Drawing.Size(81, 31);
            this.skinButton_register.TabIndex = 5;
            this.skinButton_register.Text = "注  册";
            this.skinButton_register.UseVisualStyleBackColor = false;
            this.skinButton_register.Click += new System.EventHandler(this.skinButton_register_Click);
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("skinPictureBox1.Image")));
            this.skinPictureBox1.Location = new System.Drawing.Point(153, 16);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(131, 109);
            this.skinPictureBox1.TabIndex = 6;
            this.skinPictureBox1.TabStop = false;
            // 
            // netStatus
            // 
            this.netStatus.AutoSize = true;
            this.netStatus.BackColor = System.Drawing.Color.Transparent;
            this.netStatus.BorderColor = System.Drawing.Color.White;
            this.netStatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.netStatus.ForeColor = System.Drawing.Color.Red;
            this.netStatus.Location = new System.Drawing.Point(178, 300);
            this.netStatus.Name = "netStatus";
            this.netStatus.Size = new System.Drawing.Size(0, 17);
            this.netStatus.TabIndex = 7;
            // 
            // Login
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(432, 329);
            this.Controls.Add(this.netStatus);
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(this.skinButton_register);
            this.Controls.Add(this.Login_login);
            this.Controls.Add(this.Login_password);
            this.Controls.Add(this.Login_username);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinTextBox Login_username;
        private CCWin.SkinControl.SkinTextBox Login_password;
        private CCWin.SkinControl.SkinButton Login_login;
        private CCWin.SkinControl.SkinButton skinButton_register;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinLabel netStatus;
    }
}

