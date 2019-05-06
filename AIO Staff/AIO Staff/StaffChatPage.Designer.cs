﻿namespace AIO_Staff
{
    partial class StaffChatPage
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Label();
            this.aioMessageTextBox = new System.Windows.Forms.TextBox();
            this.aioSendBtn = new System.Windows.Forms.Label();
            this.messageScreenListBox = new System.Windows.Forms.ListBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::AIO_Staff.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(118, 137);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::AIO_Staff.Properties.Resources.closeBtn;
            this.closeBtn.Location = new System.Drawing.Point(658, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(36, 36);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // aioMessageTextBox
            // 
            this.aioMessageTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.aioMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aioMessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aioMessageTextBox.ForeColor = System.Drawing.Color.Gray;
            this.aioMessageTextBox.Location = new System.Drawing.Point(154, 71);
            this.aioMessageTextBox.Name = "aioMessageTextBox";
            this.aioMessageTextBox.Size = new System.Drawing.Size(373, 46);
            this.aioMessageTextBox.TabIndex = 2;
            this.aioMessageTextBox.Text = "Example Message";
            this.aioMessageTextBox.MouseEnter += new System.EventHandler(this.aioMessageTextBox_MouseEnter);
            this.aioMessageTextBox.MouseLeave += new System.EventHandler(this.aioMessageTextBox_MouseLeave);
            // 
            // aioSendBtn
            // 
            this.aioSendBtn.BackColor = System.Drawing.Color.Transparent;
            this.aioSendBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aioSendBtn.ForeColor = System.Drawing.Color.White;
            this.aioSendBtn.Image = global::AIO_Staff.Properties.Resources.btn21;
            this.aioSendBtn.Location = new System.Drawing.Point(533, 67);
            this.aioSendBtn.Name = "aioSendBtn";
            this.aioSendBtn.Size = new System.Drawing.Size(154, 50);
            this.aioSendBtn.TabIndex = 3;
            this.aioSendBtn.Text = "SEND FOR AIO";
            this.aioSendBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // messageScreenListBox
            // 
            this.messageScreenListBox.BackColor = System.Drawing.Color.Black;
            this.messageScreenListBox.ForeColor = System.Drawing.Color.White;
            this.messageScreenListBox.FormattingEnabled = true;
            this.messageScreenListBox.Location = new System.Drawing.Point(154, 132);
            this.messageScreenListBox.Name = "messageScreenListBox";
            this.messageScreenListBox.Size = new System.Drawing.Size(533, 290);
            this.messageScreenListBox.TabIndex = 4;
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.messageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextBox.ForeColor = System.Drawing.Color.Gray;
            this.messageTextBox.Location = new System.Drawing.Point(154, 440);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(373, 46);
            this.messageTextBox.TabIndex = 5;
            this.messageTextBox.Text = "Message";
            this.messageTextBox.MouseEnter += new System.EventHandler(this.messageTextBox_MouseEnter);
            this.messageTextBox.MouseLeave += new System.EventHandler(this.messageTextBox_MouseLeave);
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.Transparent;
            this.sendBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Image = global::AIO_Staff.Properties.Resources.btn21;
            this.sendBtn.Location = new System.Drawing.Point(533, 440);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(154, 50);
            this.sendBtn.TabIndex = 6;
            this.sendBtn.Text = "SEND";
            this.sendBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StaffChatPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AIO_Staff.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(706, 509);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.messageScreenListBox);
            this.Controls.Add(this.aioSendBtn);
            this.Controls.Add(this.aioMessageTextBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffChatPage";
            this.Text = "StaffChatPage";
            this.Load += new System.EventHandler(this.StaffChatPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.TextBox aioMessageTextBox;
        private System.Windows.Forms.Label aioSendBtn;
        private System.Windows.Forms.ListBox messageScreenListBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label sendBtn;
    }
}