using System.Windows;
using System.Collections.Generic;

namespace AppForRequests
{
    /// <summary>
    /// Логика взаимодействия для Output.xaml
    /// </summary>
    public partial class Output : Window
    {
        public Output()
        {
            InitializeComponent();
            string text = textBlock.Text;
        }

        private void Window_Activated(object sender, System.EventArgs e)
        {
            this.textBlock.Text += "Исходные данные\n";
            foreach (var item in Globals.requests)
            {
                this.textBlock.Text += ($"{item.NumberRequest}, {item.PartName} - {item.QuantityOrdered} шт\n");
            }
            
            foreach (var item in Globals.consignmentNotes)
            {
                this.textBlock.Text += ($"{item.NumberConsignment}, {item.PartName} - {item.QuantityShipped} шт\n");
            }
            this.textBlock.Text += "\n";
            this.textBlock.Text += "\n";
            foreach(var item in Globals.requests)
            {
                Calculate(item, Globals.consignmentNotes);
            }
        }
        public void Calculate(Request rec, List<ConsignmentNote> consignmentList)
        {
            foreach (var item in consignmentList)
            {
                if (rec.PartName == item.PartName)
                {
                    if (rec.QuantityOrdered == item.QuantityShipped)
                    {
                        int count = rec.QuantityOrdered;
                        this.textBlock.Text += (rec.ToString() + " " + item.ToString()) + "\n";
                        rec.QuantityOrdered = rec.QuantityOrdered - item.QuantityShipped;


                        item.QuantityShipped -= count;
                        return;
                    }
                    if (rec.QuantityOrdered > item.QuantityShipped && item.QuantityShipped!=0)
                    {
                        int count = item.QuantityShipped;
                        this.textBlock.Text += (rec.ToString() + " " + item.ToString()) + "\n";
                        rec.QuantityOrdered = rec.QuantityOrdered - item.QuantityShipped;

                        item.QuantityShipped -= count;
                        if (rec.QuantityOrdered == 0)
                        {
                            return;
                        }
                    }
                    if (rec.QuantityOrdered < item.QuantityShipped)
                    {
                        int count = rec.QuantityOrdered;
                        this.textBlock.Text += (rec.ToString() + " " + "отгружено - " + count + " шт(" + item.NumberConsignment + "\n");

                        rec.QuantityOrdered = rec.QuantityOrdered - count;
                        item.QuantityShipped -= count;
                        if (rec.QuantityOrdered == 0)
                        {
                            return;
                        }
                    }
                }
            }

            this.textBlock.Text += (rec.ToString() + " отгружено - нет\n");
        }
    }
}
