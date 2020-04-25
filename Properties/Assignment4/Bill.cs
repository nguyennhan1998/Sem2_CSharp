using System;

namespace AP.Properties.Assignment4
{
    public class Bill
    {
        private int id;
        private string name;
        private DateTime date;
        private string nationality;
        private int amount;
        private int price;
        private int money;

        public Bill()
        {
            Console.WriteLine("your bill");
        }

        public Bill(int id, string name, DateTime date, string nationality, int amount, int price, int money)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.nationality = nationality;
            this.amount = amount;
            this.price = price;
            this.money = money;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public DateTime Date
        {
            get => date;
            set => date = value;
        }

        public string Nationality
        {
            get => nationality;
            set => nationality = value;
        }

        public int Amount
        {
            get => amount;
            set => amount = value;
        }

        public int Price
        {
            get => price;
            set => price = value;
        }

        public int Money
        {
            get => money;
            set => money = value;
        }
        

        public void PrintBill()
        {
            Console.WriteLine("ID: "+id+"\nName: "+name+"\nDate: "+date+"\nNationality: "+nationality+"\nAmount: "+amount+"\nPrice: "+this.Price+"\nMoney: "+this.Money);
        }
    }
}