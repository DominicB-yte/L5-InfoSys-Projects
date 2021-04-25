namespace _1019428_L5IS4_T1_Assessment_PP1
{
    partial class Meeting_Aim
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnMeeting = new System.Windows.Forms.RadioButton();
            this.rbtnSales = new System.Windows.Forms.RadioButton();
            this.rbtnInterview = new System.Windows.Forms.RadioButton();
            this.rbtnVisit = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please specify the nature of the meeting";
            // 
            // rbtnMeeting
            // 
            this.rbtnMeeting.AutoSize = true;
            this.rbtnMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMeeting.Location = new System.Drawing.Point(100, 120);
            this.rbtnMeeting.Name = "rbtnMeeting";
            this.rbtnMeeting.Size = new System.Drawing.Size(114, 30);
            this.rbtnMeeting.TabIndex = 1;
            this.rbtnMeeting.TabStop = true;
            this.rbtnMeeting.Text = "Meeting";
            this.rbtnMeeting.UseVisualStyleBackColor = true;
            // 
            // rbtnSales
            // 
            this.rbtnSales.AutoSize = true;
            this.rbtnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSales.Location = new System.Drawing.Point(355, 120);
            this.rbtnSales.Name = "rbtnSales";
            this.rbtnSales.Size = new System.Drawing.Size(221, 30);
            this.rbtnSales.TabIndex = 2;
            this.rbtnSales.TabStop = true;
            this.rbtnSales.Text = "Sales Appointment";
            this.rbtnSales.UseVisualStyleBackColor = true;
            // 
            // rbtnInterview
            // 
            this.rbtnInterview.AutoSize = true;
            this.rbtnInterview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInterview.Location = new System.Drawing.Point(355, 250);
            this.rbtnInterview.Name = "rbtnInterview";
            this.rbtnInterview.Size = new System.Drawing.Size(205, 30);
            this.rbtnInterview.TabIndex = 3;
            this.rbtnInterview.TabStop = true;
            this.rbtnInterview.Text = "Student Interview";
            this.rbtnInterview.UseVisualStyleBackColor = true;
            // 
            // rbtnVisit
            // 
            this.rbtnVisit.AutoSize = true;
            this.rbtnVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnVisit.Location = new System.Drawing.Point(100, 250);
            this.rbtnVisit.Name = "rbtnVisit";
            this.rbtnVisit.Size = new System.Drawing.Size(123, 30);
            this.rbtnVisit.TabIndex = 4;
            this.rbtnVisit.TabStop = true;
            this.rbtnVisit.Text = "Site Visit";
            this.rbtnVisit.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(440, 328);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(136, 48);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "O.K";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(248, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 48);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Meeting_Aim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rbtnVisit);
            this.Controls.Add(this.rbtnInterview);
            this.Controls.Add(this.rbtnSales);
            this.Controls.Add(this.rbtnMeeting);
            this.Controls.Add(this.label1);
            this.Name = "Meeting_Aim";
            this.Text = "Meeting_Aim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnMeeting;
        private System.Windows.Forms.RadioButton rbtnSales;
        private System.Windows.Forms.RadioButton rbtnInterview;
        private System.Windows.Forms.RadioButton rbtnVisit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}