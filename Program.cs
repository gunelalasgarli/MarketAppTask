using SecondConsoleApp.Models;
using SecondConsoleApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product product1 = new Product("millasud", 1.89, Enum.Category.dairy, "MI");
            //Product product2 = new Product("millasud", 1.89, Enum.Category.dairy, "MI");
            //Product product3 = new Product("millasud", 1.89, Enum.Category.dairy, "MI");

            //Console.WriteLine(product3);
            //Console.WriteLine(product2); 
            //Console.WriteLine(product1);

            MarketManager em = new MarketManager();


            string answer;

            do
            {
                Console.WriteLine("\n-------------------------------------------\n");



                Console.WriteLine("1 ");
                Console.WriteLine("1 - Make an application on Products ");
                Console.WriteLine("2 - Make an application on Sells");
                Console.WriteLine("3 - Exit");
                Console.WriteLine("1.1 ");
                Console.WriteLine("1 - Add new product ");
                Console.WriteLine("2 - Edit product");
                Console.WriteLine("3 - Remove product");
                Console.WriteLine("4 - Show all products");
                Console.WriteLine("5 - Show products by categories");
                Console.WriteLine("6 - Show products by price");
                Console.WriteLine("7 - Search by name");



            }
            }
   
    }
}
