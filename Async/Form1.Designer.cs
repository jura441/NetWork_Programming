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
            components = new System.ComponentModel.Container();
            dtn_connectserver = new Button();
            btn_sendMessage = new Button();
            btn_SwitchContact = new Button();
            btn_disconnectServer = new Button();
            rtb_Chat = new RichTextBox();
            textBox1 = new TextBox();
            tmr_refreshConnection = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // dtn_connectserver
            // 
            dtn_connectserver.Location = new Point(43, 12);
            dtn_connectserver.Name = "dtn_connectserver";
            dtn_connectserver.Size = new Size(161, 23);
            dtn_connectserver.TabIndex = 0;
            dtn_connectserver.Text = "Подключится к серверу";
            dtn_connectserver.UseVisualStyleBackColor = true;
            dtn_connectserver.Click += btn_connectServer;
            // 
            // btn_sendMessage
            // 
            btn_sendMessage.Location = new Point(434, 12);
            btn_sendMessage.Name = "btn_sendMessage";
            btn_sendMessage.Size = new Size(147, 23);
            btn_sendMessage.TabIndex = 1;
            btn_sendMessage.Text = "отправить сообщение";
            btn_sendMessage.UseVisualStyleBackColor = true;
            btn_sendMessage.Click += btn_sendMessage_Click;
            // 
            // btn_SwitchContact
            // 
            btn_SwitchContact.Location = new Point(247, 12);
            btn_SwitchContact.Name = "btn_SwitchContact";
            btn_SwitchContact.Size = new Size(170, 23);
            btn_SwitchContact.TabIndex = 2;
            btn_SwitchContact.Text = "Выбрать собеседника";
            btn_SwitchContact.UseVisualStyleBackColor = true;
            btn_SwitchContact.Click += btn_SwitchContact_Click;
            // 
            // btn_disconnectServer
            // 
            btn_disconnectServer.Location = new Point(631, 12);
            btn_disconnectServer.Name = "btn_disconnectServer";
            btn_disconnectServer.Size = new Size(157, 23);
            btn_disconnectServer.TabIndex = 3;
            btn_disconnectServer.Text = "Отключится от сервера";
            btn_disconnectServer.UseVisualStyleBackColor = true;
            btn_disconnectServer.Click += btn_disconnectServer_Click;
            // 
            // rtb_Chat
            // 
            rtb_Chat.Dock = DockStyle.Bottom;
            rtb_Chat.Location = new Point(0, 98);
            rtb_Chat.Name = "rtb_Chat";
            rtb_Chat.Size = new Size(800, 352);
            rtb_Chat.TabIndex = 4;
            rtb_Chat.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 23);
            textBox1.TabIndex = 5;
            // 
            // Клиент
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(rtb_Chat);
            Controls.Add(btn_disconnectServer);
            Controls.Add(btn_SwitchContact);
            Controls.Add(btn_sendMessage);
            Controls.Add(dtn_connectserver);
            Name = "Клиент";
            Text = "Клиент";
            ResumeLayout(false);
            PerformLayout();
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