namespace Video_Converter
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
            button_selectFile = new Button();
            cb_currentFormat = new ComboBox();
            label1 = new Label();
            cb_targetFormat = new ComboBox();
            button_selectFolder = new Button();
            panel_currentFiles = new Panel();
            panel_targetFiles = new Panel();
            button_selectTarget = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button_selectFile
            // 
            button_selectFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_selectFile.Location = new Point(12, 78);
            button_selectFile.Name = "button_selectFile";
            button_selectFile.Size = new Size(200, 29);
            button_selectFile.TabIndex = 0;
            button_selectFile.Text = "Add File";
            button_selectFile.UseVisualStyleBackColor = true;
            button_selectFile.Click += button_selectFile_Click;
            // 
            // cb_currentFormat
            // 
            cb_currentFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_currentFormat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_currentFormat.FormattingEnabled = true;
            cb_currentFormat.Items.AddRange(new object[] { "Select an extension...", "3GP", "AVI", "DIVX", "FLV", "GIF", "H264", "H265", "M4V", "MKV", "MOV", "MP4", "MPG", "OGG", "RMVB", "TS", "VOB", "WEBM", "WMV" });
            cb_currentFormat.Location = new Point(12, 12);
            cb_currentFormat.Name = "cb_currentFormat";
            cb_currentFormat.Size = new Size(405, 29);
            cb_currentFormat.TabIndex = 1;
            cb_currentFormat.SelectedIndexChanged += cb_currentFormat_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(447, 15);
            label1.Name = "label1";
            label1.Size = new Size(24, 21);
            label1.TabIndex = 2;
            label1.Text = "to";
            // 
            // cb_targetFormat
            // 
            cb_targetFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_targetFormat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_targetFormat.FormattingEnabled = true;
            cb_targetFormat.Items.AddRange(new object[] { "Select an extension...", "3GP", "AVI", "DIVX", "FLV", "GIF", "H264", "H265", "M4V", "MKV", "MOV", "MP4", "MPG", "OGG", "RMVB", "TS", "VOB", "WEBM", "WMV" });
            cb_targetFormat.Location = new Point(498, 12);
            cb_targetFormat.Name = "cb_targetFormat";
            cb_targetFormat.Size = new Size(405, 29);
            cb_targetFormat.TabIndex = 3;
            cb_targetFormat.SelectedIndexChanged += cb_targetFormat_SelectedIndexChanged;
            // 
            // button_selectFolder
            // 
            button_selectFolder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_selectFolder.Location = new Point(218, 78);
            button_selectFolder.Name = "button_selectFolder";
            button_selectFolder.Size = new Size(199, 29);
            button_selectFolder.TabIndex = 5;
            button_selectFolder.Text = "Add Folder";
            button_selectFolder.UseVisualStyleBackColor = true;
            button_selectFolder.Click += button_selectFolder_Click;
            // 
            // panel_currentFiles
            // 
            panel_currentFiles.AutoScroll = true;
            panel_currentFiles.BackColor = Color.White;
            panel_currentFiles.BorderStyle = BorderStyle.FixedSingle;
            panel_currentFiles.Location = new Point(12, 113);
            panel_currentFiles.Name = "panel_currentFiles";
            panel_currentFiles.Size = new Size(405, 241);
            panel_currentFiles.TabIndex = 6;
            // 
            // panel_targetFiles
            // 
            panel_targetFiles.BackColor = Color.White;
            panel_targetFiles.BorderStyle = BorderStyle.FixedSingle;
            panel_targetFiles.Location = new Point(498, 113);
            panel_targetFiles.Name = "panel_targetFiles";
            panel_targetFiles.Size = new Size(405, 241);
            panel_targetFiles.TabIndex = 9;
            // 
            // button_selectTarget
            // 
            button_selectTarget.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_selectTarget.Location = new Point(777, 78);
            button_selectTarget.Name = "button_selectTarget";
            button_selectTarget.Size = new Size(126, 29);
            button_selectTarget.TabIndex = 8;
            button_selectTarget.Text = "Browse";
            button_selectTarget.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(420, 183);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(75, 65);
            label2.TabIndex = 10;
            label2.Text = " >";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(498, 78);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Path to the target folder";
            textBox1.Size = new Size(273, 29);
            textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 506);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel_targetFiles);
            Controls.Add(panel_currentFiles);
            Controls.Add(button_selectTarget);
            Controls.Add(button_selectFolder);
            Controls.Add(cb_targetFormat);
            Controls.Add(label1);
            Controls.Add(cb_currentFormat);
            Controls.Add(button_selectFile);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Video Converter";
            this.Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_selectFile;
        private ComboBox cb_currentFormat;
        private Label label1;
        private ComboBox cb_targetFormat;
        private Button button_selectFolder;
        private Panel panel_currentFiles;
        private Panel panel_targetFiles;
        private Button button_selectTarget;
        private Label label2;
        private TextBox textBox1;
    }
}