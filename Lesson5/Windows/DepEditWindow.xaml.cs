﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lesson5.Windows
{
    /// <summary>
    /// Логика взаимодействия для DepEditWindow.xaml
    /// </summary>
    public partial class DepEditWindow : Window
    {
        uint depid;
        public DepEditWindow(uint id, string oldName)
        {
            InitializeComponent();
            tblOldName.Text = oldName;
            depid = id;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.db.editDep(tboxNewName.Text, depid))
            {
                MessageBox.Show("Название отдела изменено!");
                this.Close();
            }
            else
                MessageBox.Show("Такое название уже используется!");
        }
    }
}