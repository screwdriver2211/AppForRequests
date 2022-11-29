using System.Windows;
using System;
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
            string numberOfReq = numberOfRequest.Text;
            string codeOfDet = codeOfDetail.Text;
            int count = Convert.ToInt32(textBoxCount.Text);
            Request request = new Request(numberOfReq, codeOfDet, count);
            Globals.requests.Add(request);
            Close();
        }
    }
}
