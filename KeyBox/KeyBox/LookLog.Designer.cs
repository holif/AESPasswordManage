namespace KeyBox
{
    partial class LookLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookLog));
            this.Btn_ruturn = new CCWin.SkinControl.SkinButton();
            this.waterText = new CCWin.SkinControl.SkinAlphaWaterTextBox();
            this.SuspendLayout();
            // 
            // Btn_ruturn
            // 
            this.Btn_ruturn.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ruturn.BaseColor = System.Drawing.Color.Silver;
            this.Btn_ruturn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_ruturn.DownBack = null;
            this.Btn_ruturn.Location = new System.Drawing.Point(490, 365);
            this.Btn_ruturn.MouseBack = null;
            this.Btn_ruturn.Name = "Btn_ruturn";
            this.Btn_ruturn.NormlBack = null;
            this.Btn_ruturn.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_ruturn.Size = new System.Drawing.Size(75, 30);
            this.Btn_ruturn.TabIndex = 1;
            this.Btn_ruturn.Text = "返回";
            this.Btn_ruturn.UseVisualStyleBackColor = false;
            this.Btn_ruturn.Click += new System.EventHandler(this.Btn_ruturn_Click);
            // 
            // waterText
            // 
            this.waterText.BackAlpha = 10;
            this.waterText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.waterText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.waterText.Location = new System.Drawing.Point(22, 42);
            this.waterText.Multiline = true;
            this.waterText.Name = "waterText";
            this.waterText.ReadOnly = true;
            this.waterText.Size = new System.Drawing.Size(543, 312);
            this.waterText.TabIndex = 2;
            this.waterText.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.waterText.WaterFont = new System.Drawing.Font("微软雅黑", 8.5F);
            this.waterText.WaterText = "";
            // 
            // LookLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(589, 410);
            this.Controls.Add(this.waterText);
            this.Controls.Add(this.Btn_ruturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LookLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看操作日志";
            this.Load += new System.EventHandler(this.LookLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton Btn_ruturn;
        private CCWin.SkinControl.SkinAlphaWaterTextBox waterText;

    }
}