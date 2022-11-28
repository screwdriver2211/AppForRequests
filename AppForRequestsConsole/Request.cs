using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForRequestsConsole
{
    class Request
    {
        /// <summary>
        /// Номер заявки
        /// </summary>
        public int NumberRequest { get; set; }
        public string PartName { get; set; }
        public int QuantityOrdered { get; set; }
        

        public Request(int numberConsignment, string partName, int quantityOrdered)
        {
            NumberRequest = numberConsignment;
            PartName = partName;
            QuantityOrdered = quantityOrdered;
        }
        public override string ToString()
        {
            return $"Заявка №{NumberRequest}. {PartName}: заказано - {QuantityOrdered} шт, ";
        }

    }
}
