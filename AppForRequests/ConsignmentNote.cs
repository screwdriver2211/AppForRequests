namespace AppForRequests
{
    class ConsignmentNote
    {
        private int NumberConsignment { get; set; }
        private string PartName { get; set; }
        private int QuantityShipped { get; set; }

        public ConsignmentNote(int numberConsignment, int quantityShipped, string partName = null)
        {
            NumberConsignment = numberConsignment;
            PartName = partName;
            QuantityShipped = quantityShipped;
        }
    }
}
