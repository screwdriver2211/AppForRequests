using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForRequestsConsole
{
    class Request
    {
        private int NumberRequest { get; set; }
        private string PartName { get; set; }
        private int PartId { get; set; }
        private int QuantityShipped { get; set; }
        private bool IsNotNullQuantity { get; set; }

        public Request(int numberConsignment, int quantityShipped, string partName = null, int partId = -1)
        {
            NumberRequest = numberConsignment;
            PartId = partId;
            PartName = partName;
            QuantityShipped = quantityShipped;
            IsNotNullQuantity = true;
        }

        public string ShowConsignment()
        {
            string partrInform = "";
            if (PartName == null && PartId != -1)
            {
                partrInform = PartId.ToString();
            }
            else if (PartName != null && PartId == -1)
            {
                partrInform = PartName;
            }

            return "Заявка № " + NumberRequest + ", " + partrInform + " - " + QuantityShipped + " шт";
        }

    }
}
