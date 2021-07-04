using SecondConsoleApp.Models;
using SecondConsoleApp.Services;
using System;

namespace Market_console_app
    {
        class Program
        {
            static void Main(string[] args)
            {
                MarketManager m1 = new MarketManager();


                string answer;
                string answer1;

                do
                {
                    Console.WriteLine("\n-------------------------------------------\n");


                    Console.WriteLine("1   - Use Products Operations");
                    Console.WriteLine("2   - Use Order Oper=ations");
                    Console.WriteLine("3   - Exit");

                    Console.WriteLine("\n Use appropriate choice. :");
                    answer = Console.ReadLine();

                    do
                    {
                        switch (answer)
                        {
                            case "1":
                                Console.WriteLine("1.1 - Add new product ");
                                Console.WriteLine("1.2 - Edit product");
                                Console.WriteLine("1.3 - Remove product");
                                Console.WriteLine("1.4 - Show all products");
                                Console.WriteLine("1.5 - Show products by categories");
                                Console.WriteLine("1.6 - Show products by price");
                                Console.WriteLine("1.7 - Search by name");
                                answer1 = Console.ReadLine();
                                switch (answer1)
                                {

                                    case "1.1":
                                        AddOrder(m1);
                                        break;
                                    case "1.2":
                                        EditProduct(m1);
                                        break;
                                    case "1.3":
                                        RemoveProduct(m1);
                                        break;
                                }
                                break;
                        }



                    } while (answer != "1");

                } while (answer != "3");


            }
            static void AddOrder(MarketManager m1)
            {
                Console.WriteLine("Enter sell product Number");
                int sellitemno = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter sell product Count");
                int sellitemcount = int.Parse(Console.ReadLine());
                m1.AddSell(sellitemno, sellitemcount);
            }
            static void EditProduct(MarketManager m1)
            {
                Console.WriteLine("Enter the product code");
                string productcode = Console.ReadLine();
                Console.WriteLine("Enter new product code");
                string newproductcode = Console.ReadLine();
                m1.EditProduct(productcode, newproductcode);
            }

            static void RemoveProduct(MarketManager m1)
            {
                Console.WriteLine("Enter the Product you want to remove");
                string productcode = Console.ReadLine();

                m1.RemoveProduct(productcode);


            }
            static void ShowAllProducts()
            {

            }
        }
    }

