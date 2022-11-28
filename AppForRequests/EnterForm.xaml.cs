using System.Windows;
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
