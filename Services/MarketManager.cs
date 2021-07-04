using SecondConsoleApp.Enum;
using SecondConsoleApp.Interface;
using SecondConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.Services
{
    class MarketManager : IMarketable
    {
        List<Product> Products { get; set; }
        List<Product> IMarketable.Products 
        {
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        List<Sell> SoldProduct { get; set; }
        List<Sell> IMarketable.SoldProduct 
        {
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public void AddProduct(string name, double price, Category category, string code)
        {
            throw new NotImplementedException();
        }

        public void SellItem(int sellitemno, Product sellitemproduct, int count)
        {
            throw new NotImplementedException();
        }

        public void AddSell(int SellNo, double Amount, string datetime, SellItem sellItem )
        {
        }

        public void GetSell(int SellNo, SellItem sellItem)
        {
            throw new NotImplementedException();
        }

        public void Sell(byte startday, byte startmonth, int startyear, byte endday, byte endmonth, int endyear, List<Product> SoldProduct)
        {
            throw new NotImplementedException();
        }
    }


}
