namespace ShoppingListLab
{




  class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> shoppingItem = new();
            shoppingItem.Add("Hot dog", 3.75);
            shoppingItem.Add("Beef", 5.28);
            shoppingItem.Add("Pizza", 7.42);
            shoppingItem.Add("Buns", 2.82);
            shoppingItem.Add("Cheddar", 1.80);
            shoppingItem.Add("Chips", 4.58);
            shoppingItem.Add("Soft Taco Shells", 4.09);
            shoppingItem.Add("Water", 6.26);
            foreach (KeyValuePair<String, double> keyValuePair in shoppingItem) 

            //Console.WriteLine("Please enter an item.");
            {
                Console.WriteLine("Please enter an item.");
            }


        }
    }
}
