namespace PP05Dialogs
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
            this.btnShowDialog = new System.Windows.Forms.Button();
            this.btnColourDialog = new System.Windows.Forms.Button();
            this.btnFontDialog = new System.Windows.Forms.Button();
            this.btnFolderDialog = new System.Windows.Forms.Button();
            this.btnFileopenDialog = new System.Windows.Forms.Button();
            this.btnFilesaveDialog = new System.Windows.Forms.Button();
            this.btnPrintDialog = new System.Windows.Forms.Button();
            this.btnCustomDialog = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnVariable = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbLockd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Location = new System.Drawing.Point(12, 12);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(282, 38);
            this.btnShowDialog.TabIndex = 0;
            this.btnShowDialog.Text = "Show";
            this.btnShowDialog.UseVisualStyleBackColor = true;
            // 
            // btnColourDialog
            // 
            this.btnColourDialog.Location = new System.Drawing.Point(300, 12);
            this.btnColourDialog.Name = "btnColourDialog";
            this.btnColourDialog.Size = new System.Drawing.Size(96, 38);
            this.btnColourDialog.TabIndex = 1;
            this.btnColourDialog.Text = "Colour";
            this.btnColourDialog.UseVisualStyleBackColor = true;
            this.btnColourDialog.Click += new System.EventHandler(this.btnColourDialog_Click);
            // 
            // btnFontDialog
            // 
            this.btnFontDialog.Location = new System.Drawing.Point(300, 56);
            this.btnFontDialog.Name = "btnFontDialog";
            this.btnFontDialog.Size = new System.Drawing.Size(96, 38);
            this.btnFontDialog.TabIndex = 2;
            this.btnFontDialog.Text = "Font";
            this.btnFontDialog.UseVisualStyleBackColor = true;
            this.btnFontDialog.Click += new System.EventHandler(this.btnFontDialog_Click);
            // 
            // btnFolderDialog
            // 
            this.btnFolderDialog.Location = new System.Drawing.Point(300, 100);
            this.btnFolderDialog.Name = "btnFolderDialog";
            this.btnFolderDialog.Size = new System.Drawing.Size(96, 38);
            this.btnFolderDialog.TabIndex = 3;
            this.btnFolderDialog.Text = "Folder";
            this.btnFolderDialog.UseVisualStyleBackColor = true;
            this.btnFolderDialog.Click += new System.EventHandler(this.btnFolderDialog_Click);
            // 
            // btnFileopenDialog
            // 
            this.btnFileopenDialog.Location = new System.Drawing.Point(300, 144);
            this.btnFileopenDialog.Name = "btnFileopenDialog";
            this.btnFileopenDialog.Size = new System.Drawing.Size(96, 38);
            this.btnFileopenDialog.TabIndex = 4;
            this.btnFileopenDialog.Text = "Open File";
            this.btnFileopenDialog.UseVisualStyleBackColor = true;
            this.btnFileopenDialog.Click += new System.EventHandler(this.btnFileopenDialog_Click);
            // 
            // btnFilesaveDialog
            // 
            this.btnFilesaveDialog.Location = new System.Drawing.Point(300, 188);
            this.btnFilesaveDialog.Name = "btnFilesaveDialog";
            this.btnFilesaveDialog.Size = new System.Drawing.Size(96, 38);
            this.btnFilesaveDialog.TabIndex = 5;
            this.btnFilesaveDialog.Text = "Save File";
            this.btnFilesaveDialog.UseVisualStyleBackColor = true;
            this.btnFilesaveDialog.Click += new System.EventHandler(this.btnFilesaveDialog_Click);
            // 
            // btnPrintDialog
            // 
            this.btnPrintDialog.Location = new System.Drawing.Point(300, 232);
            this.btnPrintDialog.Name = "btnPrintDialog";
            this.btnPrintDialog.Size = new System.Drawing.Size(96, 38);
            this.btnPrintDialog.TabIndex = 6;
            this.btnPrintDialog.Text = "Print";
            this.btnPrintDialog.UseVisualStyleBackColor = true;
            this.btnPrintDialog.Click += new System.EventHandler(this.btnPrintDialog_Click);
            // 
            // btnCustomDialog
            // 
            this.btnCustomDialog.Location = new System.Drawing.Point(300, 278);
            this.btnCustomDialog.Name = "btnCustomDialog";
            this.btnCustomDialog.Size = new System.Drawing.Size(96, 38);
            this.btnCustomDialog.TabIndex = 7;
            this.btnCustomDialog.Text = "Custom";
            this.btnCustomDialog.UseVisualStyleBackColor = true;
            this.btnCustomDialog.Click += new System.EventHandler(this.btnCustomDialog_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 214);
            this.textBox1.TabIndex = 8;
            // 
            // btnVariable
            // 
            this.btnVariable.Location = new System.Drawing.Point(12, 278);
            this.btnVariable.Name = "btnVariable";
            this.btnVariable.Size = new System.Drawing.Size(282, 38);
            this.btnVariable.TabIndex = 9;
            this.btnVariable.Text = "Variable";
            this.btnVariable.UseVisualStyleBackColor = true;
            this.btnVariable.Click += new System.EventHandler(this.btnVariable_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(520, 32);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 38);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbLockd
            // 
            this.lbLockd.AutoSize = true;
            this.lbLockd.Location = new System.Drawing.Point(545, 9);
            this.lbLockd.Name = "lbLockd";
            this.lbLockd.Size = new System.Drawing.Size(71, 20);
            this.lbLockd.TabIndex = 11;
            this.lbLockd.Text = "[LOCKD]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 494);
            this.Controls.Add(this.lbLockd);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnVariable);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCustomDialog);
            this.Controls.Add(this.btnPrintDialog);
            this.Controls.Add(this.btnFilesaveDialog);
            this.Controls.Add(this.btnFileopenDialog);
            this.Controls.Add(this.btnFolderDialog);
            this.Controls.Add(this.btnFontDialog);
            this.Controls.Add(this.btnColourDialog);
            this.Controls.Add(this.btnShowDialog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowDialog;
        private System.Windows.Forms.Button btnColourDialog;
        private System.Windows.Forms.Button btnFontDialog;
        private System.Windows.Forms.Button btnFolderDialog;
        private System.Windows.Forms.Button btnFileopenDialog;
        private System.Windows.Forms.Button btnFilesaveDialog;
        private System.Windows.Forms.Button btnPrintDialog;
        private System.Windows.Forms.Button btnCustomDialog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnVariable;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbLockd;
    }
}

