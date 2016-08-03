using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewestFile
{
    public partial class Form1 : Form
    {
        private FileInfo fileNewest;
        private FileInfo fileOldest;
        private UInt32 processedCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            fileNewest = null;
            fileOldest = null;
            processedCount = 0;

            string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (var name in fileNames)
            {
                if (Directory.Exists(name)) {
                    // Check if the file is a directory.
                    // Parse directory.
                    ProcessDirectory(new DirectoryInfo(name));
                } else {
                    RegisterFile(new FileInfo(name));
                }
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false)) {
                e.Effect = DragDropEffects.All;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ProcessDirectory(DirectoryInfo inDir) {
            foreach (var file in inDir.GetFiles()) {
                RegisterFile(file);
            }

            foreach (var dir in inDir.GetDirectories()) {
                ProcessDirectory(dir);
            }
        }

        private void RegisterFile(FileInfo file) {          
            processedCount++;
            labelTotalProcessed.Text = processedCount.ToString();
            labelLastFile.Text = file.FullName;
            if ((fileNewest == null) || (file.LastWriteTime > fileNewest.LastWriteTime)) {
                fileNewest = file;
                textNewestFileName.Text = file.FullName;
                textNewestFileDate.Text = file.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if ((fileOldest == null) || (file.LastWriteTime < fileOldest.LastWriteTime)) {
                fileOldest = file;
                textOldestFileName.Text = file.FullName;
                textOldestFileDate.Text = file.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            Application.DoEvents();
        }
    }
}
