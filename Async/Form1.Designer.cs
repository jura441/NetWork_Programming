namespace Async
{
    partial class Клиент
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtn_connectserver = new System.Windows.Forms.Button();
            this.btn_sendMessage = new System.Windows.Forms.Button();
            this.btn_SwitchContact = new System.Windows.Forms.Button();
            this.btn_disconnectServer = new System.Windows.Forms.Button();
            this.rtb_Chat = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tmr_refreshConnection = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // dtn_connectserver
            // 
            this.dtn_connectserver.Location = new System.Drawing.Point(12, 12);
            this.dtn_connectserver.Name = "dtn_connectserver";
            this.dtn_connectserver.Size = new System.Drawing.Size(161, 23);
            this.dtn_connectserver.TabIndex = 0;
            this.dtn_connectserver.Text = "Подключится к серверу";
            this.dtn_connectserver.UseVisualStyleBackColor = true;
            this.dtn_connectserver.Click += new System.EventHandler(this.btn_connectServer);
            // 
            // btn_sendMessage
            // 
            this.btn_sendMessage.Location = new System.Drawing.Point(434, 12);
            this.btn_sendMessage.Name = "btn_sendMessage";
            this.btn_sendMessage.Size = new System.Drawing.Size(147, 23);
            this.btn_sendMessage.TabIndex = 1;
            this.btn_sendMessage.Text = "отправить сообщение";
            this.btn_sendMessage.UseVisualStyleBackColor = true;
            this.btn_sendMessage.Click += new System.EventHandler(this.btn_sendMessage_Click);
            // 
            // btn_SwitchContact
            // 
            this.btn_SwitchContact.Location = new System.Drawing.Point(247, 12);
            this.btn_SwitchContact.Name = "btn_SwitchContact";
            this.btn_SwitchContact.Size = new System.Drawing.Size(170, 23);
            this.btn_SwitchContact.TabIndex = 2;
            this.btn_SwitchContact.Text = "Выбрать собеседника";
            this.btn_SwitchContact.UseVisualStyleBackColor = true;
            this.btn_SwitchContact.Click += new System.EventHandler(this.btn_SwitchContact_Click);
            // 
            // btn_disconnectServer
            // 
            this.btn_disconnectServer.Location = new System.Drawing.Point(631, 12);
            this.btn_disconnectServer.Name = "btn_disconnectServer";
            this.btn_disconnectServer.Size = new System.Drawing.Size(157, 23);
            this.btn_disconnectServer.TabIndex = 3;
            this.btn_disconnectServer.Text = "Отключится от сервера";
            this.btn_disconnectServer.UseVisualStyleBackColor = true;
            this.btn_disconnectServer.Click += new System.EventHandler(this.btn_disconnectServer_Click);
            // 
            // rtb_Chat
            // 
            this.rtb_Chat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtb_Chat.Location = new System.Drawing.Point(0, 98);
            this.rtb_Chat.Name = "rtb_Chat";
            this.rtb_Chat.Size = new System.Drawing.Size(800, 352);
            this.rtb_Chat.TabIndex = 4;
            this.rtb_Chat.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 23);
            this.textBox1.TabIndex = 5;
            // 
            // Клиент
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rtb_Chat);
            this.Controls.Add(this.btn_disconnectServer);
            this.Controls.Add(this.btn_SwitchContact);
            this.Controls.Add(this.btn_sendMessage);
            this.Controls.Add(this.dtn_connectserver);
            this.Name = "Клиент";
            this.Text = "Клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button dtn_connectserver;
        private Button btn_sendMessage;
        private Button btn_SwitchContact;
        private Button btn_disconnectServer;
        private RichTextBox rtb_Chat;
        private TextBox textBox1;
        private System.Windows.Forms.Timer tmr_refreshConnection;
    }
}