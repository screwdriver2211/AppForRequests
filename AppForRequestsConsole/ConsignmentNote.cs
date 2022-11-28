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
        private int PartId { get; set; }
        private int QuantityShipped { get; set; }
        private bool IsNotNullQuantity { get; set; }

        public ConsignmentNote(int numberConsignment, int quantityShipped, string partName = null, int partId = -1)
        {
            NumberConsignment = numberConsignment;
            PartId = partId;
            PartName = partName;
            QuantityShipped = quantityShipped;
            IsNotNullQuantity = true;
        }

        public  string ShowConsignment()
        {
            string partrInform = "";
            if (PartName == null && PartId != -1)
            {
                partrInform =PartId.ToString();
            }
            else if (PartName != null && PartId == -1)
            {
                partrInform = PartName;
            }

            return "Накладная № " + NumberConsignment + ", " + partrInform + " - " + QuantityShipped + " шт";
        }
        public  string ShowRemainderConsignment(int needCount)
        {
            int quantity=-1;
            if (QuantityShipped ==0)
            {
                IsNotNullQuantity = false;
                return " нет";
            }
            if (needCount> QuantityShipped)
            {
                quantity = QuantityShipped;
            } else if(needCount < QuantityShipped)
            {
                quantity = needCount;
            }
            else if (needCount == QuantityShipped)
            {
                quantity = needCount;
            }

            return  quantity + " шт (Накладная № " + NumberConsignment +") ";
        }
    }
}

