namespace JupiterRunner
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnLoadlab = new System.Windows.Forms.Button();
            this.BtnLoadNote = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnReInstall = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLoadlab
            // 
            this.BtnLoadlab.Location = new System.Drawing.Point(39, 48);
            this.BtnLoadlab.Name = "BtnLoadlab";
            this.BtnLoadlab.Size = new System.Drawing.Size(142, 35);
            this.BtnLoadlab.TabIndex = 0;
            this.BtnLoadlab.Text = "Open Jupyter lab";
            this.BtnLoadlab.UseVisualStyleBackColor = true;
            this.BtnLoadlab.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnLoadNote
            // 
            this.BtnLoadNote.Location = new System.Drawing.Point(39, 99);
            this.BtnLoadNote.Name = "BtnLoadNote";
            this.BtnLoadNote.Size = new System.Drawing.Size(142, 35);
            this.BtnLoadNote.TabIndex = 1;
            this.BtnLoadNote.Text = "Open Jupyter notebook";
            this.BtnLoadNote.UseVisualStyleBackColor = true;
            this.BtnLoadNote.Click += new System.EventHandler(this.BtnLoadNote_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(225, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnReInstall});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // BtnReInstall
            // 
            this.BtnReInstall.Name = "BtnReInstall";
            this.BtnReInstall.Size = new System.Drawing.Size(158, 22);
            this.BtnReInstall.Text = "Reinstall jupyter";
            this.BtnReInstall.Click += new System.EventHandler(this.BtnReInstall_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 189);
            this.Controls.Add(this.BtnLoadNote);
            this.Controls.Add(this.BtnLoadlab);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jupiter Runner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadlab;
        private System.Windows.Forms.Button BtnLoadNote;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnReInstall;
    }
}

