﻿
namespace RenameFiles
{
    partial class Form1
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
            this.label_NameProgram = new System.Windows.Forms.Label();
            this.button_ChooseFolder = new System.Windows.Forms.Button();
            this.button_Rename = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox_AllFiles = new System.Windows.Forms.ListBox();
            this.textBox_InsertSubstring = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_NameProgram
            // 
            this.label_NameProgram.AutoSize = true;
            this.label_NameProgram.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NameProgram.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_NameProgram.Location = new System.Drawing.Point(113, 7);
            this.label_NameProgram.Name = "label_NameProgram";
            this.label_NameProgram.Size = new System.Drawing.Size(623, 28);
            this.label_NameProgram.TabIndex = 0;
            this.label_NameProgram.Text = "Программа для удаления символов в именах файлов";
            // 
            // button_ChooseFolder
            // 
            this.button_ChooseFolder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_ChooseFolder.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ChooseFolder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_ChooseFolder.Location = new System.Drawing.Point(148, 91);
            this.button_ChooseFolder.Name = "button_ChooseFolder";
            this.button_ChooseFolder.Size = new System.Drawing.Size(510, 61);
            this.button_ChooseFolder.TabIndex = 1;
            this.button_ChooseFolder.Text = "Выбрать папку";
            this.button_ChooseFolder.UseVisualStyleBackColor = false;
            this.button_ChooseFolder.Click += new System.EventHandler(this.button_ChooseFolder_Click);
            // 
            // button_Rename
            // 
            this.button_Rename.BackColor = System.Drawing.SystemColors.Info;
            this.button_Rename.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.button_Rename.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_Rename.Location = new System.Drawing.Point(148, 166);
            this.button_Rename.Name = "button_Rename";
            this.button_Rename.Size = new System.Drawing.Size(510, 62);
            this.button_Rename.TabIndex = 2;
            this.button_Rename.Text = "Переименовать";
            this.button_Rename.UseVisualStyleBackColor = false;
            this.button_Rename.Click += new System.EventHandler(this.button_Rename_Click_1);
            // 
            // listBox_AllFiles
            // 
            this.listBox_AllFiles.AccessibleDescription = "";
            this.listBox_AllFiles.AccessibleName = "";
            this.listBox_AllFiles.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBox_AllFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_AllFiles.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_AllFiles.ForeColor = System.Drawing.Color.AliceBlue;
            this.listBox_AllFiles.FormattingEnabled = true;
            this.listBox_AllFiles.ItemHeight = 18;
            this.listBox_AllFiles.Location = new System.Drawing.Point(12, 245);
            this.listBox_AllFiles.Name = "listBox_AllFiles";
            this.listBox_AllFiles.Size = new System.Drawing.Size(776, 450);
            this.listBox_AllFiles.TabIndex = 5;
            // 
            // textBox_InsertSubstring
            // 
            this.textBox_InsertSubstring.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_InsertSubstring.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_InsertSubstring.ForeColor = System.Drawing.Color.Red;
            this.textBox_InsertSubstring.Location = new System.Drawing.Point(148, 49);
            this.textBox_InsertSubstring.Name = "textBox_InsertSubstring";
            this.textBox_InsertSubstring.Size = new System.Drawing.Size(510, 27);
            this.textBox_InsertSubstring.TabIndex = 6;
            this.textBox_InsertSubstring.Text = "Введите набор символов, которые нужно удалить";
            this.textBox_InsertSubstring.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_InsertSubstring_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 706);
            this.Controls.Add(this.textBox_InsertSubstring);
            this.Controls.Add(this.listBox_AllFiles);
            this.Controls.Add(this.button_Rename);
            this.Controls.Add(this.button_ChooseFolder);
            this.Controls.Add(this.label_NameProgram);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NameProgram;
        private System.Windows.Forms.Button button_ChooseFolder;
        private System.Windows.Forms.Button button_Rename;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ListBox listBox_AllFiles;
        private System.Windows.Forms.TextBox textBox_InsertSubstring;
    }
}

