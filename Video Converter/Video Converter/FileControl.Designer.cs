namespace Video_Converter
{
    partial class FileControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pb_fileIcon = new PictureBox();
            label_fileName = new Label();
            pb_deleteIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_fileIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_deleteIcon).BeginInit();
            SuspendLayout();
            // 
            // pb_fileIcon
            // 
            pb_fileIcon.BackgroundImage = Properties.Resources.video;
            pb_fileIcon.BackgroundImageLayout = ImageLayout.Zoom;
            pb_fileIcon.Location = new Point(26, 2);
            pb_fileIcon.Margin = new Padding(0);
            pb_fileIcon.Name = "pb_fileIcon";
            pb_fileIcon.Size = new Size(31, 21);
            pb_fileIcon.TabIndex = 6;
            pb_fileIcon.TabStop = false;
            // 
            // label_fileName
            // 
            label_fileName.AutoSize = true;
            label_fileName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_fileName.Location = new Point(57, 2);
            label_fileName.Margin = new Padding(0);
            label_fileName.MaximumSize = new Size(300, 0);
            label_fileName.Name = "label_fileName";
            label_fileName.Size = new Size(99, 21);
            label_fileName.TabIndex = 7;
            label_fileName.Text = "<file_name>";
            // 
            // pb_deleteIcon
            // 
            pb_deleteIcon.BackgroundImage = Properties.Resources.bin;
            pb_deleteIcon.BackgroundImageLayout = ImageLayout.Zoom;
            pb_deleteIcon.Cursor = Cursors.Hand;
            pb_deleteIcon.Location = new Point(2, 2);
            pb_deleteIcon.Margin = new Padding(0);
            pb_deleteIcon.Name = "pb_deleteIcon";
            pb_deleteIcon.Size = new Size(14, 21);
            pb_deleteIcon.TabIndex = 8;
            pb_deleteIcon.TabStop = false;
            pb_deleteIcon.Click += pb_deleteIcon_Click;
            // 
            // FileControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pb_deleteIcon);
            Controls.Add(label_fileName);
            Controls.Add(pb_fileIcon);
            Name = "FileControl";
            Size = new Size(360, 25);
            ((System.ComponentModel.ISupportInitialize)pb_fileIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_deleteIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_fileIcon;
        private Label label_fileName;
        private PictureBox pb_deleteIcon;
    }
}
