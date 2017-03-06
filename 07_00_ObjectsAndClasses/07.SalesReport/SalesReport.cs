using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SalesReport
{
    class SalesReport
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];

            int i = 0;
            while (n > 0)
            {
                string[] text = Console.ReadLine().Trim().Split(' ').ToArray();
                sales[i] = ReadSale(text);
                i++;
                n--;
            }

            SortedDictionary<string, double> totalAmoutSales = new SortedDictionary<string, double>();
            for (int j = 0; j < sales.Length; j++)
            {
                if (!totalAmoutSales.ContainsKey(sales[j].Town))
                {
                    totalAmoutSales.Add(sales[j].Town, sales[j].TotalMoney);
                }
                else
                {
                    totalAmoutSales[sales[j].Town] += sales[j].TotalMoney;
                }
            }


            foreach (var item in totalAmoutSales)
            {
                Console.WriteLine($"{item.Key:F2} -> {item.Value:F2}");
            }


        }

        public static Sale ReadSale(string[] saleArray)
        {
            Sale oneSale = new Sale();
            oneSale.Town = saleArray[0];
            oneSale.Product = saleArray[1];
            oneSale.Price = double.Parse(saleArray[2]);
            oneSale.Quantity = double.Parse(saleArray[3]);

            return oneSale;
        }

    }

}
