namespace NT106_Lab4
{
    partial class Bai4
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
            urlTxb = new TextBox();
            label1 = new Label();
            loadBtn = new Button();
            downloadBtn = new Button();
            sourceBtn = new Button();
            sourceRtb = new RichTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // urlTxb
            // 
            urlTxb.BorderStyle = BorderStyle.FixedSingle;
            urlTxb.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            urlTxb.Location = new Point(81, 18);
            urlTxb.Name = "urlTxb";
            urlTxb.Size = new Size(564, 31);
            urlTxb.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 1;
            label1.Text = "URL";
            // 
            // loadBtn
            // 
            loadBtn.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadBtn.Location = new Point(667, 18);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(109, 34);
            loadBtn.TabIndex = 2;
            loadBtn.Text = "Load";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // downloadBtn
            // 
            downloadBtn.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            downloadBtn.Location = new Point(675, 480);
            downloadBtn.Name = "downloadBtn";
            downloadBtn.Size = new Size(109, 34);
            downloadBtn.TabIndex = 3;
            downloadBtn.Text = "Download";
            downloadBtn.UseVisualStyleBackColor = true;
            downloadBtn.Click += downloadBtn_Click;
            // 
            // sourceBtn
            // 
            sourceBtn.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sourceBtn.Location = new Point(675, 427);
            sourceBtn.Name = "sourceBtn";
            sourceBtn.Size = new Size(113, 33);
            sourceBtn.TabIndex = 4;
            sourceBtn.Text = "Source";
            sourceBtn.UseVisualStyleBackColor = true;
            sourceBtn.Click += sourceBtn_Click;
            // 
            // sourceRtb
            // 
            sourceRtb.BorderStyle = BorderStyle.FixedSingle;
            sourceRtb.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sourceRtb.Location = new Point(29, 103);
            sourceRtb.Name = "sourceRtb";
            sourceRtb.Size = new Size(616, 357);
            sourceRtb.TabIndex = 5;
            sourceRtb.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 77);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 6;
            label2.Text = "Source";
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 526);
            Controls.Add(label2);
            Controls.Add(sourceRtb);
            Controls.Add(sourceBtn);
            Controls.Add(downloadBtn);
            Controls.Add(loadBtn);
            Controls.Add(label1);
            Controls.Add(urlTxb);
            Name = "Bai4";
            Text = "Bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox urlTxb;
        private Label label1;
        private Button loadBtn;
        private Button downloadBtn;
        private Button sourceBtn;
        private RichTextBox sourceRtb;
        private Label label2;
    }
}