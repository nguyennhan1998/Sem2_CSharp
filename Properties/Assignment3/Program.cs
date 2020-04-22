using System;
using AP.Properties.Lab2;

namespace AP.Properties.Assignment3
{
   internal class Program
    {
        private static Cart cart = new Cart(1, "nhan","Ha Noi", "Viet Nam");

        public static void Main(string[] args)
        {
            Boolean quit = false;
            PrintAction();
            while (!quit)
            {
                Console.WriteLine("\nEnter action: (5 to show available actions" );
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 0: 
                        CancelTheCart();
                        quit = true;
                        break;
                    case 1: 
                        AddNewProduct();
                        break;
                    case 2: 
                        RemoveProduct();
                        break;
                    case 3: 
                        cart.SetGrandTotal();
                        cart.PrintCart();
                        break;
                    case 4: 
                        CancelTheCart();
                        quit = true;
                        break;
                    case 5: 
                        PrintAction();
                        break;
                        
                }
            }
        }

        private static void AddNewProduct()
        {
            Console.WriteLine("Enter product Id ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name of product ");
            string name = Console.ReadLine();
            Console.WriteLine("enter price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Image : ");
            string image = Console.ReadLine();
            Console.WriteLine("Enter description: ");
            string desc = Console.ReadLine();
            Product product = new Product(id, name, price, qty, image, desc);
            if (cart.AddProduct(product))
            {
                Console.WriteLine("new product added: name= : " + name);
            }
            else
            {
                Console.WriteLine("Can not add " + name);
            }
        }

        private static void RemoveProduct()
        {
            Console.WriteLine("Enter existing product name: ");
            string str = Console.ReadLine();
            Product existingProduct = cart.QueryProduct(str);
            if (existingProduct == null)
            {
                Console.WriteLine("Product not found ");
                return;
            }

            if (cart.RemoveProduct(existingProduct))
            {
                Console.WriteLine("successful deleted");
            }
            else
            {
                Console.WriteLine("Error deleted contact");
            }
        }

        private static void QueryContact()
        {
            Console.WriteLine("Enter existing name: ");
            string name = Console.ReadLine();
            Product existingProduct = cart.QueryProduct(name);
            if (existingProduct == null)
            {
                Console.WriteLine("Product can not found ");
                return;
            }

            Console.WriteLine("name " + existingProduct.Name + " exist in the cart");
        }

        private static void CancelTheCart()
        {
            Console.WriteLine("you have just cancel the cart :\\");
        }

        private static void PrintAction()
        {
            Console.WriteLine("\nAvailable actions: \npress "+"" +
                              "0 - To charge\n" +
                              "1 -To Add new Product\n" +
                              "2 -To Remove product\n" +
                              "3 -To Print your cart\n" +
                              "4 -To cancel\n" +
                              "5 -5 to show a list available actions\n");
                              
        }
    }
}