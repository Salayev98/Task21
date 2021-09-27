using System;
using Task.Enums;
using Task.Models;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kassa mezennesin secin : ");
            foreach (var item in Enum.GetValues(typeof(Currency)))
            {
                Console.WriteLine($"{(int)item} {item}");
            }
            string cashcurency = Console.ReadLine();
            int cashcurrencyint;
            while (!int.TryParse(cashcurency, out cashcurrencyint))
            {
                Console.Write("1-2 araliqinda secim et: ");
                cashcurency = Console.ReadLine();
            }
            Currency cashcurrency = (Currency)cashcurrencyint;
            Console.Write("Aliw Elave edin: ");
            string satiwdeyeri = Console.ReadLine();
            double satiwdeyerii;
            while (!double.TryParse(satiwdeyeri, out satiwdeyerii))
            {
                Console.Write("Reqem daxil et: ");
                satiwdeyeri = Console.ReadLine();
            }
            Console.WriteLine("Mezenneni sec: ");
            foreach (var item in Enum.GetValues(typeof(Currency)))
            {
                Console.WriteLine(item);
            }
            
            string curency = Console.ReadLine();
            int currencyint;
            while (!int.TryParse(curency,out currencyint))
            {
                Console.Write("1-2 araliqinda secim et");
                curency = Console.ReadLine();
            }
            Currency currency = (Currency)currencyint;
            Console.WriteLine("Aliwi nece edeceksiniz sec: ");
            foreach (var item in Enum.GetValues(typeof(PaymentType)))
            {
                Console.WriteLine($"{(int)item} {item}");
            }
            string aliw = Console.ReadLine();
            int aliwint;
            while (!int.TryParse(aliw, out aliwint))
            {
                Console.Write("1-2 araliqinda secim et");
                aliw = Console.ReadLine();
            }
            PaymentType paymenttype = (PaymentType)aliwint;
            CashRegister Market = new CashRegister( cashcurrency, paymenttype);

            Market.AddSell(currency, satiwdeyerii);
        }
    }
}
