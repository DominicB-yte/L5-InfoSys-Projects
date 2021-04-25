namespace PP04Coursework
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ndLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rdLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thLevelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stLevelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // stLevelToolStripMenuItem
            // 
            this.stLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ndLevelToolStripMenuItem});
            this.stLevelToolStripMenuItem.Name = "stLevelToolStripMenuItem";
            this.stLevelToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.stLevelToolStripMenuItem.Text = "1st";
            // 
            // ndLevelToolStripMenuItem
            // 
            this.ndLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rdLevelToolStripMenuItem});
            this.ndLevelToolStripMenuItem.Name = "ndLevelToolStripMenuItem";
            this.ndLevelToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.ndLevelToolStripMenuItem.Text = "2nd Level";
            // 
            // rdLevelToolStripMenuItem
            // 
            this.rdLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thLevelToolStripMenuItem});
            this.rdLevelToolStripMenuItem.Name = "rdLevelToolStripMenuItem";
            this.rdLevelToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.rdLevelToolStripMenuItem.Text = "3rd Level";
            // 
            // thLevelToolStripMenuItem
            // 
            this.thLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thLevelToolStripMenuItem1});
            this.thLevelToolStripMenuItem.Name = "thLevelToolStripMenuItem";
            this.thLevelToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.thLevelToolStripMenuItem.Text = "4th Level";
            // 
            // thLevelToolStripMenuItem1
            // 
            this.thLevelToolStripMenuItem1.Name = "thLevelToolStripMenuItem1";
            this.thLevelToolStripMenuItem1.Size = new System.Drawing.Size(252, 30);
            this.thLevelToolStripMenuItem1.Text = "5th Level";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ndLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rdLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thLevelToolStripMenuItem1;
    }
}