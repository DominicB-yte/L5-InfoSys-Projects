namespace ClassesCoursework
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
            this.btnAlice = new System.Windows.Forms.Button();
            this.btnBob = new System.Windows.Forms.Button();
            this.btnCindy = new System.Windows.Forms.Button();
            this.btnDan = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlice
            // 
            this.btnAlice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlice.Location = new System.Drawing.Point(30, 30);
            this.btnAlice.Name = "btnAlice";
            this.btnAlice.Size = new System.Drawing.Size(90, 50);
            this.btnAlice.TabIndex = 0;
            this.btnAlice.Text = "Alice";
            this.btnAlice.UseVisualStyleBackColor = true;
            this.btnAlice.Click += new System.EventHandler(this.btnAlice_Click);
            // 
            // btnBob
            // 
            this.btnBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBob.Location = new System.Drawing.Point(150, 30);
            this.btnBob.Name = "btnBob";
            this.btnBob.Size = new System.Drawing.Size(90, 50);
            this.btnBob.TabIndex = 1;
            this.btnBob.Text = "Bob";
            this.btnBob.UseVisualStyleBackColor = true;
            this.btnBob.Click += new System.EventHandler(this.btnBob_Click);
            // 
            // btnCindy
            // 
            this.btnCindy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCindy.Location = new System.Drawing.Point(150, 100);
            this.btnCindy.Name = "btnCindy";
            this.btnCindy.Size = new System.Drawing.Size(90, 50);
            this.btnCindy.TabIndex = 2;
            this.btnCindy.Text = "Cindy";
            this.btnCindy.UseVisualStyleBackColor = true;
            this.btnCindy.Click += new System.EventHandler(this.btnCindy_Click);
            // 
            // btnDan
            // 
            this.btnDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDan.Location = new System.Drawing.Point(30, 100);
            this.btnDan.Name = "btnDan";
            this.btnDan.Size = new System.Drawing.Size(90, 50);
            this.btnDan.TabIndex = 3;
            this.btnDan.Text = "Dan";
            this.btnDan.UseVisualStyleBackColor = true;
            this.btnDan.Click += new System.EventHandler(this.btnDan_Click);
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(30, 170);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(210, 50);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Cindy\'s Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 262);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnDan);
            this.Controls.Add(this.btnCindy);
            this.Controls.Add(this.btnBob);
            this.Controls.Add(this.btnAlice);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlice;
        private System.Windows.Forms.Button btnBob;
        private System.Windows.Forms.Button btnCindy;
        private System.Windows.Forms.Button btnDan;
        private System.Windows.Forms.Button btnReports;
    }
}