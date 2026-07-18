namespace Lab6_KafkaChat
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
            lblTitle = new Label();
            lstMessages = new ListBox();
            txtMessage = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(304, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(161, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Kafka Chat Application";
            // 
            // lstMessages
            // 
            lstMessages.FormattingEnabled = true;
            lstMessages.Location = new Point(80, 108);
            lstMessages.Name = "lstMessages";
            lstMessages.Size = new Size(580, 104);
            lstMessages.TabIndex = 1;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(80, 247);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(305, 27);
            txtMessage.TabIndex = 2;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(391, 245);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(269, 29);
            btnSend.TabIndex = 3;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(lstMessages);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Kafka Chat Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListBox lstMessages;
        private TextBox txtMessage;
        private Button btnSend;
    }
}
