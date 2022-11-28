using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForRequestsConsole
{
    class ConsignmentNote
    {
            static int NumberConsignment;
        static string PartName;
        static int PartId;
        static int QuantityShipped;
        static bool IsNullQuantity;
        public ConsignmentNote(int numberConsignment, string partName = null, int partId = -1, int quantityShipped)
        {
            NumberConsignment = numberConsignment;
            PartId = partId;
            PartName = partName;
            QuantityShipped = quantityShipped;
            IsNullQuantity = true;
        }

        public static string ShowConsignment()
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
        public static string ShowRemainderConsignment(int needCount)
        {
            int quantity=-1;
            if (QuantityShipped ==0)
            {
                IsNullQuantity = false;
                return " нет";
            }
            if (needCount> QuantityShipped)
            {
                quantity = QuantityShipped;
            } else if(needCount < QuantityShipped)
            {

            }



            return "Накладная № " + NumberConsignment + ", " + partrInform + " - " + QuantityShipped + " шт";
        }
    }
}

