using System.Windows;

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

        private void buttonOutput_Click_1(object sender, RoutedEventArgs e)
        {
            Output output = new Output();
            output.ShowDialog();
        }
    }
}
