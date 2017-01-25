namespace Twitchbot
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
            this.btnChat = new System.Windows.Forms.Button();
            this.richChat = new System.Windows.Forms.RichTextBox();
            this.txtChatBox = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtChatroom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richUserList = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OAuth_Key = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(12, 420);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(268, 41);
            this.btnChat.TabIndex = 0;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.button1_Click);
            // 
            // richChat
            // 
            this.richChat.Location = new System.Drawing.Point(12, 12);
            this.richChat.Name = "richChat";
            this.richChat.Size = new System.Drawing.Size(268, 375);
            this.richChat.TabIndex = 1;
            this.richChat.Text = "";
            // 
            // txtChatBox
            // 
            this.txtChatBox.Location = new System.Drawing.Point(13, 394);
            this.txtChatBox.Name = "txtChatBox";
            this.txtChatBox.Size = new System.Drawing.Size(267, 20);
            this.txtChatBox.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 467);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(135, 38);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(153, 467);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(127, 38);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtChatroom
            // 
            this.txtChatroom.Location = new System.Drawing.Point(12, 524);
            this.txtChatroom.Name = "txtChatroom";
            this.txtChatroom.Size = new System.Drawing.Size(134, 20);
            this.txtChatroom.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chat Room:";
            // 
            // richUserList
            // 
            this.richUserList.Enabled = false;
            this.richUserList.Location = new System.Drawing.Point(286, 12);
            this.richUserList.Name = "richUserList";
            this.richUserList.Size = new System.Drawing.Size(219, 375);
            this.richUserList.TabIndex = 7;
            this.richUserList.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(565, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Uptime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(615, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "CounterUpTime";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(523, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Logged in as: ";
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(445, 515);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(25, 13);
            this.Info.TabIndex = 12;
            this.Info.Text = "Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(618, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "User";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(537, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "OAuth Key: ";
            // 
            // OAuth_Key
            // 
            this.OAuth_Key.Location = new System.Drawing.Point(618, 57);
            this.OAuth_Key.Name = "OAuth_Key";
            this.OAuth_Key.PasswordChar = '*';
            this.OAuth_Key.Size = new System.Drawing.Size(100, 20);
            this.OAuth_Key.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(935, 556);
            this.Controls.Add(this.OAuth_Key);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richUserList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChatroom);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtChatBox);
            this.Controls.Add(this.richChat);
            this.Controls.Add(this.btnChat);
            this.Name = "Form1";
            this.Text = "Bot Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.RichTextBox richChat;
        private System.Windows.Forms.TextBox txtChatBox;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txtChatroom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richUserList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OAuth_Key;
    }
}

