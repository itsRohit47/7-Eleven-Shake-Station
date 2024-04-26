namespace SevenElevenShakeStation
{
    public class Supply
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Supply(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public string GetName() { return Name; }
        public int GetQuantity() { return Quantity; }
    }
}