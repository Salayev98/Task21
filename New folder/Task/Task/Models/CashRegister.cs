using System;
using System.Collections.Generic;
using System.Text;
using Task.Enums;

namespace Task.Models
{
    class CashRegister
    {
        public static double TotalAmount = 100;
        public Currency Currency;
        public static int TotalSalesCount = 0;
        public PaymentType PaymentType;

        public CashRegister(Currency cashcurrency, PaymentType paymentType)
        {
            Currency = cashcurrency;
            PaymentType = paymentType;
        }
        public void AddSell(Currency currency, double newsale)
        {
            if (Currency!=currency)
            {
                if (Currency.Azn == currency)
                {
                    TotalAmount += newsale / 1.70;
                }
                else if (Currency.Usd == currency)
                {
                    TotalAmount += newsale * 1.70;
                }
            }
            else
            {
                TotalAmount += newsale;
            }
            Console.WriteLine(TotalAmount);
            TotalSalesCount++;
            
        }
        public void RemoveSell(Currency currency, double newsale)
        {
            if (Currency != currency)
            {
                if (Currency.Azn == currency)
                {
                    TotalAmount -= newsale / 1.70;
                }
                else if (Currency.Usd == currency)
                {
                    TotalAmount -= newsale * 1.70;
                }
            }
            else
            {
                TotalAmount -= newsale;
            }
            Console.WriteLine(TotalAmount);
            TotalSalesCount--;

        }
    }
}
