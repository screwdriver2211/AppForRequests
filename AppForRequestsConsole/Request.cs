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
        private int NumberRequest { get; set; }
        private string PartName { get; set; }
        private int QuantityOrdered { get; set; }
        

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
