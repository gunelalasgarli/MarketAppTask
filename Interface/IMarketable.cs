using SecondConsoleApp.Enum;
using SecondConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.Interface
{
    interface IMarketable
    {
    
            List<Sell> Sells { get; set; }
            List<SellItem> SellItem { get; set; }

            void AddSell(int sellitemno, int sellitemcount);
            SellItem ReturnSellItem(int orderitemno);
            Sell ReturnSell(string orderno, SellItem sellitem);
            List<Sell> ReturnAllSells(string selltime, string selltime2);
            List<Sell> ReturnSells(string selltime);
            List<Sell> ReturnValueSells(double value);
            Sell ReturnNoSell(string sellno);
            void AddProduct(string productname, double productvalue, Category productcategory, int productcount);
            void EditProduct(string productcode, string newproductcode);
            List<Product> ReturnProducts(Category category);
            List<Product> ReturnValueProducts(double value1, double value2);
            List<Product> SearchProducts(string productname);

         
    }
}
