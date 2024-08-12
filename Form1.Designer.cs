namespace WinFormsApp1
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
            label1 = new Label();
            TextBoxName = new TextBox();
            label2 = new Label();
            TextBoxEmail = new TextBox();
            label3 = new Label();
            TextBoxMessage = new TextBox();
            Send = new Button();
            Clean = new Button();
            Estado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.YellowGreen;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(32, 18);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // TextBoxName
            // 
            TextBoxName.BackColor = Color.GreenYellow;
            TextBoxName.Location = new Point(28, 48);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(208, 23);
            TextBoxName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.YellowGreen;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(32, 89);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.BackColor = Color.GreenYellow;
            TextBoxEmail.Location = new Point(32, 123);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(208, 23);
            TextBoxEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.YellowGreen;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(32, 161);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 4;
            label3.Text = "Message";
            // 
            // TextBoxMessage
            // 
            TextBoxMessage.BackColor = Color.GreenYellow;
            TextBoxMessage.Location = new Point(32, 193);
            TextBoxMessage.Name = "TextBoxMessage";
            TextBoxMessage.Size = new Size(208, 23);
            TextBoxMessage.TabIndex = 5;
            TextBoxMessage.TextChanged += textBox3_TextChanged;
            // 
            // Send
            // 
            Send.BackColor = Color.GreenYellow;
            Send.ForeColor = SystemColors.ControlText;
            Send.Location = new Point(30, 256);
            Send.Name = "Send";
            Send.Size = new Size(136, 62);
            Send.TabIndex = 6;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = false;
            Send.Click += Send_Click;
            // 
            // Clean
            // 
            Clean.BackColor = Color.GreenYellow;
            Clean.Location = new Point(186, 256);
            Clean.Name = "Clean";
            Clean.Size = new Size(136, 62);
            Clean.TabIndex = 7;
            Clean.Text = "Clean";
            Clean.UseVisualStyleBackColor = false;
            Clean.Click += Clean_Click;
            // 
            // Estado
            // 
            Estado.AutoSize = true;
            Estado.BackColor = Color.PaleGreen;
            Estado.Font = new Font("Segoe UI", 12F);
            Estado.Location = new Point(510, 125);
            Estado.Name = "Estado";
            Estado.Size = new Size(59, 21);
            Estado.TabIndex = 8;
            Estado.Text = "Estado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(Estado);
            Controls.Add(Clean);
            Controls.Add(Send);
            Controls.Add(TextBoxMessage);
            Controls.Add(label3);
            Controls.Add(TextBoxEmail);
            Controls.Add(label2);
            Controls.Add(TextBoxName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBoxName;
        private Label label2;
        private TextBox TextBoxEmail;
        private Label label3;
        private TextBox TextBoxMessage;
        private Button Send;
        private Button Clean;
        private Label Estado;
    }
}
