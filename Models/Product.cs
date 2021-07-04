using SecondConsoleApp.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.Models
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public static int Count { get; set; }
        public string Code { get; set; }

        public Category Categories { get; set; }

        public Product(string name, double price, Category category, string code)
        {
            Name = name;
            Price = price;
            Categories = category;
            Count++;
            Code = Name.ToUpper().Substring(0, 2) + Count.ToString();
        }


        public override string ToString()
        {
            return $"{Name} {Price} {Categories} {Count} {Code}  ";
        }

    }
}
