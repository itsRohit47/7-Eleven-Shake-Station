namespace SevenElevenShakeStation
{
    public class Drink
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public CupSize CupSize { get; set; }
        public List<Topping> Toppings { get; set; }
        public List<Ingredient> Ingredients { get; set; } // Add this property

        public Drink(string name, string description, CupSize cupSize, List<Topping> toppings, List<Ingredient> ingredients)
        {
            Name = name;
            Description = description;
            CupSize = cupSize;
            Toppings = toppings;
            Ingredients = ingredients; // Initialize the property
        }
    }
}