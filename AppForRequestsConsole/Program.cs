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
<<<<<<< HEAD
            int countRequest = Convert.ToInt32(Console.ReadLine());
=======
            int countRequest ;
            while (!int.TryParse(Console.ReadLine(), out countRequest))
            {
                Console.WriteLine("Ввод произведен не верно повторите ввод: ");
            }
>>>>>>> 9472a16517d906cf27bedf65e27ca589dbf5c06e
            Console.WriteLine("Заявки вводятся по маске:");
            Console.WriteLine("Заявка (номер число), (название детали строка) - (количество число)");
            List<Request> requestList = new List<Request>();
            for (int i = 0; i < countRequest; i++)
            {
                Console.Write("Заявка №");
<<<<<<< HEAD
                int requestNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write(",");
                string partName = Console.ReadLine();
                int quantity = Convert.ToInt32(Console.ReadLine());
=======
                int requestNumber;
                while (!int.TryParse(Console.ReadLine(), out requestNumber))
                {
                    Console.WriteLine("Ввод произведен не верно повторите ввод: ");
                }
                Console.Write(",");
                string partName = Console.ReadLine();
                int quantity ;
                while (!int.TryParse(Console.ReadLine(), out quantity))
                {
                    Console.WriteLine("Ввод произведен не верно повторите ввод: ");
                }
>>>>>>> 9472a16517d906cf27bedf65e27ca589dbf5c06e
                requestList.Add(new Request(requestNumber, partName, quantity));
            }

            Console.WriteLine("Введите количество вводимых заявок: ");
<<<<<<< HEAD
            int countConsignment = Convert.ToInt32(Console.ReadLine());
=======
            int countConsignment;
            while (!int.TryParse(Console.ReadLine() ,out countConsignment))
            {
                Console.WriteLine("Ввод произведен не верно повторите ввод: ");
            }
            
            
>>>>>>> 9472a16517d906cf27bedf65e27ca589dbf5c06e
            Console.WriteLine("Накладная вводится по маске:");
            Console.WriteLine("Накладная (номер число), (название детали строка) - (количество число)");
            List<ConsignmentNote> consignmentList = new List<ConsignmentNote>();
            for (int i = 0; i < countConsignment; i++)
            {
                Console.Write("Накладная №");
<<<<<<< HEAD
                int consignmentNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write(",");
                string partName = Console.ReadLine();
                int quantity = Convert.ToInt32(Console.ReadLine());
=======
                int consignmentNumber;
                while (!int.TryParse(Console.ReadLine(), out consignmentNumber))
                {
                    Console.WriteLine("Ввод произведен не верно повторите ввод: ");
                }
                 
                Console.Write(",");
                string partName = Console.ReadLine();
                int quantity;
                while (!int.TryParse(Console.ReadLine(), out quantity))
                {
                    Console.WriteLine("Ввод произведен не верно повторите ввод: ");
                }
>>>>>>> 9472a16517d906cf27bedf65e27ca589dbf5c06e
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
