using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Video_Converter
{
    public partial class Form1 : Form
    {
        OpenFileDialog selectingFile;
        FolderBrowserDialog selectingFolder;
        CultureInfo en;
        ToolTip toolTip;
        int fileCount;
        public Form1()
        {
            InitializeComponent();
            en = new CultureInfo("en-EN");
            fileCount = 0;
        }


        private void button_selectFile_Click(object sender, EventArgs e)
        {
            selectingFile = new OpenFileDialog();
            selectingFile.Filter = $"{cb_currentFormat.SelectedItem.ToString()}|*.{cb_currentFormat.SelectedItem.ToString().ToLower(en)}";
            selectingFile.FilterIndex = 1;

            selectingFile.Multiselect = true;

            DialogResult result = selectingFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                string[] selectedFilesPaths = selectingFile.FileNames;
                foreach (string path in selectedFilesPaths)
                {
                    FileControl fileControl = new FileControl();
                    panel_currentFiles.Controls.Add(fileControl);
                    fileControl.Name = fileCount.ToString();
                    fileControl.FileName = Path.GetFileName(path);
                    fileControl.FilePath = path;
                    fileControl.IsFolder = false;
                    fileControl.Location = new Point(3, 3 + fileCount * fileControl.Height);
                    fileControl.DeleteClick += FileControl_DeleteClick;
                    fileCount++;
                }
            }

        }
        private void button_selectFolder_Click(object sender, EventArgs e)
        {
            selectingFolder = new FolderBrowserDialog();

            DialogResult result = selectingFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selectedFolderPath = selectingFolder.SelectedPath;
                if (!string.IsNullOrEmpty(selectedFolderPath))
                {
                    FileControl fileControl = new FileControl();
                    panel_currentFiles.Controls.Add(fileControl);
                    fileControl.Name = fileCount.ToString();
                    fileControl.FileName = Path.GetFileName(selectedFolderPath) + "/*";
                    fileControl.FilePath = selectedFolderPath;
                    fileControl.IsFolder = true;
                    fileControl.Location = new Point(3, 3 + fileCount * fileControl.Height);
                    fileControl.DeleteClick += FileControl_DeleteClick;
                    fileCount++;
                }
                
            }
        }

        private void FileControl_DeleteClick(object? sender, EventArgs e)
        {
            if (sender is FileControl control)
            {
                int deletedControlIndex = panel_currentFiles.Controls.IndexOf(control);
                panel_currentFiles.Controls.Remove(control);
                control.Dispose();
                panel_currentFiles.AutoScroll = false;
                for (int i = deletedControlIndex; i < panel_currentFiles.Controls.Count; i++)
                {
                    panel_currentFiles.Controls[i].Location = new Point(3, panel_currentFiles.Controls[i].Location.Y - panel_currentFiles.Controls[i].Height);
                }
                fileCount--;
                panel_currentFiles.AutoScroll = true;
            }
        }

        private void cb_currentFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_currentFormat.SelectedIndex == 0)
            {
                button_selectFile.Enabled = false;
            }
            else
            {
                button_selectFile.Enabled = true;
            }
        }

        private void cb_targetFormat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_currentFormat.SelectedIndex = 0;
            cb_targetFormat.SelectedIndex = 0;
        }

    }
}