﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameFiles
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        string path = "";

        private void button_ChooseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath;
                label_Folder.Text = path;

                if (!Directory.Exists(path))
                {
                    listBox_AllFiles.Items.Add($"> Папка {path} недоступна.");
                }
            }

            GetFileNames(path);
        }

        private void button_Rename_Click_1(object sender, EventArgs e)
        {
            RenameFiles(path);
        }

        private void GetFileNames(string path)
        {
            try
            {
                // Only get files that contain the subsring " copy".
                string[] dirs = Directory.GetFiles(path, "* copy*");

                listBox_AllFiles.Items.Add($"> В папке {path}");
                listBox_AllFiles.Items.Add($"найдено {dirs.Length} файлов, содержащих ' copy':");
                listBox_AllFiles.Items.Add("");

                foreach (string dir in dirs)
                {
                    listBox_AllFiles.Items.Add($"> {Path.GetFileName(dir)}"); // get namefile.jpg
                }
            }
            catch (Exception ex)
            {
                listBox_AllFiles.Items.Add($"> Произошла ошибка: {ex.ToString()}");
            }

            listBox_AllFiles.Items.Add("");
        }

        private void RenameFiles(string path)
        {
            listBox_AllFiles.Items.Clear();
            listBox_AllFiles.Items.Add("> Переименование:");
            listBox_AllFiles.Items.Add("");

            string[] dirs = Directory.GetFiles(path, "* copy*");
            string dirCopy;
            int numberRenamedFiles = 0;

            foreach (string dir in dirs)
            {
                dirCopy = dir.Replace(" copy.", ".");
                string messageResultRenamed = $"{Path.GetFileName(dir) } -> {Path.GetFileName(dirCopy)}";

                if (!File.Exists(dirCopy))
                {
                    File.Move(dir, dirCopy);
                    listBox_AllFiles.Items.Add($"> Успешно: {messageResultRenamed}");
                    numberRenamedFiles++;
                }
                else
                {
                    listBox_AllFiles.Items.Add($"> Ошибка: {messageResultRenamed} - [такой файл уже существует!]");
                }
            }

            listBox_AllFiles.Items.Add("");
            listBox_AllFiles.Items.Add($"> Завершено! Переименовано {numberRenamedFiles} файлов.");
            listBox_AllFiles.Items.Add("");
        }
        
    }
}
    