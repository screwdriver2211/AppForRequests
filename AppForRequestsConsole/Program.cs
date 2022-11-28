using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForRequestsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество вводимых заявок: ");
            int countRequest = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Заявки вводятся по маске:");
            //Console.WriteLine("Заявка (номер число), (название детали строка) - (количество число)");
            List<Request> requestList = new List<Request>();
            for (int i = 0; i < countRequest; i++)
            { 
                Console.Write("Заявка № ");
                int requestNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Деталь для заявки №{requestNumber} ");
                string partName = Console.ReadLine();
                Console.Write($"Количество детали \"{partName}\" ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                requestList.Add(new Request(requestNumber, partName, quantity));
            }

            Console.WriteLine("Введите количество вводимых заявок: ");
            int countConsignment = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Накладная вводится по маске:");
            Console.WriteLine("Накладная (номер число), (название детали строка) - (количество число)");
            List<ConsignmentNote> consignmentList = new List<ConsignmentNote>();
            for (int i = 0; i < countConsignment; i++)
            {
                Console.Write("Накладная №");
                int consignmentNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write(",");
                string partName = Console.ReadLine();
                int quantity = Convert.ToInt32(Console.ReadLine());
                consignmentList.Add(new ConsignmentNote(consignmentNumber, partName, quantity));
            }
            Console.Clear();
            Console.WriteLine("Исходные данные:");
            foreach (var item in requestList)
            {
                Console.WriteLine(item.ToString());
            }
            foreach (var item in consignmentList)
            {
                Console.WriteLine(  item.ToString());
            }

            Console.Read();
        }
    }
}
