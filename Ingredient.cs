namespace SevenElevenShakeStation
{
    public class Ingredient
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Ingredient(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public string GetName() { return Name; }
        public int GetQuantity() { return Quantity; }
    }
}