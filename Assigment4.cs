using System;
using System.Collections.Generic;

namespace T1809E_CSharp
{
    public class Assigment4
    {
        public static void Main(string[] args)
        {
            
            List<PhoneBook> PhoneList = new List<PhoneBook>();
           
            int choice;
                
            do {            
                Console.WriteLine("\n-------------------------Menu-------------------------");
                Console.WriteLine("1. Insert Phone");
                Console.WriteLine("2. View list news");
                Console.WriteLine("3. Remove Phone");
                Console.WriteLine("4. Update Phone");
                Console.WriteLine("5. Search  Phone");
                Console.WriteLine("0. Exit");
                do {            
                    Console.WriteLine("Input choice number menu (1/2/3/4/5/0) : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < 1 || choice > 5) {
                        Console.WriteLine("Error ! Please choose again !");
                    }
                } while (choice < 1 || choice > 5);          
        
         
                switch (choice){
          
                    case 1: 
                        InsertPhone(PhoneList);
                        break;
                    case 2:
                        viewListPhone(PhoneList);
                        break;
                    case 3 :
                        RemovePhone(PhoneList);
                        break;
                    case 4:
                        updatePhone(PhoneList);
                        break;
                    case 5:
                        searchPhone(PhoneList);
                        break;
                    case 0 :
                    {
                        return;
                    }
                }
            
            } while (choice != 0);
             
      
        
        }
        

        static void viewListPhone(List<PhoneBook> list)
        {
            Console.WriteLine("------------------------List Phone------------------------");
            foreach (PhoneBook p in list)
            {
                p.viewPhone();
            }
        }

        static void InsertPhone(List<PhoneBook> list)
        {
            Console.WriteLine("Input Phonenumber ");
            Console.WriteLine("Input Name : ");
            string n = Console.ReadLine();
            Console.WriteLine("Input Phone : ");
            string m = Console.ReadLine();
            foreach (PhoneBook p in list)
            {
                if (p.insertPhone(n, m) )
                {
                    list.Add(p);
                }
            }
            
            
            
        }

        static void RemovePhone(List<PhoneBook> list)
        {
            Console.WriteLine("------------------------List Phone------------------------");
            foreach (PhoneBook p in list)
            {
                p.viewPhone();
            }
            Console.WriteLine("Input remove name : ");
            String n = Console.ReadLine();
            foreach (PhoneBook p in list)
            {
                p.removePhone(n);
            }
        }

        static void updatePhone(List<PhoneBook> list)
        {
            Console.WriteLine("Input Update Name :");
            string n = Console.ReadLine();
            Console.WriteLine("Input Update phone :");
            string m = Console.ReadLine();
            foreach (PhoneBook p in list)
            {
                p.updatePhone(n,m);
                p.viewPhone();
            }
        }

        static void searchPhone(List<PhoneBook> list)
        {
            Console.WriteLine("Input Search Name :");
            string n = Console.ReadLine();
            
            foreach (PhoneBook p in list)
            {
                p.searchPhone(n);
                p.viewPhone();
            }
        } 
        
        }
    }
