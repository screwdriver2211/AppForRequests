using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppForRequests
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonInput_Click(object sender, RoutedEventArgs e)
        {
            EnterForm enterForm = new EnterForm();
            enterForm.ShowDialog();
        }
        private void buttonOutput_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonInputInvoice_Click_1(object sender, RoutedEventArgs e)
        {
            EnterConsignmentNote ecn = new EnterConsignmentNote();
            ecn.ShowDialog();
        }
    }
}
