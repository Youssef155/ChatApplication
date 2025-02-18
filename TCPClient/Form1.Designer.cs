namespace TCPClient
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
            btnSend = new Button();
            label2 = new Label();
            tbMsg = new TextBox();
            btnConnect = new Button();
            label1 = new Label();
            tbServerIP = new TextBox();
            tbServerPortNo = new TextBox();
            tbConsoleOutput = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.SteelBlue;
            btnSend.ForeColor = SystemColors.Control;
            btnSend.Location = new Point(573, 174);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(305, 39);
            btnSend.TabIndex = 15;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(573, 16);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 14;
            label2.Text = "Send a Message";
            // 
            // tbMsg
            // 
            tbMsg.Location = new Point(574, 60);
            tbMsg.Margin = new Padding(4);
            tbMsg.Multiline = true;
            tbMsg.Name = "tbMsg";
            tbMsg.Size = new Size(304, 107);
            tbMsg.TabIndex = 13;
            tbMsg.Text = "\r\n";
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.LimeGreen;
            btnConnect.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(305, 487);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(183, 74);
            btnConnect.TabIndex = 12;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 487);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 11;
            label1.Text = "Server IP";
            // 
            // tbServerIP
            // 
            tbServerIP.Location = new Point(108, 487);
            tbServerIP.Margin = new Padding(4);
            tbServerIP.Name = "tbServerIP";
            tbServerIP.Size = new Size(153, 31);
            tbServerIP.TabIndex = 10;
            // 
            // tbServerPortNo
            // 
            tbServerPortNo.Location = new Point(143, 530);
            tbServerPortNo.Margin = new Padding(4);
            tbServerPortNo.Name = "tbServerPortNo";
            tbServerPortNo.Size = new Size(118, 31);
            tbServerPortNo.TabIndex = 9;
            // 
            // tbConsoleOutput
            // 
            tbConsoleOutput.Location = new Point(13, 60);
            tbConsoleOutput.Margin = new Padding(4);
            tbConsoleOutput.Multiline = true;
            tbConsoleOutput.Name = "tbConsoleOutput";
            tbConsoleOutput.Size = new Size(519, 413);
            tbConsoleOutput.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 533);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 16;
            label3.Text = "Server Port";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 16);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 17;
            label4.Text = "Message Box";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 579);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSend);
            Controls.Add(label2);
            Controls.Add(tbMsg);
            Controls.Add(btnConnect);
            Controls.Add(label1);
            Controls.Add(tbServerIP);
            Controls.Add(tbServerPortNo);
            Controls.Add(tbConsoleOutput);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private Label label2;
        private TextBox tbMsg;
        private Button btnConnect;
        private Label label1;
        private TextBox tbServerIP;
        private TextBox tbServerPortNo;
        private TextBox tbConsoleOutput;
        private Label label3;
        private Label label4;
    }
}
