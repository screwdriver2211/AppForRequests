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
            List<Request> reqList = new List<Request>
            {
                new Request(1, "Двигатель", 5),
                new Request(1, "Мост", 4),
                new Request(2, "Колеса", 50)
            };

            List<ConsignmentNote> consList = new List<ConsignmentNote>
            {
                new ConsignmentNote(1, "Двигатель", 5),
                new ConsignmentNote(1, "Мост", 0),
                new ConsignmentNote(2, "Колеса", 10)
            };

            for (int i = 0; i < consList.Count; i++)
            {
                Console.WriteLine(reqList[i].ToString() + consList[i].ToString());
            }
            Console.Read();
        } 
    }
}
