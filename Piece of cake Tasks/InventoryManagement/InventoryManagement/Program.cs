using System;

namespace InventoryManagement
{
    internal class Program
    {
        static string[,] inventory = new string[50, 3];
        static int ProdcutCount = 0;
        static void Main(string[] args)
        {

            string userChoice = "";

            Console.WriteLine("Welcome to the inventory system!");
            Console.WriteLine("_________________________________");

            do
            {
                Console.WriteLine("\nChoose which action you'd like to take: ");
                Console.WriteLine("\n1. Add a new product");
                Console.WriteLine("2. Update a product");
                Console.WriteLine("3. View a product");
                Console.WriteLine("4. Exit\n");

                userChoice = Console.ReadLine();

                if (userChoice == "4")
                {
                    Console.WriteLine("See you later :)");
                    break;
                }

                switch (userChoice)
                {
                    case "1":
                        AddProduct();
                        break;

                    case "2":
                        UpdateProduct();
                        break;

                    case "3":
                        ViewProducts();
                        break;

                    default:
                        Console.WriteLine("Choose from 1-4 only plz :)");
                        break;

                } 
            } while (userChoice != "4");

        }

        private static void AddProduct()
        {
            Console.WriteLine("Enter the name of your product plz :) : ");
            string name = Console.ReadLine();

            Console.WriteLine("\nIts price: ");
            string price = Console.ReadLine();

            Console.WriteLine("\nAnd its quantity: ");
            string quantity = Console.ReadLine();

            inventory[ProdcutCount, 0] = name;
            inventory[ProdcutCount, 1] = price;
            inventory[ProdcutCount, 2] = quantity;
            ProdcutCount++;

            Console.WriteLine("\nProduct added! ^^");
            Console.WriteLine("__________________________");
            
            
        }

        private static void UpdateProduct()
        {
            int updatedIndex = -1;
            Console.WriteLine("Enter the product's name which you want to update: ");
            string updatedProduct = Console.ReadLine();

            for(int i = 0; i < ProdcutCount; i++)
            {
                if (inventory[i,0] == updatedProduct)
                {
                    updatedIndex = i;
                    break;
                }
            }

            if (updatedIndex != -1)
            {
                string userupdate = "";

                do
                {
                    Console.WriteLine("\nWhat do you want to update?");
                    Console.WriteLine("\n1. Product's name");
                    Console.WriteLine("2. Product's price");
                    Console.WriteLine("3. Product's quantity");
                    Console.WriteLine("4. Go back\n");

                    userupdate = Console.ReadLine();

                    if (userupdate == "4")
                    {
                        Console.WriteLine("Update done. Returning to main menu.");
                        break;
                    }

                    switch (userupdate)
                    {
                        case "1":
                            Console.WriteLine("Enter the new name: ");
                            string NewName = Console.ReadLine();
                            inventory[updatedIndex, 0] = NewName;
                            Console.WriteLine("Product updated ^^");
                            break;

                        case "2":
                            Console.WriteLine("Enter the new price: ");
                            string NewPrice = Console.ReadLine();
                            inventory[updatedIndex, 1] = NewPrice;
                            Console.WriteLine("Product updated ^^");
                            break;

                        case "3":
                            Console.WriteLine("Enter the new quantity: ");
                            string NewQuantity = Console.ReadLine();
                            inventory[updatedIndex, 2] = NewQuantity;
                            Console.WriteLine("Product updated ^^");
                            break;

                        default:
                            Console.WriteLine("Choose from 1-4 only plz :)");
                            break;

                    }
                } while (userupdate != "4");

            }
            else
            {
                Console.WriteLine($"\nProduct '{updatedProduct}' not found in inventory.");
            }
        }

        private static void ViewProducts()
        {
            if(ProdcutCount !=0)
            {
                Console.WriteLine("Product list:");

                for (int i = 0; i < ProdcutCount; i++)
                {
                    Console.WriteLine($"Product ID: {i+1}, Product name: {inventory[i, 0]}, Product price: {inventory[i, 1]}, Product quantity {inventory[i, 2]}");

                }
            }
        }

    }
}
