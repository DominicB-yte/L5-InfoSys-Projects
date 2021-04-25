namespace PP05Classwork
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
            this.btnCustomDialog = new System.Windows.Forms.Button();
            this.lblChanger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCustomDialog
            // 
            this.btnCustomDialog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCustomDialog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomDialog.Location = new System.Drawing.Point(0, 0);
            this.btnCustomDialog.Name = "btnCustomDialog";
            this.btnCustomDialog.Size = new System.Drawing.Size(800, 89);
            this.btnCustomDialog.TabIndex = 0;
            this.btnCustomDialog.Text = "Custom Dialog ";
            this.btnCustomDialog.UseVisualStyleBackColor = false;
            this.btnCustomDialog.Click += new System.EventHandler(this.btnCustomDialog_Click);
            // 
            // lblChanger
            // 
            this.lblChanger.AutoSize = true;
            this.lblChanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChanger.Location = new System.Drawing.Point(25, 224);
            this.lblChanger.Name = "lblChanger";
            this.lblChanger.Size = new System.Drawing.Size(741, 69);
            this.lblChanger.TabIndex = 1;
            this.lblChanger.Text = "[CURRENTLY DISABLED]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChanger);
            this.Controls.Add(this.btnCustomDialog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomDialog;
        private System.Windows.Forms.Label lblChanger;
    }
}

