using System.Collections.Generic;

namespace AP.Properties.Assignment23Fix
{
    public class Cart
    {
        private int id;
        private string customer;
        private double grandTotal;
        private List<Product> listProduct;
        private string city;
        private string country;

        public Cart(int id, string customer, double grandTotal, List<Product> listProduct, string city, string country)
        {
            this.id = id;
            this.customer = customer;
            this.grandTotal = grandTotal;
            this.listProduct = listProduct;
            this.city = city;
            this.country = country;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Customer
        {
            get => customer;
            set => customer = value;
        }

        public double GrandTotal
        {
            get => grandTotal;
            set => grandTotal = value;
        }

        public List<Product> ListProduct
        {
            get => listProduct;
            set => listProduct = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public bool AddProduct(Product product)
        {
            listProduct.Add(product);
            return true;

        }

        public bool RemoveProduct(Product product)
        {
            return listProduct.Remove(product);
        }

        public double FinalTotal()
        {
            double grand = 0;
            foreach (Product p in listProduct)
            {
                grand += p.Price;
            }

            grand += ShippingFee(grand);
            this.grandTotal = grand;
            return grandTotal;

        }

        public double ShippingFee(double grand)
        {
            if (country.Equals("VN") && city.Equals("HaNoi") || city.Equals("HCM"))
                return grand *= 0.01;
            if (country.Equals("VN")) return grand *= 0.02;
            return grand * 0.05;
        }
    }
}