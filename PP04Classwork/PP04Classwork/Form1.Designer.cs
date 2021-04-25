namespace PP04Classwork
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatColourMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatBackColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatFontMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatColourRedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatColourGreenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatColourBlueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatBackColourPinkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatBackColourLGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatBackColourLBlueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatFontSmallMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatFontMediumMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatFontLargeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxContents = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FormatContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatColourContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatColourRedContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ForamtColourGreenContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatColourBlueContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatBackColourContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatBackColourPinkContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatBackColourLGreenContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatBackColourLBlueContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatFontContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatFontSmallContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatFontMediumContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatFontLargeContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.FormatMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(50, 29);
            this.FileMenuItem.Text = "&File";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(252, 30);
            this.ExitMenuItem.Text = "E&xit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // FormatMenuItem
            // 
            this.FormatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatColourMenuItem,
            this.FormatBackColourToolStripMenuItem,
            this.FormatFontMenuItem});
            this.FormatMenuItem.Name = "FormatMenuItem";
            this.FormatMenuItem.Size = new System.Drawing.Size(81, 29);
            this.FormatMenuItem.Text = "F&ormat";
            // 
            // FormatColourMenuItem
            // 
            this.FormatColourMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatColourRedMenuItem,
            this.FormatColourGreenMenuItem,
            this.FormatColourBlueMenuItem});
            this.FormatColourMenuItem.Name = "FormatColourMenuItem";
            this.FormatColourMenuItem.Size = new System.Drawing.Size(252, 30);
            this.FormatColourMenuItem.Text = "&Colour";
            // 
            // FormatBackColourToolStripMenuItem
            // 
            this.FormatBackColourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatBackColourPinkMenuItem,
            this.FormatBackColourLGreenToolStripMenuItem,
            this.FormatBackColourLBlueMenuItem});
            this.FormatBackColourToolStripMenuItem.Name = "FormatBackColourToolStripMenuItem";
            this.FormatBackColourToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.FormatBackColourToolStripMenuItem.Text = "Background &Colour";
            // 
            // FormatFontMenuItem
            // 
            this.FormatFontMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatFontSmallMenuItem,
            this.FormatFontMediumMenuItem,
            this.FormatFontLargeMenuItem});
            this.FormatFontMenuItem.Name = "FormatFontMenuItem";
            this.FormatFontMenuItem.Size = new System.Drawing.Size(252, 30);
            this.FormatFontMenuItem.Text = "&Font";
            // 
            // FormatColourRedMenuItem
            // 
            this.FormatColourRedMenuItem.Name = "FormatColourRedMenuItem";
            this.FormatColourRedMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.FormatColourRedMenuItem.Size = new System.Drawing.Size(252, 30);
            this.FormatColourRedMenuItem.Text = "&Red";
            this.FormatColourRedMenuItem.Click += new System.EventHandler(this.FormatColourRedMenuItem_Click);
            // 
            // FormatColourGreenMenuItem
            // 
            this.FormatColourGreenMenuItem.Name = "FormatColourGreenMenuItem";
            this.FormatColourGreenMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.FormatColourGreenMenuItem.Size = new System.Drawing.Size(252, 30);
            this.FormatColourGreenMenuItem.Text = "&Green";
            this.FormatColourGreenMenuItem.Click += new System.EventHandler(this.FormatColourGreenMenuItem_Click);
            // 
            // FormatColourBlueMenuItem
            // 
            this.FormatColourBlueMenuItem.Name = "FormatColourBlueMenuItem";
            this.FormatColourBlueMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.FormatColourBlueMenuItem.Size = new System.Drawing.Size(252, 30);
            this.FormatColourBlueMenuItem.Text = "&Blue";
            this.FormatColourBlueMenuItem.Click += new System.EventHandler(this.FormatColourBlueMenuItem_Click);
            // 
            // FormatBackColourPinkMenuItem
            // 
            this.FormatBackColourPinkMenuItem.Name = "FormatBackColourPinkMenuItem";
            this.FormatBackColourPinkMenuItem.Size = new System.Drawing.Size(252, 30);
            this.FormatBackColourPinkMenuItem.Text = "&Pink";
            this.FormatBackColourPinkMenuItem.Click += new System.EventHandler(this.FormatBackColourPinkMenuItem_Click);
            // 
            // FormatBackColourLGreenToolStripMenuItem
            // 
            this.FormatBackColourLGreenToolStripMenuItem.Name = "FormatBackColourLGreenToolStripMenuItem";
            this.FormatBackColourLGreenToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.FormatBackColourLGreenToolStripMenuItem.Text = "Light &Green";
            this.FormatBackColourLGreenToolStripMenuItem.Click += new System.EventHandler(this.FormatBackColourLGreenToolStripMenuItem_Click);
            // 
            // FormatBackColourLBlueMenuItem
            // 
            this.FormatBackColourLBlueMenuItem.Name = "FormatBackColourLBlueMenuItem";
            this.FormatBackColourLBlueMenuItem.Size = new System.Drawing.Size(252, 30);
            this.FormatBackColourLBlueMenuItem.Text = "Light &Blue";
            this.FormatBackColourLBlueMenuItem.Click += new System.EventHandler(this.FormatBackColourLBlueMenuItem_Click);
            // 
            // FormatFontSmallMenuItem
            // 
            this.FormatFontSmallMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.FormatFontSmallMenuItem.Name = "FormatFontSmallMenuItem";
            this.FormatFontSmallMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.FormatFontSmallMenuItem.Size = new System.Drawing.Size(337, 58);
            this.FormatFontSmallMenuItem.Text = "&Small";
            this.FormatFontSmallMenuItem.Click += new System.EventHandler(this.FormatFontSmallMenuItem_Click);
            // 
            // FormatFontMediumMenuItem
            // 
            this.FormatFontMediumMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormatFontMediumMenuItem.Name = "FormatFontMediumMenuItem";
            this.FormatFontMediumMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.FormatFontMediumMenuItem.Size = new System.Drawing.Size(337, 58);
            this.FormatFontMediumMenuItem.Text = "&Medium";
            this.FormatFontMediumMenuItem.Click += new System.EventHandler(this.FormatFontMediumMenuItem_Click);
            // 
            // FormatFontLargeMenuItem
            // 
            this.FormatFontLargeMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.FormatFontLargeMenuItem.Name = "FormatFontLargeMenuItem";
            this.FormatFontLargeMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.FormatFontLargeMenuItem.Size = new System.Drawing.Size(337, 58);
            this.FormatFontLargeMenuItem.Text = "&Large";
            this.FormatFontLargeMenuItem.Click += new System.EventHandler(this.FormatFontLargeMenuItem_Click);
            // 
            // textBoxContents
            // 
            this.textBoxContents.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxContents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContents.Location = new System.Drawing.Point(0, 33);
            this.textBoxContents.Multiline = true;
            this.textBoxContents.Name = "textBoxContents";
            this.textBoxContents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContents.Size = new System.Drawing.Size(800, 417);
            this.textBoxContents.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatContextMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 34);
            // 
            // FormatContextMenuItem
            // 
            this.FormatContextMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatColourContextMenuItem,
            this.FormatBackColourContextMenuItem,
            this.FormatFontContextMenuItem});
            this.FormatContextMenuItem.Name = "FormatContextMenuItem";
            this.FormatContextMenuItem.Size = new System.Drawing.Size(141, 30);
            this.FormatContextMenuItem.Text = "F&ormat";
            // 
            // FormatColourContextMenuItem
            // 
            this.FormatColourContextMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatColourRedContextMenuItem,
            this.ForamtColourGreenContextMenuItem,
            this.FormatColourBlueContextMenuItem});
            this.FormatColourContextMenuItem.Name = "FormatColourContextMenuItem";
            this.FormatColourContextMenuItem.Size = new System.Drawing.Size(252, 30);
            this.FormatColourContextMenuItem.Text = "&Colour";
            // 
            // FormatColourRedContextMenuItem
            // 
            this.FormatColourRedContextMenuItem.Name = "FormatColourRedContextMenuItem";
            this.FormatColourRedContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.FormatColourRedContextMenuItem.Size = new System.Drawing.Size(252, 30);
            this.FormatColourRedContextMenuItem.Text = "&Red";
            this.FormatColourRedContextMenuItem.Click += new System.EventHandler(this.FormatColourRedMenuItem_Click);
            // 
            // ForamtColourGreenContextMenuItem
            // 
            this.ForamtColourGreenContextMenuItem.Name = "ForamtColourGreenContextMenuItem";
            this.ForamtColourGreenContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.ForamtColourGreenContextMenuItem.Size = new System.Drawing.Size(252, 30);
            this.ForamtColourGreenContextMenuItem.Text = "&Green";
            this.ForamtColourGreenContextMenuItem.Click += new System.EventHandler(this.FormatColourGreenMenuItem_Click);
            // 
            // FormatColourBlueContextMenuItem
            // 
            this.FormatColourBlueContextMenuItem.Name = "FormatColourBlueContextMenuItem";
            this.FormatColourBlueContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.FormatColourBlueContextMenuItem.Size = new System.Drawing.Size(252, 30);
            this.FormatColourBlueContextMenuItem.Text = "&Blue";
            this.FormatColourBlueContextMenuItem.Click += new System.EventHandler(this.FormatColourBlueMenuItem_Click);
            // 
            // FormatBackColourContextMenuItem
            // 
            this.FormatBackColourContextMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatBackColourPinkContextMenuItem,
            this.FormatBackColourLGreenContextMenuItem,
            this.FormatBackColourLBlueContextMenuItem});
            this.FormatBackColourContextMenuItem.Name = "FormatBackColourContextMenuItem";
            this.FormatBackColourContextMenuItem.Size = new System.Drawing.Size(252, 30);
            this.FormatBackColourContextMenuItem.Text = "Background &Colour";
            // 
            // FormatBackColourPinkContextMenuItem
            // 
            this.FormatBackColourPinkContextMenuItem.Name = "FormatBackColourPinkContextMenuItem";
            this.FormatBackColourPinkContextMenuItem.Size = new System.Drawing.Size(252, 30);
            this.FormatBackColourPinkContextMenuItem.Text = "&Pink";
            this.FormatBackColourPinkContextMenuItem.Click += new System.EventHandler(this.FormatBackColourPinkMenuItem_Click);
            // 
            // FormatBackColourLGreenContextMenuItem
            // 
            this.FormatBackColourLGreenContextMenuItem.Name = "FormatBackColourLGreenContextMenuItem";
            this.FormatBackColourLGreenContextMenuItem.Size = new System.Drawing.Size(252, 30);
            this.FormatBackColourLGreenContextMenuItem.Text = "Light &Green";
            this.FormatBackColourLGreenContextMenuItem.Click += new System.EventHandler(this.FormatBackColourLGreenToolStripMenuItem_Click);
            // 
            // FormatBackColourLBlueContextMenuItem
            // 
            this.FormatBackColourLBlueContextMenuItem.Name = "FormatBackColourLBlueContextMenuItem";
            this.FormatBackColourLBlueContextMenuItem.Size = new System.Drawing.Size(252, 30);
            this.FormatBackColourLBlueContextMenuItem.Text = "Light &Blue";
            this.FormatBackColourLBlueContextMenuItem.Click += new System.EventHandler(this.FormatBackColourLBlueMenuItem_Click);
            // 
            // FormatFontContextMenuItem
            // 
            this.FormatFontContextMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatFontSmallContextMenuItem,
            this.FormatFontMediumContextMenuItem,
            this.FormatFontLargeContextMenuItem});
            this.FormatFontContextMenuItem.Name = "FormatFontContextMenuItem";
            this.FormatFontContextMenuItem.Size = new System.Drawing.Size(252, 30);
            this.FormatFontContextMenuItem.Text = "&Font";
            // 
            // FormatFontSmallContextMenuItem
            // 
            this.FormatFontSmallContextMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.FormatFontSmallContextMenuItem.Name = "FormatFontSmallContextMenuItem";
            this.FormatFontSmallContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.FormatFontSmallContextMenuItem.Size = new System.Drawing.Size(337, 58);
            this.FormatFontSmallContextMenuItem.Text = "&Small";
            this.FormatFontSmallContextMenuItem.Click += new System.EventHandler(this.FormatFontSmallMenuItem_Click);
            // 
            // FormatFontMediumContextMenuItem
            // 
            this.FormatFontMediumContextMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormatFontMediumContextMenuItem.Name = "FormatFontMediumContextMenuItem";
            this.FormatFontMediumContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.FormatFontMediumContextMenuItem.Size = new System.Drawing.Size(337, 58);
            this.FormatFontMediumContextMenuItem.Text = "&Medium";
            this.FormatFontMediumContextMenuItem.Click += new System.EventHandler(this.FormatFontMediumMenuItem_Click);
            // 
            // FormatFontLargeContextMenuItem
            // 
            this.FormatFontLargeContextMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.FormatFontLargeContextMenuItem.Name = "FormatFontLargeContextMenuItem";
            this.FormatFontLargeContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.FormatFontLargeContextMenuItem.Size = new System.Drawing.Size(337, 58);
            this.FormatFontLargeContextMenuItem.Text = "&Large";
            this.FormatFontLargeContextMenuItem.Click += new System.EventHandler(this.FormatFontLargeMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxContents);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatColourMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatColourRedMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatColourGreenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatColourBlueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatBackColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatBackColourPinkMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatBackColourLGreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatBackColourLBlueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatFontMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatFontSmallMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatFontMediumMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatFontLargeMenuItem;
        private System.Windows.Forms.TextBox textBoxContents;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FormatContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatColourContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatColourRedContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ForamtColourGreenContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatColourBlueContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatBackColourContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatBackColourPinkContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatBackColourLGreenContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatBackColourLBlueContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatFontContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatFontSmallContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatFontMediumContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatFontLargeContextMenuItem;
    }
}

