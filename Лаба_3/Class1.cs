using System;

class Invoice
{
    private readonly int number;
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
    public double Price()//суму отримуємо через властивість тільки для читання
    {
        get { return price; }
    }
}