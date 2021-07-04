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
        public int SellNo { get; set; }
        public double Amount { get; set; }
        public SellItem SellItem;
        private List<SellItem> sellItem;

        public string Datetime { get; set; }
       
        public List<Sell> SoldProduct { get; set; }
        public Sell(byte day, byte month, int year, List<Product> SoldProduct) //sell methodu ucun lazim olunanlarr elave edildi
        {
            Count++;
            Datetime = day.ToString() + month.ToString() + year.ToString();
            SoldProduct = new List<Product>();
        }

        public Sell(List<SellItem> sellItem)
        {
            this.sellItem = sellItem;
        }
    }
    
}
