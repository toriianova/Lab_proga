using System;
using System.Text;
using Newtonsoft.Json;
using System.IO;
namespace Laba_3
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Invoice inv1 = new Invoice(1, 12300);// створюємо рахунки-фактури
            Invoice inv2 = new Invoice(2);

            Console.WriteLine(inv1);
            Console.WriteLine(inv2);

            inv1.Pay();// оплачуємо перший рахунок

            Console.WriteLine("\nПісля оплати:");
            Console.WriteLine(inv1);

            Console.WriteLine("\nКількість рахунків: " + Invoice.GetInvoiceCount());

            inv1.SaveToJson("invoice1.json");

            Invoice invFromFile = Invoice.FromJson("invoice1.json");

            Console.WriteLine(invFromFile);
        }
    }
}