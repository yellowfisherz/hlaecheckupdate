namespace HLAEUpdateCheck
{
    partial class MainWin
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Label = new System.Windows.Forms.Label();
            this.GitHub = new System.Windows.Forms.LinkLabel();
            this.HlaeChinese = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label.Location = new System.Drawing.Point(12, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(278, 55);
            this.Label.TabIndex = 0;
            this.Label.Text = "正在检查更新中";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GitHub
            // 
            this.GitHub.AutoSize = true;
            this.GitHub.Location = new System.Drawing.Point(40, 75);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(89, 12);
            this.GitHub.TabIndex = 1;
            this.GitHub.TabStop = true;
            this.GitHub.Text = "GitHub更新链接";
            this.GitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHub_LinkClicked);
            // 
            // HlaeChinese
            // 
            this.HlaeChinese.AutoSize = true;
            this.HlaeChinese.Location = new System.Drawing.Point(163, 75);
            this.HlaeChinese.Name = "HlaeChinese";
            this.HlaeChinese.Size = new System.Drawing.Size(113, 12);
            this.HlaeChinese.TabIndex = 2;
            this.HlaeChinese.TabStop = true;
            this.HlaeChinese.Text = "HLAE中文站更新链接";
            this.HlaeChinese.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HlaeChinese_LinkClicked);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 96);
            this.Controls.Add(this.HlaeChinese);
            this.Controls.Add(this.GitHub);
            this.Controls.Add(this.Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWin";
            this.Text = "HLAE更新检查器";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.LinkLabel GitHub;
        private System.Windows.Forms.LinkLabel HlaeChinese;
    }
}

