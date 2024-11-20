namespace NT106_Lab4
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
            b1Btn = new Button();
            b2Btn = new Button();
            b3Btn = new Button();
            b4Btn = new Button();
            SuspendLayout();
            // 
            // b1Btn
            // 
            b1Btn.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b1Btn.Location = new Point(61, 49);
            b1Btn.Margin = new Padding(3, 2, 3, 2);
            b1Btn.Name = "b1Btn";
            b1Btn.Size = new Size(117, 32);
            b1Btn.TabIndex = 0;
            b1Btn.Text = "Bài 1";
            b1Btn.UseVisualStyleBackColor = true;
            b1Btn.Click += b1Btn_Click;
            // 
            // b2Btn
            // 
            b2Btn.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b2Btn.Location = new Point(256, 49);
            b2Btn.Margin = new Padding(3, 2, 3, 2);
            b2Btn.Name = "b2Btn";
            b2Btn.Size = new Size(117, 32);
            b2Btn.TabIndex = 1;
            b2Btn.Text = "Bài 2";
            b2Btn.UseVisualStyleBackColor = true;
            b2Btn.Click += b2Btn_Click;
            // 
            // b3Btn
            // 
            b3Btn.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b3Btn.Location = new Point(61, 122);
            b3Btn.Margin = new Padding(3, 2, 3, 2);
            b3Btn.Name = "b3Btn";
            b3Btn.Size = new Size(117, 32);
            b3Btn.TabIndex = 2;
            b3Btn.Text = "Bài 3";
            b3Btn.UseVisualStyleBackColor = true;
            // 
            // b4Btn
            // 
            b4Btn.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b4Btn.Location = new Point(256, 122);
            b4Btn.Margin = new Padding(3, 2, 3, 2);
            b4Btn.Name = "b4Btn";
            b4Btn.Size = new Size(117, 32);
            b4Btn.TabIndex = 3;
            b4Btn.Text = "Bài 4";
            b4Btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 198);
            Controls.Add(b4Btn);
            Controls.Add(b3Btn);
            Controls.Add(b2Btn);
            Controls.Add(b1Btn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Lab04";
            ResumeLayout(false);
        }

        #endregion

        private Button b1Btn;
        private Button b2Btn;
        private Button b3Btn;
        private Button b4Btn;
    }
}
