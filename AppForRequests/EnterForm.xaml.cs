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
using System.Data.OleDb;
namespace AppForRequests
{
    /// <summary>
    /// Логика взаимодействия для EnterForm.xaml
    /// </summary>
    public partial class EnterForm : Window
    {
        public EnterForm()
        {
            InitializeComponent();
        }

        private void buttonEnterRequest_Click(object sender, RoutedEventArgs e)
        {
            Database db = new Database();
            //db.Requests.Inse
        }
    }
}
