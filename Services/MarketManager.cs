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
        public List<SellItem> sellItems { get; set; }
        public List<Product> Products { get; set; }
        public List<SellItem> SellItem
        { get => throw new NotImplementedException();
          set => throw new NotImplementedException();
        }

        public MarketManager()
        {
            Products = new List<Product>();
            Sells = new List<Sell>();
            sellItems = new List<SellItem>();
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

        public List<Sell> ReturnSellitem()
        {
            return Sells.ToList();
        }
        public void ReturnSell(int sellNo, string sellitemname)
        {
            var sell1 = sellItems.Find(a => a.SellItemNo == sellNo && a.SellitemName == sellitemname);
            Console.WriteLine(sell1.SellitemName, sell1.SellItemNo);
        }

        public List<Sell> ReturnAllSells(string selltime, string selltime2)
        {
            if (string.IsNullOrEmpty(selltime))
                throw new ArgumentNullException("Please enter time");
            if (string.IsNullOrEmpty(selltime2)) throw new ArgumentNullException("there is no time");
            Sell sell5 = Sells.Find(s => s.DateTime == selltime && s.DateTime == selltime2);
            return ReturnAllSells (selltime, selltime2);
        }
    
        public List<Sell> ReturnSells(string selltime)
        {
            Sell sell4 = Sells.Find(a => a.DateTime == selltime);
            return ReturnSells(selltime);
        }

        public List<Sell> ReturnValueSells(double value)
        {
            var sell3 = Sells.Find(a => a.SellPrice == value);

            return Sells.ToList();
        }

        public Sell ReturnNoSells(int sellNo)
        {
            var sell1 = Sells.Find(a => a.SellNo == sellNo);
            return sell1;
        }

        public void AddProduct(string name, double price, string category, string code)
        {
            int temp = 0;
            var categories = Enum.GetValues(Category);
            foreach (var category in categories)
            {
                if (category.ToLower() == category.ToString().ToLower())
                {
                    temp = 1;
                    break;
                }
            }
            if (temp == 0)
                throw new KeyNotFoundException("There is no such category");
            Product product1 = new Product(name, price, category, code);
            Products.Add(product1);

        }//mehsul elave etmek methodu

        public void EditProduct(int productcode, int newproductCode)
        {
            var product1 = Products.Find(a => a.Code == productcode);
            if (product1.Code == productcode)
            {
                productcode = newproductCode;
                Products.Add(product1);


            }
            else
            {
                throw new ArgumentNullException("wrong ProductCode");
            }
        }  //mehsulu editlemek methodu

        public List<Product> ReturnProduct(string catagory)
        {
            var product = Products.Find(d => d.Catagories == catagory);
            return ReturnProduct(catagory);
        }

        public List<Product> ReturnValueProducts(double value1, double value2)
        {
            Product produc = Products.Find(s => s.Price == value1 && s.Price == value2);
            return ReturnValueProducts(value1, value2);
        }

        public List<Product> SearchProduct(string productName)
        {
            if (string.IsNullOrEmpty(productName))
                throw new ArgumentNullException("product name");
            var product = Products.Find(d => d.Name == productName);
            if (product == null) throw new ArgumentNullException("there are no products with the given name");
            return SearchProduct(productName);

        }
        //additional Method
        public void Remove(int productCode)
        {
            if (productCode <= 1000) throw new ArgumentOutOfRangeException("product Code");
            if (Products == null)
                throw new KeyNotFoundException("There are no products with the given code");
            Product product = Products.Find(s => s.Code == productCode);
            Products.Remove(product);
        }


    }
}
