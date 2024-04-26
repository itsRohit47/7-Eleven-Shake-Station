namespace SevenElevenShakeStation
{
    public class Machine
    {
        public Inventory Inventory { get; set; }
        public Drink CurrentOrder { get; set; }

        public Machine(Inventory inventory)
        {
            Inventory = inventory;
        }

        public void DispenseDrink(Drink drink)
        {
            // Implementation to dispense the drink
            // For example, we could reduce the quantity of the required ingredients
            foreach (var ingredient in drink.Ingredients)
            {
                var existingIngredient = Inventory.Ingredients.Find(i => i.Name == ingredient.Name);
                if (existingIngredient != null)
                {
                    existingIngredient.Quantity -= ingredient.Quantity;
                }
            }
        }

        public void DispenseCup(CupSize cupSize)
        {
            // Implementation to dispense a cup
            // For example, we could reduce the quantity of cups in the inventory
            var cups = Inventory.Supplies.Find(s => s.Name == "Cups");
            if (cups != null)
            {
                cups.Quantity--;
            }
        }

        public void DispenseToppings(List<Topping> toppings)
        {
            // Implementation to dispense toppings
            // For example, we could reduce the quantity of toppings in the inventory
            foreach (var topping in toppings)
            {
                var existingTopping = Inventory.Supplies.Find(s => s.Name == topping.Name);
                if (existingTopping != null)
                {
                    existingTopping.Quantity--;
                }
            }
        }

        public void BlendDrink()
        {
            // Implementation to blend the drink
            // For example, we could simply print a message indicating that the drink is blended
            Console.WriteLine("The drink is blended!");
        }
    }
}