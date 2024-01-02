using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Converter
{
    public partial class FileControl : UserControl
    {
        ToolTip toolTip;
        string _filePath;
        public event EventHandler DeleteClick;
        public FileControl()
        {
            InitializeComponent();

            toolTip = new ToolTip();
            _filePath = "";
            pb_deleteIcon.Location = new Point(2, 2);
            pb_fileIcon.Location = new Point(26, 2);
            label_fileName.Location = new Point(57, 2);
        }

        public string FileName
        {
            get { return label_fileName.Text; }
            set { label_fileName.Text = value; }
        }

        public string FilePath
        {
            get
            {
                return _filePath;
            }
            set
            {
                _filePath = value;
                toolTip.SetToolTip(label_fileName, value);
            }
        }

        public bool IsFolder
        {
            get
            {
                if (pb_fileIcon.BackgroundImage == Properties.Resources.folder)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value)
                {
                    pb_fileIcon.BackgroundImage = Properties.Resources.folder;
                }
                else
                {
                    pb_fileIcon.BackgroundImage = Properties.Resources.video;
                }
            }
        }

        private void pb_deleteIcon_Click(object sender, EventArgs e)
        {
            DeleteClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
