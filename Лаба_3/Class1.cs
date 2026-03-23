using Newtonsoft.Json;
using System;
using System.IO;
namespace Laba_3
{
    class Invoice
    {
        //private readonly int number;
        private int number;
        private double price;
        private bool paid;

        private static int count = 0;//поле для підрахунку
        public Invoice(int number, double price)
        {
            this.number = number;
            this.price = price;
            this.paid = false;//за замовченням не оплачено
            count++;
        }

        public Invoice(int number)
        {
            this.number = number;
            this.price = 0;
            this.paid = false;
            count++;
        }
        public void Pay()//робимо рахунок оплаченим
        {
            paid = true;
        }
        public bool IsPaid() //перевіряємо чи він оплачений
        {
            return paid;
        }
        public double Price//суму отримуємо через властивість тільки для читання
        {
            get { return price; }
        }
        public static int GetInvoiceCount()
        {
            return count;//повертає кількість рахунків
        }
        public override string ToString()//перевизначення методу
        {
            return $"Рахунок: {number}, Сума: {price}, Сплачено: {paid}";
        }
        public Invoice()
        {

        }
        public void SaveToJson(string fileName)
        {
            string jsonString = JsonConvert.SerializeObject(this);
            File.WriteAllText(fileName, jsonString);
        }

        public static Invoice FromJson(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            Invoice obj = JsonConvert.DeserializeObject<Invoice>(jsonString);
            return obj;
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public double TotalPrice
        {
            get { return price; }
            set { price = value; }
        }

        public bool Paid
        {
            get { return paid; }
            set { paid = value; }
        }
    }
}