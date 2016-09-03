namespace KeyBox
{
    partial class SetKeyPath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetKeyPath));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.text_keyPath = new CCWin.SkinControl.SkinWaterTextBox();
            this.Btn_setpath = new CCWin.SkinControl.SkinButton();
            this.Btn_return = new CCWin.SkinControl.SkinButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(25, 51);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(37, 20);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "路径";
            // 
            // text_keyPath
            // 
            this.text_keyPath.Location = new System.Drawing.Point(73, 51);
            this.text_keyPath.Name = "text_keyPath";
            this.text_keyPath.Size = new System.Drawing.Size(339, 21);
            this.text_keyPath.TabIndex = 2;
            this.text_keyPath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_keyPath.WaterText = "";
            this.text_keyPath.Enter += new System.EventHandler(this.text_keyPath_Enter);
            // 
            // Btn_setpath
            // 
            this.Btn_setpath.BackColor = System.Drawing.Color.Transparent;
            this.Btn_setpath.BaseColor = System.Drawing.Color.Silver;
            this.Btn_setpath.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_setpath.DownBack = null;
            this.Btn_setpath.Location = new System.Drawing.Point(252, 91);
            this.Btn_setpath.MouseBack = null;
            this.Btn_setpath.Name = "Btn_setpath";
            this.Btn_setpath.NormlBack = null;
            this.Btn_setpath.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_setpath.Size = new System.Drawing.Size(75, 26);
            this.Btn_setpath.TabIndex = 1;
            this.Btn_setpath.Text = "确认设置";
            this.Btn_setpath.UseVisualStyleBackColor = false;
            this.Btn_setpath.Click += new System.EventHandler(this.Btn_setpath_Click);
            // 
            // Btn_return
            // 
            this.Btn_return.BackColor = System.Drawing.Color.Transparent;
            this.Btn_return.BaseColor = System.Drawing.Color.Silver;
            this.Btn_return.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_return.DownBack = null;
            this.Btn_return.Location = new System.Drawing.Point(354, 91);
            this.Btn_return.MouseBack = null;
            this.Btn_return.Name = "Btn_return";
            this.Btn_return.NormlBack = null;
            this.Btn_return.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_return.Size = new System.Drawing.Size(75, 26);
            this.Btn_return.TabIndex = 3;
            this.Btn_return.Text = "返回";
            this.Btn_return.UseVisualStyleBackColor = false;
            this.Btn_return.Click += new System.EventHandler(this.Btn_return_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(26, 81);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(113, 17);
            this.skinLabel2.TabIndex = 4;
            this.skinLabel2.Text = "如：c:\\dir\\keypath";
            // 
            // SetKeyPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(453, 131);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.Btn_return);
            this.Controls.Add(this.Btn_setpath);
            this.Controls.Add(this.text_keyPath);
            this.Controls.Add(this.skinLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetKeyPath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置Key图片路径";
            this.Load += new System.EventHandler(this.SetKeyPath_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinWaterTextBox text_keyPath;
        private CCWin.SkinControl.SkinButton Btn_setpath;
        private CCWin.SkinControl.SkinButton Btn_return;
        private CCWin.SkinControl.SkinLabel skinLabel2;
    }
}