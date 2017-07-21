namespace ChatTry
{
    partial class ClientChatForm
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
            this.gbSignIn = new System.Windows.Forms.GroupBox();
            this.chbRegister = new System.Windows.Forms.CheckBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.gbServerConnect = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect2 = new System.Windows.Forms.Button();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.gbChat = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbChat = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbSignIn.SuspendLayout();
            this.gbServerConnect.SuspendLayout();
            this.gbChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSignIn
            // 
            this.gbSignIn.Controls.Add(this.chbRegister);
            this.gbSignIn.Controls.Add(this.btnSignIn);
            this.gbSignIn.Controls.Add(this.tbPassword);
            this.gbSignIn.Controls.Add(this.tbLogin);
            this.gbSignIn.Controls.Add(this.lblPassword);
            this.gbSignIn.Controls.Add(this.lblLogin);
            this.gbSignIn.Location = new System.Drawing.Point(12, 187);
            this.gbSignIn.Name = "gbSignIn";
            this.gbSignIn.Size = new System.Drawing.Size(163, 198);
            this.gbSignIn.TabIndex = 28;
            this.gbSignIn.TabStop = false;
            this.gbSignIn.Text = "2. Sign In or Register";
            // 
            // chbRegister
            // 
            this.chbRegister.AutoSize = true;
            this.chbRegister.Location = new System.Drawing.Point(9, 117);
            this.chbRegister.Name = "chbRegister";
            this.chbRegister.Size = new System.Drawing.Size(65, 17);
            this.chbRegister.TabIndex = 25;
            this.chbRegister.Text = "Register";
            this.chbRegister.UseVisualStyleBackColor = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(8, 140);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(140, 40);
            this.btnSignIn.TabIndex = 23;
            this.btnSignIn.Text = "Submit";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(8, 91);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(140, 20);
            this.tbPassword.TabIndex = 22;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(8, 43);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(140, 20);
            this.tbLogin.TabIndex = 21;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(5, 75);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(107, 13);
            this.lblPassword.TabIndex = 20;
            this.lblPassword.Text = "Enter your Password:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(5, 27);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(87, 13);
            this.lblLogin.TabIndex = 19;
            this.lblLogin.Text = "Enter your Login:";
            // 
            // gbServerConnect
            // 
            this.gbServerConnect.Controls.Add(this.label3);
            this.gbServerConnect.Controls.Add(this.btnConnect2);
            this.gbServerConnect.Controls.Add(this.tbIP);
            this.gbServerConnect.Location = new System.Drawing.Point(12, 48);
            this.gbServerConnect.Name = "gbServerConnect";
            this.gbServerConnect.Size = new System.Drawing.Size(163, 121);
            this.gbServerConnect.TabIndex = 29;
            this.gbServerConnect.TabStop = false;
            this.gbServerConnect.Text = "1. Connect to Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Enter IP Address of Server:";
            // 
            // btnConnect2
            // 
            this.btnConnect2.Location = new System.Drawing.Point(9, 68);
            this.btnConnect2.Name = "btnConnect2";
            this.btnConnect2.Size = new System.Drawing.Size(140, 40);
            this.btnConnect2.TabIndex = 29;
            this.btnConnect2.Text = "Connect";
            this.btnConnect2.UseVisualStyleBackColor = true;
            this.btnConnect2.Click += new System.EventHandler(this.btnConnect2_Click);
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(9, 42);
            this.tbIP.Multiline = true;
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(140, 20);
            this.tbIP.TabIndex = 28;
            this.tbIP.Text = "127.0.0.1";
            // 
            // gbChat
            // 
            this.gbChat.Controls.Add(this.label2);
            this.gbChat.Controls.Add(this.label1);
            this.gbChat.Controls.Add(this.tbChat);
            this.gbChat.Controls.Add(this.tbMessage);
            this.gbChat.Controls.Add(this.btnSend);
            this.gbChat.Location = new System.Drawing.Point(190, 12);
            this.gbChat.Name = "gbChat";
            this.gbChat.Size = new System.Drawing.Size(602, 373);
            this.gbChat.TabIndex = 30;
            this.gbChat.TabStop = false;
            this.gbChat.Text = "3. Communicate with all chat visitors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Enter your message:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(219, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "All Chat Message";
            // 
            // tbChat
            // 
            this.tbChat.Location = new System.Drawing.Point(17, 36);
            this.tbChat.Multiline = true;
            this.tbChat.Name = "tbChat";
            this.tbChat.Size = new System.Drawing.Size(571, 250);
            this.tbChat.TabIndex = 26;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(17, 315);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(425, 40);
            this.tbMessage.TabIndex = 25;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(448, 315);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(140, 40);
            this.btnSend.TabIndex = 24;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ClientChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 399);
            this.Controls.Add(this.gbChat);
            this.Controls.Add(this.gbServerConnect);
            this.Controls.Add(this.gbSignIn);
            this.Name = "ClientChatForm";
            this.Text = "ClientChat";
            this.gbSignIn.ResumeLayout(false);
            this.gbSignIn.PerformLayout();
            this.gbServerConnect.ResumeLayout(false);
            this.gbServerConnect.PerformLayout();
            this.gbChat.ResumeLayout(false);
            this.gbChat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSignIn;
        private System.Windows.Forms.CheckBox chbRegister;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.GroupBox gbServerConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect2;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.GroupBox gbChat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbChat;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btnSend;
    }
}