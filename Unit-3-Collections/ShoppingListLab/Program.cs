namespace ShoppingListLab
{
    // 1. Display at least 8 item names and prices. (X)
    // 2. Ask the user to enter an item name
    //          If that item exists, display that item and price and add that item to the user’s order.
    //          If that item doesn’t exist, display an error and re-prompt the user.  (Display the menu again if you’d like.)
    // 3. After adding one to their order, ask if they want to add another. If so, repeat.  (User can enter an item more than once; we’re not keeping track of quantity at this point.)
    // 4. When they’re done adding items, display a list of all items ordered with prices in columns.
    // 5. Display the sum price of the items ordered.



    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> shoppingItem = new();
            {
                shoppingItem.Add("Hot Dog", 3.75);
                shoppingItem.Add("Beef", 5.28);
                shoppingItem.Add("Pizza", 7.42);
                shoppingItem.Add("Buns", 2.82);
                shoppingItem.Add("Cheddar", 1.80);
                shoppingItem.Add("Chips", 4.58);
                shoppingItem.Add("Soft Taco Shells", 4.09);
                shoppingItem.Add("Water", 6.26);
                
             }

            Console.Write("Please enter an item name");
            // Dictionaries with multiple values    
            
           


        }
    }
}
