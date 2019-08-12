using System;
using System.Collections.Generic;

namespace Assigment2
{
    public class Product
    {
        public string ProductID;
        public string Name;
        public double Price;
        public List<Product> listP = new List<Product>();

        public Product()
        {
            
        }
        public Product(string productId, string name, double price)
        {
            ProductID = productId;
            Name = name;
            Price = price;
        }

        public string ProductId
        {
            get => ProductID;
            set => ProductID = value;
        }

        public string Name1
        {
            get => Name;
            set => Name = value;
        }

        public double Price1
        {
            get => Price;
            set => Price = value;
        }

        public void Add()
        {
            Console.WriteLine("Input ID :" );
            string id = Console.ReadLine();
            Console.WriteLine("Input NAME :" );
            string name = Console.ReadLine();
            Console.WriteLine("Input PRICE :" );
            double price = Convert.ToDouble(Console.ReadLine());
            Product pr = new Product(id,name,price);
            listP.Add(pr);
        }

        public void Display()
        {
            int k = 1;
            Console.WriteLine("-------------------- LIST PRODUCT -------------------");
            foreach (Product p in listP)
            {
                Console.WriteLine(k+".");
                Console.WriteLine("Product ID   : " +p.ProductID);
                Console.WriteLine("Product NAME : " +p.Name);
                Console.WriteLine("Price        : $" +p.Price );
                Console.WriteLine();
                k++;
            }
        }

        public void Delete()
        {
            Console.WriteLine("Input ID : ");
            string a = Console.ReadLine();
            bool b = false;
            foreach (Product p in listP)
            {
                if (a.Equals(p.ProductID))
                {
                    listP.Remove(p);
                    Console.WriteLine("Delete success !");
                    b = true;
                    break;
                }
            }

            if (!b)
            {
                Console.WriteLine("Delete failes ! Not find ID !");
            }
        }
    }

    public class main
    {
        public static void Main(string[] args)
        {
            Product p = new Product();
            menu(p);
        }

        public static void menu(Product p)
        {
            int choice;
            do
            {
                Console.WriteLine("------------------ THE SYSTEM MANAGES  PRODUCT ------------------");
                                Console.WriteLine("1.ADD PRODUCT RECORDS.");
                                Console.WriteLine("2.DISPLAY PRODUCT RECORDS.");
                                Console.WriteLine("3.DELETE PRODUCT BY ID.");
                                Console.WriteLine("4.EXIT.");
                                do
                                {
                                    Console.WriteLine("Choose funtion (1/2/3/4) : ");
                                    choice = Convert.ToInt32(Console.ReadLine());
                                    if (choice < 1 || choice > 4) Console.WriteLine("Error ! Please choose again !");
                                } while (choice < 1 || choice > 4);
                                switch (choice)
                                {
                                    case 1:
                                        p.Add();
                                        break;
                                    case 2:
                                        p.Display();
                                        break;
                                    case 3:
                                        p.Delete();
                                        break;
                                    case 4:
                                        return;
                                }
            } while (choice != 4);
        }
    }
}