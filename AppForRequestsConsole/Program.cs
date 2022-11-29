using System;
using System.Collections.Generic;

namespace AppForRequestsConsole
{
    class Program
    {

        public static void Calculate(Request rec, List<ConsignmentNote> consignmentList)
        {
            foreach (var item in consignmentList)
            {
                if (rec.PartName == item.PartName)
                {
                    if (rec.QuantityOrdered == item.QuantityShipped)
                    {
                        int count = rec.QuantityOrdered;
                        Console.WriteLine(rec.ToString() + " " + item.ToString());
                        rec.QuantityOrdered = rec.QuantityOrdered - item.QuantityShipped;


                        item.QuantityShipped -= count;
                        return;
                    }
                    if (rec.QuantityOrdered > item.QuantityShipped&& item.QuantityShipped!=0)
                    {
                        int count = item.QuantityShipped;
                        Console.WriteLine(rec.ToString() + " " + item.ToString());
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
                        Console.WriteLine(rec.ToString() + " " + "отгружено - " + count + " шт(накладная №" + item.NumberConsignment);

                        rec.QuantityOrdered = rec.QuantityOrdered - count;
                        item.QuantityShipped -= count;
                        if (rec.QuantityOrdered == 0)
                        {
                            return;
                        }
                    }
                }
            }

            Console.WriteLine(rec.ToString() + " отгружено - нет");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество вводимых заявок: ");
            int countRequest;
            while (!int.TryParse(Console.ReadLine(), out countRequest) && countRequest < 1)
            {
                Console.WriteLine("Ввод произведен не верно повторите ввод: ");
            }

            //Console.WriteLine("Заявки вводятся по маске:");
            //Console.WriteLine("Заявка (номер число), (название детали строка) - (количество число)");

            List<Request> requestList = new List<Request>();
            for (int i = 0; i < countRequest; i++)
            {
                Console.Write("Заявка № ");
                int requestNumber;
                while (!int.TryParse(Console.ReadLine(), out requestNumber) && countRequest < 1)
                {
                    Console.WriteLine("Ввод произведен не верно повторите ввод: ");
                }
                Console.Write($"Деталь для заявки №{requestNumber} ");
                string partName = Console.ReadLine();
                Console.Write($"Количество деталей \"{partName}\" ");
                int quantity;
                while (!int.TryParse(Console.ReadLine(), out quantity) && countRequest < 1)
                {
                    Console.WriteLine("Ввод произведен не верно повторите ввод: ");
                }
                requestList.Add(new Request(requestNumber, partName, quantity));
            }

            Console.WriteLine("Введите количество вводимых накладных: ");
            int countConsignment;
            while (!int.TryParse(Console.ReadLine(), out countConsignment))
            {
                Console.WriteLine("Ввод произведен неверно повторите ввод: ");
            }

            Console.WriteLine("Введите номер накладной ");
            List<ConsignmentNote> consignmentList = new List<ConsignmentNote>();
            for (int i = 0; i < countConsignment; i++)
            {
                Console.Write("Накладная № ");
                int consignmentNumber;
                while (!int.TryParse(Console.ReadLine(), out consignmentNumber) && countRequest < 1)
                {
                    Console.WriteLine("Ввод произведен неверно повторите ввод: ");
                }

                Console.Write($"Деталь для накладной №{consignmentNumber} ");
                string partName = Console.ReadLine();
                Console.Write($"Количество деталей \"{partName}\" ");
                int quantity;
                while (!int.TryParse(Console.ReadLine(), out quantity) && countRequest < 1)
                {
                    Console.WriteLine("Ввод произведен не верно повторите ввод: ");
                }
                consignmentList.Add(new ConsignmentNote(consignmentNumber, partName, quantity));
            }
            Console.Clear();
            Console.WriteLine("Исходные данные:");
            foreach (var item in requestList)
            {
                Console.WriteLine($"Заявка №{item.NumberRequest}, {item.PartName} - {item.QuantityOrdered} шт");
            }
            foreach (var item in consignmentList)
            {
                Console.WriteLine($"Накладная №{item.NumberConsignment}, {item.PartName} - {item.QuantityShipped} шт");
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in requestList)
            {
                Calculate(item, consignmentList);
            }
            Console.Read();
        }
    }
}
