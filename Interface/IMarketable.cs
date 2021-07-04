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
        List<SellItem> sellItems { get; set; }
        void AddSell(int sellItemNo, int sellItemcount);
        List<Sell> ReturnSellitem();
        void ReturnSell(int sellNo, string sellitem);
        List<Sell> ReturnAllSells(string selltime, string selltime2);
        List<Sell> ReturnSells(string selltime);
        List<Sell> ReturnValueSells(double value);
        Sell ReturnNoSells(int sellNo);
        void AddProduct(string name, double price, string catagory, string code);
        void EditProduct(int productCode, int newProductCode);
        List<Product> ReturnProduct(string catagory);
        List<Product> ReturnValueProducts(double value1, double value2);
        List<Product> SearchProduct(string productName);



    }
}
