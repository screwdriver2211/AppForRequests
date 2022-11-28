using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForRequestsConsole
{
    class ConsignmentNote
    {
        private int NumberConsignment { get; set; }
        private string PartName { get; set; }
        private int QuantityShipped { get; set; }

        public ConsignmentNote(int numberConsignment, string partName, int quantityShipped)
        {
            NumberConsignment = numberConsignment;
            PartName = partName;
            QuantityShipped = quantityShipped;
        }
        public override string ToString()
        {
            if (QuantityShipped != 0)
                return $"отгружено - {QuantityShipped} шт (накладная №{NumberConsignment})";
            else
                return $"отгруено - нет";
        }

    }
}

