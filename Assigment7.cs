using System;
using CSharp;

namespace Assigment2
{
    public class Assigment7
    {
        public static void Main(string[] args)
        {
            CustomerVN v = new CustomerVN();
            CustomerNN n = new CustomerNN();
            int choice;
            do
            {
                Menu();
                do
                {
                    Console.WriteLine("Choose funtion (0/1/2/3/4/5) : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < 0 || choice > 5) Console.WriteLine("Error ! Please choose again !");
                } while (choice < 0 || choice > 5);
                
                switch (choice)
                {
                    case 1:
                        Menu2(v,n);
                        break;
                    case 2:
                        v.showListVN();
                        n.showListNN();
                        break;
                    case 3:
                        v.showListBillCVN();
                        n.showListBillCNN();
                        break;
                    case 4:
                        n.showListMM();
                        break;
                    case 5:
                        v.showListVN();
                        n.showListNN();
                        break;
                    case 0:
                        return;
                }
            } while (choice != 0);
        }

        
        
        public static  void Menu()
        {
            Console.WriteLine("------------------ THE SYSTEM MANAGES THE CUSTOMER ELECTRICITY BILL LIST ------------------");
                Console.WriteLine("1.INPUT INFORMATION LIST.");
                Console.WriteLine("2.SHOW  INFORMATION LIST.");
                Console.WriteLine("3.SHOW BILL TOTAL AMOUNT FOR EACH CUSTOMER.");
                Console.WriteLine("4.SHOW LIST BILL MENIUM OF MONEY CUSTOMER.");
                Console.WriteLine("5.SHOW LIST BILL FROM 01/01/2019 TO NOW .");
                Console.WriteLine("0.Exit");
        }

        public static void Menu2(CustomerVN v,CustomerNN n)
        {
            int c;
            do
            {
                Console.WriteLine("1. CUSTOMER VIETNAMESE");
                Console.WriteLine("2. CUSTOMER NATIONALITY");
                Console.WriteLine("0 .exit");
                do
                {
                    Console.WriteLine("Choose funtion (0/1/2) : ");
                    c = Convert.ToInt32(Console.ReadLine());
                    if (c < 0 || c > 2) Console.WriteLine("Error ! Please choose again !");
                } while (c < 0 || c > 2);

                switch (c)
                {
                    case 1:
                        v.inputCVN();
                        break;
                    case 2:
                        n.inputCNN();
                        break;
                    case 0:
                        return;
                }
            }while (c != 0);
        }
        
    }
}