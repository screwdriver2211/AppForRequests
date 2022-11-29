using System.Windows;
using System;

namespace AppForRequests
{
    /// <summary>
    /// Логика взаимодействия для EnterConsignmentNote.xaml
    /// </summary>
    public partial class EnterConsignmentNote : Window
    {
        public EnterConsignmentNote()
        {
            InitializeComponent();
        }

        private void buttonEnterConsignment_Click(object sender, RoutedEventArgs e)
        {
            string numberOfCN = numberOfConsignmentNotes.Text;
            string nameofDet = codeOfDetail.Text;
            int count = Convert.ToInt32(textBoxCount.Text);

            ConsignmentNote consignmentNote = new ConsignmentNote(numberOfCN, nameofDet, count);
            Globals.consignmentNotes.Add(consignmentNote);
            Close();
        }
    }
}
