using LayoutProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyPngStockHelper.Properties;

namespace TinyPngStockHelper
{
    public partial class Form1 : Form
    {
        String[] picsRes;

        public Form1()
        {
            InitializeComponent();
            loadPreviousParams();
        }

        private void loadPreviousParams()
        {
            apiKeyTB.Text = Settings.Default.APIKey;
            pythonPathTB.Text = Settings.Default.PythonPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo[] fileList = new DirectoryInfo(folderPathTB.Text.ToString()).GetFiles("*.png", SearchOption.AllDirectories);
            picsRes = new String[fileList.Length];
            for (int i = 0; i < fileList.Length; i++)
            {
                filesRTB.AppendText(fileList[i].FullName + "\n");
                picsRes[i] = fileList[i].FullName;
            }

            filesConterLabel.Text = fileList.Length + " Files";
        }

        private void outputFolderBrowseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = outputFolderDialog.ShowDialog();
            if (result == DialogResult.OK && outputFolderDialog.SelectedPath.Length > 0)
            {
                folderPathTB.Text = outputFolderDialog.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pythonPathDialog.ShowDialog();
        }


        private void pythonPathDialog_FileOk(object sender, CancelEventArgs e)
        {
            pythonPathTB.Text = TitleExporter(sender.ToString());
        }

        private string TitleExporter(string fileLongStr)
        {
            return fileLongStr.ToString().Substring(fileLongStr.ToString().IndexOf("FileName: ") + 10);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PicCompressor picCompressor = new PicCompressor();
            picCompressor.compressPic(filesRTB, pythonPathTB.Text, apiKeyTB.Text, picsRes);
        }
    }
}
