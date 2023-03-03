namespace Server_Forms
{
    partial class Form1
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
            this.btn_startserver = new System.Windows.Forms.Button();
            this.btn_stopserver = new System.Windows.Forms.Button();
            this.rtb_clients = new System.Windows.Forms.RichTextBox();
            this.tmr_refreshConnection = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_startserver
            // 
            this.btn_startserver.Location = new System.Drawing.Point(216, 12);
            this.btn_startserver.Name = "btn_startserver";
            this.btn_startserver.Size = new System.Drawing.Size(149, 23);
            this.btn_startserver.TabIndex = 0;
            this.btn_startserver.Text = "Запустить сервер";
            this.btn_startserver.UseVisualStyleBackColor = true;
            this.btn_startserver.Click += new System.EventHandler(this.btn_startserver_Click);
            // 
            // btn_stopserver
            // 
            this.btn_stopserver.Location = new System.Drawing.Point(450, 12);
            this.btn_stopserver.Name = "btn_stopserver";
            this.btn_stopserver.Size = new System.Drawing.Size(151, 23);
            this.btn_stopserver.TabIndex = 1;
            this.btn_stopserver.Text = "Остановить сервер";
            this.btn_stopserver.UseVisualStyleBackColor = true;
            this.btn_stopserver.Click += new System.EventHandler(this.btn_stopserver_Click);
            // 
            // rtb_clients
            // 
            this.rtb_clients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtb_clients.Location = new System.Drawing.Point(0, 63);
            this.rtb_clients.Name = "rtb_clients";
            this.rtb_clients.Size = new System.Drawing.Size(800, 387);
            this.rtb_clients.TabIndex = 2;
            this.rtb_clients.Text = "";
            // 
            // tmr_refreshConnection
            // 
            this.tmr_refreshConnection.Tick += new System.EventHandler(this.tmr_refreshConnection_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_clients);
            this.Controls.Add(this.btn_stopserver);
            this.Controls.Add(this.btn_startserver);
            this.Name = "Form1";
            this.Text = "Сервер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_startserver;
        private Button btn_stopserver;
        private RichTextBox rtb_clients;
        private System.Windows.Forms.Timer tmr_refreshConnection;
    }
}