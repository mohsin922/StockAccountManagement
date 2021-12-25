using System;
using System.IO;
using Newtonsoft.Json;

namespace StockAccountManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating obj for StockManager
            StockManager stockManager = new StockManager();
            //getting path of json file
            string file = @"C:\Users\MOHSIN ZAHOOR PEER\Desktop\StockAccountManagement\StockAccountManagement\json1.json";
            //Deserialize Json file
            StockUtility stockUtility = JsonConvert.DeserializeObject<StockUtility>(File.ReadAllText(file));
            Console.WriteLine("Enter which operation to perform\n 1-Add a stock\n 2-Remove a stock\n3-Display Stocks");
            int n = Convert.ToInt32(Console.ReadLine());
            var fs = stockUtility.stocksList;
            switch (n)
            {
                case 1:
                    stockManager.AddStock(fs);
                    File.WriteAllText(file, JsonConvert.SerializeObject(stockUtility));
                    stockManager.DisplayStocks(fs);
                    break;
                case 2:
                    stockManager.DeleteInventory(fs);
                    File.WriteAllText(file, JsonConvert.SerializeObject(stockUtility));
                    stockManager.DisplayStocks(fs);
                    break;
                case 3:
                    stockManager.DisplayStocks(fs);
                    Console.Write("\n");
                    break;
            }
        }
    }
}