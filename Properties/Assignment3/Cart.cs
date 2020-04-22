using System;
using System.Collections.Generic;
using AP.Properties.Lab2;

namespace AP.Properties.Assignment3
{
   public class Cart : Product
    {
        private int id;
        private string customer;
        private int grandTotal;
        private string city;
        private string country;
        private List<Product> listproduct;
        private int total=0;

        public Cart(int id, string customer, string city, string country)
        {
            this.id = id;
            this.customer = customer;
            this.city = city;
            this.country = country;
            this.listproduct = new List<Product>();
        }

        public int FindProduct(Product product)
        {
            return this.listproduct.IndexOf(product);
        }

        public Boolean AddProduct(Product product)
        {
            if (FindProduct(product) > 0)
            {
                Console.WriteLine("the product is exist in the list");
                return false;
            }

            listproduct.Add(product);
            return true;
        }

        public Boolean RemoveProduct(Product product)
        {
            int foundPosition = FindProduct(product);
            if (foundPosition < 0)
            {
                Console.WriteLine("The product not found");
                return false;
            }

            this.listproduct.Remove(product);
            Console.WriteLine("Delete successfully");
            return true;
        }

        public int FindProduct(string name)
        {
            for (int i = 0; i < listproduct.Count; i++)
            {
                var product = listproduct[i];
                if (product.Name.Equals(name))
                {
                    return i;
                }
            }

            return -1;
        }

        public void PrintCart()
        {
            Console.WriteLine("customer : " + this.customer +
                              "\nCity: " + this.city +
                              "\nCountry: " + this.country);
            Console.WriteLine("your cart is : ");
            for (int i = 0; i < listproduct.Count; i++)
            {
                Console.WriteLine(listproduct[i].Id + ": " + listproduct[i].Name+" price "+ listproduct[i].Price+" Quantity "+ listproduct[i].Qty+" image"+ listproduct[i].Image);
            }
            Console.WriteLine("your grand total : "+GetGrandTotal());
        }

        public Product QueryProduct(string name)
        {
            int position = FindProduct(name);
            if (position >= 0)
            {
                return this.listproduct[position];
            }

            return null;
        }

        public string QueryProduct(Product product)
        {
            if (FindProduct(product) >= 0)
            {
                return product.Name;
            }

            return null;
        }


        public void SetGrandTotal()
        {
            int a=GetTotal();
            if (this.country.Equals("Viet Nam"))
            {
                if (this.city.Equals("Ha Noi") || this.city.Equals("HCM"))
                {
                    grandTotal = a + (a * 1 / 100);
                }
                else
                {
                    grandTotal = a + (a * 2 / 100);
                }
                
            }
            else
            {
                grandTotal = a + (a * 5 / 100);
            }
            
            
        }

        public int GetGrandTotal()
        {
            return grandTotal;
        }
        public int GetTotal()
        {
            for (int i = 0; i < listproduct.Count; i++)
            {
                var product = listproduct[i];
                total += product.Price;
            }

            return total;
        }

    }
}