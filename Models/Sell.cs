using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.Models
{
    class Sell
    {
        public static int Count { get; set; }
        public int sellNo { get; set; }
        public double Amount { get; set; }
        public SellItem sellItem;
        public string Datetime { get; set; }

        public List<Product> SoldProduct;
        public Sell(byte day, byte month, int year, List<Product> SoldProduct) 
        {
            Count++;
            Datetime = day.ToString() + month.ToString() + year.ToString();

        }
    }
    
}
