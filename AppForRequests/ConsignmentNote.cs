namespace AppForRequests
{
    public class ConsignmentNote
    {
        public string NumberConsignment { get; set; }
        public string PartName { get; set; }
        public int QuantityShipped { get; set; }

        public ConsignmentNote(string numberConsignment, string partName, int quantityShipped)
        {
            NumberConsignment = numberConsignment;
            PartName = partName;
            QuantityShipped = quantityShipped;
        }
        public override string ToString()
        {
            if (QuantityShipped != 0)
                return $"отгружено - {QuantityShipped} шт ({NumberConsignment})";
            else
                return $"отгружено - нет";
        }

    }
}
