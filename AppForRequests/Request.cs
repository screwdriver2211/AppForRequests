namespace AppForRequests
{

    public class Request
    {
        /// <summary>
        /// Номер заявки
        /// </summary>
        public string NumberRequest { get; set; }
        public string PartName { get; set; }
        public int QuantityOrdered { get; set; }


        public Request(string numberConsignment, string partName, int quantityOrdered)
        {
            NumberRequest = numberConsignment;
            PartName = partName;
            QuantityOrdered = quantityOrdered;
        }
        public override string ToString()
        {
            return $"{NumberRequest}. {PartName}: заказано - {QuantityOrdered} шт, ";
        }

    }
}
