using System;
using System.Collections.Generic;
using CSharp;

namespace Assigment2
{
    public class CustomerNN : Customer
    {
        public string nationality;
        public double bill;
        public List<CustomerNN> listNN = new List<CustomerNN>();
        public CustomerNN(string id,string name,DateTime dateBill,string nationality,int qty,double money)
        {
            this.id = id;
            this.name = name;
            this.dateBill = dateBill;
            this.nationality = nationality;
            this.qty = qty;
            this.money = money;
        }

        public CustomerNN()
        {
            
        }

        public string Nationality
        {
            get => nationality;
            set => nationality = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public DateTime DateBill
        {
            get => dateBill;
            set => dateBill = value;
        }

        public int Qty
        {
            get => qty;
            set => qty = value;
        }

        public double Money
        {
            get => money;
            set => money = value;
        }

        public CustomerNN(string nationality)
        {
            this.nationality = nationality;
        }

       public void inputCNN()
       {
           string id, name, listCustomer = null, nationality;
            int qty, day, month, year;
            
            double  money;
            Console.WriteLine("Input ID : ");
            id = Console.ReadLine();
            Console.WriteLine("Input Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Input date  : ");
            Console.WriteLine("day :");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("month :");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("year :");
            year = Convert.ToInt32(Console.ReadLine());
            DateTime dateBill =  new DateTime(year,month,day);
            Console.WriteLine("Input nationality :");
            nationality = Console.ReadLine();
            Console.WriteLine("Input quatity : ");
            qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input money : ");
            money = Convert.ToDouble(Console.ReadLine());
            CustomerNN n = new CustomerNN(id,name,dateBill,nationality,qty,money);
            listNN.Add(n);
       }
       
       public void showListNN()
       {
           Console.WriteLine("---------------------- LIST CUSTOMER NATIONALITY ----------------------");
           int k = 1;
           foreach (CustomerNN v in listNN)
           {
               Console.WriteLine("------------------ Number " +k+" ------------------");
               Console.WriteLine("ID : " +v.Id);
               Console.WriteLine("Name : "+ v.name);
               Console.WriteLine("Date of output bill : {0:d}", v.dateBill);
               Console.WriteLine("Nationality: "+ v.nationality);
               Console.WriteLine("Quatity : "+ v.qty);
               Console.WriteLine("Unit price : "+ v.money);
               Console.WriteLine("Consume : 2000");
               k++;
           }
       }
       public double billTotal(CustomerNN c)
       {
           if (c.qty <= 2000)
           {
               bill = c.qty * c.Money;
           }
           else
           {
               bill = c.money * (2000 + (qty - 2000)) * 2000;
           }
           return bill;
       }
       public void showListBillCNN()
       {
           Console.WriteLine("---------------------- LIST CUSTOMER BILL NATIONALITY ----------------------");
           int k = 1;
           foreach (CustomerNN v in listNN)
           {
               Console.WriteLine("------------------ Number " +k+" ------------------");
               Console.WriteLine("ID : " +v.Id);
               Console.WriteLine("Name : "+ v.name);
               Console.WriteLine("Date of output bill : {0:d}", v.dateBill);
               Console.WriteLine("Nationality: "+ v.nationality);
               Console.WriteLine("Money Total : "+billTotal(v));
               k++;
           }
       }

       public void showListMM()
       {
           double t = 0;
           int k = 0;
           foreach (CustomerNN n in listNN)
           {
               t = + billTotal(n);
               k++;
           }
           Console.WriteLine("Medium money of customer nationality : "+ (double)(t/k));
       }

       public void showList012019NN()
       {
           DateTime day01012019 = new DateTime(2019,01,01);
           
           Console.WriteLine("---------------------- LIST CUSTOMER BILL NATIONALITY ----------------------");
           int k = 1;
           foreach (CustomerNN v in listNN)
           {
               if (DateTime.Compare(v.dateBill,day01012019) >= 0 )
               {
                   Console.WriteLine("------------------ Number " +k+" ------------------");
                   Console.WriteLine("ID : " +v.Id);
                   Console.WriteLine("Name : "+ v.name);
                   Console.WriteLine("Date of output bill : {0:d}", v.dateBill);
                   Console.WriteLine("Nationality: "+ v.nationality);
                   Console.WriteLine("Money Total : "+billTotal(v));
                   k++;
               }
           }
       }
        
    }
}