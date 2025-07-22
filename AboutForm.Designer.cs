namespace GMLPretty
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lbAppName = new DarkUI.Controls.DarkLabel();
            this.lbVersion = new DarkUI.Controls.DarkLabel();
            this.lbAuthor = new DarkUI.Controls.DarkLabel();
            this.lbCopyright = new DarkUI.Controls.DarkLabel();
            this.lbLink = new DarkUI.Controls.DarkLabel();
            this.lbSourceInfo = new DarkUI.Controls.DarkLabel();
            this.lbAppInfo = new DarkUI.Controls.DarkLabel();
            this.btnOk = new DarkUI.Controls.DarkButton();
            this.SuspendLayout();
            // 
            // lbAppName
            // 
            this.lbAppName.AutoSize = true;
            this.lbAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbAppName.Location = new System.Drawing.Point(12, 9);
            this.lbAppName.Name = "lbAppName";
            this.lbAppName.Size = new System.Drawing.Size(77, 17);
            this.lbAppName.TabIndex = 0;
            this.lbAppName.Text = "AppName";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbVersion.Location = new System.Drawing.Point(12, 27);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(42, 13);
            this.lbVersion.TabIndex = 1;
            this.lbVersion.Text = "Version";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbAuthor.Location = new System.Drawing.Point(12, 91);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(38, 13);
            this.lbAuthor.TabIndex = 2;
            this.lbAuthor.Text = "Author";
            // 
            // lbCopyright
            // 
            this.lbCopyright.AutoSize = true;
            this.lbCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbCopyright.Location = new System.Drawing.Point(12, 133);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.Size = new System.Drawing.Size(51, 13);
            this.lbCopyright.TabIndex = 3;
            this.lbCopyright.Text = "Copyright";
            // 
            // lbLink
            // 
            this.lbLink.AutoSize = true;
            this.lbLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbLink.Location = new System.Drawing.Point(12, 165);
            this.lbLink.Name = "lbLink";
            this.lbLink.Size = new System.Drawing.Size(105, 13);
            this.lbLink.TabIndex = 4;
            this.lbLink.TabStop = true;
            this.lbLink.Text = "GitHub repository link";
            this.lbLink.Click += new System.EventHandler(this.lbLink_Click);
            // 
            // lbSourceInfo
            // 
            this.lbSourceInfo.AutoSize = true;
            this.lbSourceInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbSourceInfo.Location = new System.Drawing.Point(12, 153);
            this.lbSourceInfo.Name = "lbSourceInfo";
            this.lbSourceInfo.Size = new System.Drawing.Size(42, 13);
            this.lbSourceInfo.TabIndex = 5;
            this.lbSourceInfo.Text = "Źródło:";
            // 
            // lbAppInfo
            // 
            this.lbAppInfo.AutoSize = true;
            this.lbAppInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAppInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbAppInfo.Location = new System.Drawing.Point(12, 44);
            this.lbAppInfo.Name = "lbAppInfo";
            this.lbAppInfo.Size = new System.Drawing.Size(60, 13);
            this.lbAppInfo.TabIndex = 6;
            this.lbAppInfo.Text = "Description";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(249, 126);
            this.btnOk.Name = "btnOk";
            this.btnOk.Padding = new System.Windows.Forms.Padding(5);
            this.btnOk.Size = new System.Drawing.Size(61, 52);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // AboutForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 187);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lbAppInfo);
            this.Controls.Add(this.lbSourceInfo);
            this.Controls.Add(this.lbLink);
            this.Controls.Add(this.lbCopyright);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbAppName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "O programie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkLabel lbAppName;
        private DarkUI.Controls.DarkLabel lbVersion;
        private DarkUI.Controls.DarkLabel lbAuthor;
        private DarkUI.Controls.DarkLabel lbCopyright;
        private DarkUI.Controls.DarkLabel lbLink;
        private DarkUI.Controls.DarkLabel lbSourceInfo;
        private DarkUI.Controls.DarkLabel lbAppInfo;
        private DarkUI.Controls.DarkButton btnOk;
    }
}