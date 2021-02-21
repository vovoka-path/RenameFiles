using System;
using System.IO;
using System.Windows.Forms;

namespace RenameFiles
{
    public partial class Form1 : Form
    {
        string path = "";
        string delSubstring = " copy."; // before file extension
        int numberFiles = 0;
        public Form1()
        {
            InitializeComponent();
        }

        // --- form actions ---
        private void button_ChooseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath;
                label_Folder.Text = path; // show to user

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

        // --- methods ---
        private void GetFileNames(string path)
        {
            try
            {
                // Only get files that contain the subsring " copy".
                string[] dirs = Directory.GetFiles(path, $"*{delSubstring}*");
                numberFiles = dirs.Length;

                listBox_AllFiles.Items.Add($"> В папке {path}");
                listBox_AllFiles.Items.Add($"найдено {numberFiles} файлов, содержащих '{delSubstring}':");
                listBox_AllFiles.Items.Add("");

                foreach (string dir in dirs)
                {
                    listBox_AllFiles.Items.Add($"> {Path.GetFileName(dir)}");
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
            if (path == "") {
                MessageBox.Show("Вы не выбрали папку!");
                return;
            }
            else if (numberFiles < 1) {
                MessageBox.Show("Нет файлов для переименования!");
                return;
            }

            listBox_AllFiles.Items.Clear();
            listBox_AllFiles.Items.Add("> Переименование:");
            listBox_AllFiles.Items.Add("");

            string[] dirs = Directory.GetFiles(path, $"*{delSubstring}*");
            string dirCopy;
            string messageResultRenamed;
            int numberRenamedFiles = 0;

            foreach (string dir in dirs)
            {
                dirCopy = dir.Replace($"{delSubstring}", ".");
                messageResultRenamed = $"{Path.GetFileName(dir) } -> {Path.GetFileName(dirCopy)}";

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
    
