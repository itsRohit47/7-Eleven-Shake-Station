using System;
using SevenElevenShakeStation;
public class Menu
{
    public List<Drink> Drinks { get; set; } = new List<Drink>();

    public void AddDrink(string name, Drink drink)
    {
        Drinks.Add(drink);
    }
}

namespace ShakeStationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ingredient> ingredients = new List<Ingredient>()
            {
                new Ingredient("Ice Cream", 100),
                new Ingredient("Milk", 50),
                new Ingredient("Strawberry Flavoring", 50)
            };

            List<Supply> supplies = new List<Supply>()
            {
                new Supply("Cups", 50),
                new Supply("Lids", 50),
                new Supply("Straws", 50)
            };

            Inventory inventory = new Inventory(ingredients, supplies);

            // Create a new Shake Station machine
            Machine machine = new Machine(inventory);

            // Define the menu
            Menu menu = new Menu();
            menu.AddDrink(
                "Chocolate Shake",
                new Drink(
                    "Chocolate Shake",
                    "A rich, chocolatey shake",
                    CupSize.Medium,
                    new List<Topping> { new Topping("Whipped Cream", "") },
                    new List<Ingredient>
                    {
                        new Ingredient("Ice Cream", 1),
                        new Ingredient("Milk", 1)
                    }
                )
            );
            menu.AddDrink(
                "Strawberry Shake",
                new Drink(
                    "Strawberry Shake",
                    "A sweet, fruity shake",
                    CupSize.Small,
                    new List<Topping> { new Topping("Sprinkles", "") },
                    new List<Ingredient>
                    {
                        new Ingredient("Ice Cream", 1),
                        new Ingredient("Strawberry Flavoring", 1)
                    }
                )
            );
            // Display initial inventory stats - ingredients only
            Console.WriteLine("Initial Inventory Stats:");
            foreach (var ingredient in inventory.GetIngredients())
            {
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity}");
            }
            // foreach (var supply in inventory.GetSupplies())
            // {
            //     Console.WriteLine($"{supply.Name}: {supply.Quantity}");
            // }

            Console.WriteLine("------------------------------------------------------");

            while (true)
            {
                // Display the menu
                Console.WriteLine("Welcome to 7-Eleven Shake Station!");
                Console.WriteLine("Menu:");
                for (int i = 1; i <= menu.Drinks.Count; i++)
                {
                    var drink = menu.Drinks[i - 1];
                    Console.WriteLine($"{i}. {drink.Name} - {drink.Description} ({drink.CupSize})");
                }

                // Get the user's order
                Console.Write("Select the drink (or 'q' to quit): ");
                string orderInput = Console.ReadLine();
                if (orderInput.ToLower() == "q") break;

                int order = int.Parse(orderInput);

                // Prepare and serve the drink
                Drink orderedDrink = menu.Drinks[order - 1];
                machine.DispenseDrink(orderedDrink);
                machine.DispenseCup(orderedDrink.CupSize);
                machine.DispenseToppings(orderedDrink.Toppings);
                machine.BlendDrink();



                Console.WriteLine("Enjoy your drink!");
                Console.WriteLine("------------------------------------------------------");

            }

            // Display updated inventory stats
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Updated Inventory Stats: Ingredients only");
            foreach (var ingredient in inventory.GetIngredients())
            {
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity}");
            }
            // foreach (var supply in inventory.GetSupplies())
            // {
            //     Console.WriteLine($"{supply.Name}: {supply.Quantity}");
            // }
        }
    }
}

