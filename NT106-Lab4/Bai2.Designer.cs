namespace NT106_Lab4
{
    partial class Bai2
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
            label1 = new Label();
            urlTextBox = new TextBox();
            loadBtn = new Button();
            userAgentComboBox = new ComboBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "URL";
            // 
            // urlTextBox
            // 
            urlTextBox.Location = new Point(106, 24);
            urlTextBox.Margin = new Padding(4, 3, 4, 3);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.Size = new Size(433, 23);
            urlTextBox.TabIndex = 1;
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(547, 24);
            loadBtn.Margin = new Padding(4, 3, 4, 3);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(145, 66);
            loadBtn.TabIndex = 2;
            loadBtn.Text = "Load";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // userAgentComboBox
            // 
            userAgentComboBox.FormattingEnabled = true;
            userAgentComboBox.Location = new Point(107, 66);
            userAgentComboBox.Margin = new Padding(4, 3, 4, 3);
            userAgentComboBox.Name = "userAgentComboBox";
            userAgentComboBox.Size = new Size(432, 23);
            userAgentComboBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 69);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "User-Agent";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(34, 97);
            richTextBox1.Margin = new Padding(4, 3, 4, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(657, 468);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 579);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(userAgentComboBox);
            Controls.Add(loadBtn);
            Controls.Add(urlTextBox);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Bai2";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.ComboBox userAgentComboBox;
        private System.Windows.Forms.Label label2;
        private RichTextBox richTextBox1;
    }
}

