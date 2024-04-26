namespace SevenElevenShakeStation
{
    public class Inventory
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<Supply> Supplies { get; set; }

        public Inventory(List<Ingredient> ingredients, List<Supply> supplies)
        {
            Ingredients = ingredients;
            Supplies = supplies;
        }

        public List<Ingredient> GetIngredients() { return Ingredients; }
        public List<Supply> GetSupplies() { return Supplies; }
        public void Restock()
        {
            // Implementation to restock ingredients and supplies
            // For example, we could increase the quantity of each ingredient and supply
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity += 10;
            }

            foreach (var supply in Supplies)
            {
                supply.Quantity += 10;
            }
        }
    }
}