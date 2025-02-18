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
            SuspendLayout();
            // 
            // tbConsoleOutput
            // 
            tbConsoleOutput.Location = new Point(15, 15);
            tbConsoleOutput.Margin = new Padding(4, 4, 4, 4);
            tbConsoleOutput.Multiline = true;
            tbConsoleOutput.Name = "tbConsoleOutput";
            tbConsoleOutput.Size = new Size(896, 460);
            tbConsoleOutput.TabIndex = 0;
            // 
            // tbPortNumber
            // 
            tbPortNumber.Location = new Point(314, 506);
            tbPortNumber.Margin = new Padding(4, 4, 4, 4);
            tbPortNumber.Name = "tbPortNumber";
            tbPortNumber.Size = new Size(117, 31);
            tbPortNumber.TabIndex = 1;
            tbPortNumber.Text = "23000";
            // 
            // tbIPAddress
            // 
            tbIPAddress.Location = new Point(110, 506);
            tbIPAddress.Margin = new Padding(4, 4, 4, 4);
            tbIPAddress.Name = "tbIPAddress";
            tbIPAddress.Size = new Size(196, 31);
            tbIPAddress.TabIndex = 2;
            tbIPAddress.Text = "192.168.1.6";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 512);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 3;
            label1.Text = "IP/Port";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(722, 500);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(166, 43);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start Listening";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 603);
            Controls.Add(btnStart);
            Controls.Add(label1);
            Controls.Add(tbIPAddress);
            Controls.Add(tbPortNumber);
            Controls.Add(tbConsoleOutput);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
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
    }
}
