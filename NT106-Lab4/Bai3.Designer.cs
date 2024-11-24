namespace NT106_Lab4
{
    partial class Bai3
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
            fetchPhotos = new Button();
            listView = new ListView();
            fetchComments = new Button();
            fetchUsers = new Button();
            SuspendLayout();
            // 
            // fetchPhotos
            // 
            fetchPhotos.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fetchPhotos.Location = new Point(29, 11);
            fetchPhotos.Margin = new Padding(3, 2, 3, 2);
            fetchPhotos.Name = "fetchPhotos";
            fetchPhotos.Size = new Size(141, 27);
            fetchPhotos.TabIndex = 2;
            fetchPhotos.Text = "Load 100 Photos";
            fetchPhotos.UseVisualStyleBackColor = true;
            fetchPhotos.Click += fetchPhotos_Click;
            // 
            // listView
            // 
            listView.BorderStyle = BorderStyle.FixedSingle;
            listView.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView.Location = new Point(12, 54);
            listView.Margin = new Padding(3, 2, 3, 2);
            listView.Name = "listView";
            listView.Size = new Size(1096, 532);
            listView.TabIndex = 4;
            listView.UseCompatibleStateImageBehavior = false;
            // 
            // fetchComments
            // 
            fetchComments.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fetchComments.Location = new Point(200, 11);
            fetchComments.Margin = new Padding(3, 2, 3, 2);
            fetchComments.Name = "fetchComments";
            fetchComments.Size = new Size(141, 27);
            fetchComments.TabIndex = 5;
            fetchComments.Text = "Load 100 Comments";
            fetchComments.UseVisualStyleBackColor = true;
            fetchComments.Click += fetchComments_Click;
            // 
            // fetchUsers
            // 
            fetchUsers.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fetchUsers.Location = new Point(374, 11);
            fetchUsers.Margin = new Padding(3, 2, 3, 2);
            fetchUsers.Name = "fetchUsers";
            fetchUsers.Size = new Size(141, 27);
            fetchUsers.TabIndex = 6;
            fetchUsers.Text = "Load 10 Users";
            fetchUsers.UseVisualStyleBackColor = true;
            fetchUsers.Click += fetchUsers_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 597);
            Controls.Add(fetchUsers);
            Controls.Add(fetchComments);
            Controls.Add(listView);
            Controls.Add(fetchPhotos);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
        }

        #endregion

        private Button fetchPhotos;
        private ListView listView;
        private Button fetchComments;
        private Button fetchUsers;
    }
}