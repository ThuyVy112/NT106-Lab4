namespace NT106_Lab4
{
    partial class Bai1
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
            urlTextbox = new TextBox();
            dowloadBtn = new Button();
            htmlTextbox = new TextBox();
            headerListview = new ListView();
            SuspendLayout();
            // 
            // urlTextbox
            // 
            urlTextbox.BorderStyle = BorderStyle.FixedSingle;
            urlTextbox.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            urlTextbox.Location = new Point(27, 21);
            urlTextbox.Name = "urlTextbox";
            urlTextbox.Size = new Size(562, 31);
            urlTextbox.TabIndex = 0;
            // 
            // dowloadBtn
            // 
            dowloadBtn.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dowloadBtn.Location = new Point(623, 21);
            dowloadBtn.Name = "dowloadBtn";
            dowloadBtn.Size = new Size(114, 36);
            dowloadBtn.TabIndex = 1;
            dowloadBtn.Text = "Download";
            dowloadBtn.UseVisualStyleBackColor = true;
            dowloadBtn.Click += dowloadBtn_Click;
            // 
            // htmlTextbox
            // 
            htmlTextbox.BorderStyle = BorderStyle.FixedSingle;
            htmlTextbox.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            htmlTextbox.Location = new Point(28, 79);
            htmlTextbox.Multiline = true;
            htmlTextbox.Name = "htmlTextbox";
            htmlTextbox.ScrollBars = ScrollBars.Vertical;
            htmlTextbox.Size = new Size(561, 476);
            htmlTextbox.TabIndex = 2;
            // 
            // headerListview
            // 
            headerListview.BorderStyle = BorderStyle.FixedSingle;
            headerListview.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerListview.Location = new Point(623, 80);
            headerListview.Name = "headerListview";
            headerListview.Size = new Size(376, 475);
            headerListview.TabIndex = 3;
            headerListview.UseCompatibleStateImageBehavior = false;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 581);
            Controls.Add(headerListview);
            Controls.Add(htmlTextbox);
            Controls.Add(dowloadBtn);
            Controls.Add(urlTextbox);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox urlTextbox;
        private Button dowloadBtn;
        private TextBox htmlTextbox;
        private ListView headerListview;
    }
}