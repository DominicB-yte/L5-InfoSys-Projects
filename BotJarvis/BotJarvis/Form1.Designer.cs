namespace BotJarvis
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
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.bntClearChat = new System.Windows.Forms.Button();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.pbChatbot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbChatbot)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSend
            // 
            this.txtSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSend.Location = new System.Drawing.Point(30, 500);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(600, 35);
            this.txtSend.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(30, 550);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(600, 40);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // bntClearChat
            // 
            this.bntClearChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntClearChat.Location = new System.Drawing.Point(650, 550);
            this.bntClearChat.Name = "bntClearChat";
            this.bntClearChat.Size = new System.Drawing.Size(600, 40);
            this.bntClearChat.TabIndex = 4;
            this.bntClearChat.Text = "Clear Chat";
            this.bntClearChat.UseVisualStyleBackColor = true;
            this.bntClearChat.Click += new System.EventHandler(this.bntClearChat_Click);
            // 
            // lbChat
            // 
            this.lbChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChat.FormattingEnabled = true;
            this.lbChat.ItemHeight = 25;
            this.lbChat.Location = new System.Drawing.Point(650, 30);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(600, 504);
            this.lbChat.TabIndex = 5;
            // 
            // pbChatbot
            // 
            this.pbChatbot.Image = global::BotJarvis.Properties.Resources.merlin_135847308_098289a6_90ee_461b_88e2_20920469f96a_articleLarge2;
            this.pbChatbot.Location = new System.Drawing.Point(30, 30);
            this.pbChatbot.Name = "pbChatbot";
            this.pbChatbot.Size = new System.Drawing.Size(600, 450);
            this.pbChatbot.TabIndex = 0;
            this.pbChatbot.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 612);
            this.Controls.Add(this.lbChat);
            this.Controls.Add(this.bntClearChat);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.pbChatbot);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbChatbot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbChatbot;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button bntClearChat;
        private System.Windows.Forms.ListBox lbChat;
    }
}

