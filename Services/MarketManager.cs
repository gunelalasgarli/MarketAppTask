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
        public List<Sell> Sells { get; set; }
        public List<SellItem> Sellitem { get; set; }
        List<Product> Products { get; set; }
        public List<SellItem> SellItem 
        {
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public MarketManager()
        {
            Sells = new List<Sell>();
            Products = new List<Product>();


        }


        public void AddSell(int sellitemno, int sellitemcount)
        {


            var sellItem = SellItem.Find(s => s.SellItemNo == sellitemno && s.SellItemCount == sellitemcount);
            if (sellitemno <= 0 || sellitemcount <= 0)
            {
                throw new ArgumentNullException("sellitem not found");
            }
            else
            {
                Sell sell = new Sell(SellItem);
                Sells.Add(sell);
            }


        }//satish elave etmek methodu

        public SellItem ReturnSellItem(int sellitemno)
        {
            throw new NotImplementedException();
        }

        public Sell ReturnSell(string sellno, SellItem sellItem)
        {
            throw new NotImplementedException();
        }

        public List<Sell> ReturnAllSells(string ordertime, string ordertime2)
        {
            throw new NotImplementedException();
        }

        public List<Sell> ReturnSells(string selltime)
        {
            throw new NotImplementedException();
        }

        public List<Sell> ReturnValueSells(double value)
        {
            throw new NotImplementedException();
        }

        public Sell ReturnNoSells(string orderno)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(string productname, double productvalue, Category productcategory, int productcount)
        {
            Product whiskey = new Product(productname, productvalue, productcategory, productcount);
            Products.Add(whiskey);



        }//mehsul elave etmek methodu

        public void EditProduct(string productcode, string newproductcode)
        {
            Product product = Products.Find(s => s.ProductCode == productcode);
            if (product.ProductCode == productcode)
            {
                productcode = newproductcode;
            }
            else
            {
                throw new NullReferenceException();
            }


        }//mehsulu editlemek methodu

        public List<Product> ReturnProducts(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Product> ReturnValueProducts(double value1, double value2)
        {
            throw new NotImplementedException();
        }

        public List<Product> SearchProducts(string productname)
        {
            throw new NotImplementedException();
        }


        public void RemoveProduct(string productcode)
        {
            foreach (Product item in Products)

                if (item.ProductCode == productcode)
                {
                    Products.Remove(item);
                }

        }//mehsul silmek methodu

        public Sell ReturnNoSell(string sellno)
        {
            throw new NotImplementedException();
        }
    }
}
