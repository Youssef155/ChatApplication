namespace TCPServer
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
            tbConsoleOutput = new TextBox();
            tbPortNumber = new TextBox();
            tbIPAddress = new TextBox();
            label1 = new Label();
            btnStart = new Button();
            label2 = new Label();
            tbMsg = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // tbConsoleOutput
            // 
            tbConsoleOutput.Location = new Point(15, 15);
            tbConsoleOutput.Margin = new Padding(4);
            tbConsoleOutput.Multiline = true;
            tbConsoleOutput.Name = "tbConsoleOutput";
            tbConsoleOutput.Size = new Size(463, 460);
            tbConsoleOutput.TabIndex = 0;
            // 
            // tbPortNumber
            // 
            tbPortNumber.Location = new Point(361, 528);
            tbPortNumber.Margin = new Padding(4);
            tbPortNumber.Name = "tbPortNumber";
            tbPortNumber.Size = new Size(117, 31);
            tbPortNumber.TabIndex = 1;
            tbPortNumber.Text = "23000";
            // 
            // tbIPAddress
            // 
            tbIPAddress.Location = new Point(121, 528);
            tbIPAddress.Margin = new Padding(4);
            tbIPAddress.Name = "tbIPAddress";
            tbIPAddress.Size = new Size(215, 31);
            tbIPAddress.TabIndex = 2;
            tbIPAddress.Text = "192.168.1.6";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 534);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 3;
            label1.Text = "IP/Port";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.LimeGreen;
            btnStart.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(729, 520);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(182, 53);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start Listening";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(486, 295);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 6;
            label2.Text = "Message";
            // 
            // tbMsg
            // 
            tbMsg.Location = new Point(486, 324);
            tbMsg.Margin = new Padding(4);
            tbMsg.Multiline = true;
            tbMsg.Name = "tbMsg";
            tbMsg.Size = new Size(425, 107);
            tbMsg.TabIndex = 5;
            tbMsg.Text = "\r\n";
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.SteelBlue;
            btnSend.ForeColor = SystemColors.Control;
            btnSend.Location = new Point(486, 438);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(426, 39);
            btnSend.TabIndex = 7;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 603);
            Controls.Add(btnSend);
            Controls.Add(label2);
            Controls.Add(tbMsg);
            Controls.Add(btnStart);
            Controls.Add(label1);
            Controls.Add(tbIPAddress);
            Controls.Add(tbPortNumber);
            Controls.Add(tbConsoleOutput);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbConsoleOutput;
        private TextBox tbPortNumber;
        private TextBox tbIPAddress;
        private Label label1;
        private Button btnStart;
        private Label label2;
        private TextBox tbMsg;
        private Button btnSend;
    }
}
