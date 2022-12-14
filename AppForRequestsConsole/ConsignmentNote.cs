namespace AppForRequestsConsole
{
    class ConsignmentNote
    {
        public int NumberConsignment { get; set; }
        public string PartName { get; set; }
        public int QuantityShipped { get; set; }

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
                return $"отгружено - нет";
        }

    }
}

