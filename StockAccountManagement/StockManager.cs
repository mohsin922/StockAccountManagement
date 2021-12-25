using System;
using System.Collections.Generic;
using System.Text;
using static StockAccountManagement.StockUtility;

namespace StockAccountManagement
{
    class StockManager
    {
        int totalshare;
        //Display Stock Details
        public void DisplayStocks(List<Stocks> stocksList)
        {
            Console.WriteLine("DISPLAY STOCK DETAILS :");
            foreach (var i in stocksList)
            {
                Console.WriteLine("Stock name is: {0} \nStock share is: {1} \nStock Price is: {2}", i.StockName, i.shares, i.Price);
                int temp = i.shares * i.Price;
                totalshare += temp;
                Console.WriteLine("Total stock price for {0} is : {1}", i.StockName, temp);
            }
            Console.WriteLine("Total stock pice is : {0}", totalshare);
            

        }
        public void AddStock(List<Stocks> stocks)
        {
            Stocks stocks1 = new Stocks();
            Console.WriteLine("Enter the stock name: ");
            stocks1.StockName = Console.ReadLine();
            Console.WriteLine("Enter number of shares ");
            stocks1.shares = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the stock price: ");
            stocks1.Price = Convert.ToInt32(Console.ReadLine());
            stocks.Add(stocks1);
        }
        public void DeleteInventory(List<Stocks> stocks)
        {
            Console.WriteLine("Enter the stock name to be deleted: ");
            string temp = Console.ReadLine();
            stocks.Remove(stocks.Find(result => result.StockName.Equals(temp)));
        }
    }
}