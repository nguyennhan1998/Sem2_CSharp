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

        public Bill(int id, string name, DateTime date, string nationality, int amount)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.nationality = nationality;
            this.amount = amount;
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
            set
            {
                if (nationality.Equals("VietNam"))
                {
                    if (amount < 50)
                    { this.price = 1000;
                    }else if (amount >= 50 && amount < 100)
                    {
                       this.price = 1200;
                    }else if (amount >= 100 && amount < 200)
                    {
                        this.price = 1500;
                    }
                    else
                    {
                        this.price = 2000;
                    }
                }
                else
                {
                    this.price = 2000;
                }
            }
        }

        public int Money
        {
            get => money;
            set { this.money = this.price * amount; }
        }

        public void PrintBill()
        {
            Console.WriteLine("ID: "+id+"\nName: "+name+"\nDate: "+date+"\nNationality: "+nationality+"\nAmount: "+amount+"\nPrice: "+this.Price+"\nMoney: "+this.Money);
        }
    }
}