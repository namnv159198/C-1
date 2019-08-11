using System;
using System.Collections.Generic;

namespace CSharp
{
    public class CustomerVN : Customer 
    {
        public string listCustomer;
        public double limitConsume;
        public double bill;
        public List<CustomerVN> listVN = new List<CustomerVN>();

        public CustomerVN()
        {
            
        }
        public CustomerVN(string id,string name,DateTime dateBill,string listCustomer,int qty,double money, double limitConsume)
        {
            this.id = id;
            this.name = name;
            this.dateBill = dateBill;
            this.listCustomer = listCustomer;
            this.qty = qty;
            this.money = money;
            this.limitConsume = limitConsume;
        }
        public CustomerVN(string listCustomer, double limitConsume)
        {
            this.listCustomer = listCustomer;
            this.limitConsume = limitConsume;
        }
        
        
        public string ListCustomer
        {
            get => listCustomer;
            set => listCustomer = value;
        }

        public double Consume
        {
            get => limitConsume;
            set => limitConsume = value;
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
        

        
        public double billTotal(CustomerVN c)
        {
            
            if (c.qty <= c.limitConsume)
            {
                bill = c.qty * c.money;
            }
            else
            {
                bill = c.money * (c.limitConsume + (c.qty - c.limitConsume)) * Limit(c.limitConsume);
            }

            return bill;
        }

        public void inputCVN()
        {
            string id, name, listCustomer = null;
            int qty,choice, day, month, year;
            double consume, money;
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
            do{
                Console.WriteLine("Choose Customer : ");
                Console.WriteLine("1.Family ");
                Console.WriteLine("2.Bussines ");
                Console.WriteLine("3.Produce ");
            do{
                Console.WriteLine("Input chose list customer (1/2/3) : ");
                 choice = Convert.ToInt32(Console.ReadLine());
                
                if (choice < 1 || choice > 3) {
                    Console.WriteLine("Error ! Please input again ! ");
                }
            }while (choice < 1 || choice >3);
             
            switch(choice){
                case 1:
                    listCustomer = "Family";
                    break;
                case 2:
                    listCustomer = "Bussines";
                    break;
                case 3:
                    listCustomer = "Produce";
                    break;
            }
            break;
        }while(choice != 1 || choice != 2 || choice != 3);
            
            Console.WriteLine("Input quatity : ");
            qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input money : ");
            money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input consume : ");
            consume = Convert.ToDouble(Console.ReadLine());
            
            CustomerVN V = new CustomerVN(id,name,dateBill,listCustomer,qty,money,consume);
            listVN.Add(V);
            
        }


        public void showListVN()
        {
            Console.WriteLine("---------------------- LIST CUSTOMER VN ----------------------");
            int k = 1;
            foreach (CustomerVN v in listVN)
            {
                Console.WriteLine("------------------ Number " +k+" ------------------");
                Console.WriteLine("ID : " +v.Id);
                Console.WriteLine("Name : "+ v.name);
                Console.WriteLine("Date of output bill : {0:d}", v.dateBill);
                Console.WriteLine("Customer  type: "+ v.listCustomer);
                Console.WriteLine("Quatity : "+ v.qty);
                Console.WriteLine("Unit price : "+ v.money);
                Console.WriteLine("Consume : "+ v.limitConsume);
                k++;
            }
        }

        public void showListBillCVN()
        {
            Console.WriteLine("---------------------- LIST CUSTOMER BILL VN ----------------------");
            int k = 1;
            foreach (CustomerVN v in listVN)
            {
                Console.WriteLine("------------------ Number " +k+" ------------------");
                Console.WriteLine("ID : " +v.Id);
                Console.WriteLine("Name : "+ v.name);
                Console.WriteLine("Date of output bill : {0:d}", v.dateBill);
                Console.WriteLine("Customer  type: "+ v.listCustomer);
                Console.WriteLine("Money Total : "+billTotal(v));
                k++;
            }
        }
        
        public void showList012019vN()
        {
            DateTime day01012019 = new DateTime(2019,01,01);
           
            Console.WriteLine("---------------------- LIST CUSTOMER BILL NATIONALITY ----------------------");
            int k = 1;
            foreach (CustomerVN v in listVN)
            {
                if (DateTime.Compare(v.dateBill,day01012019) >= 0 )
                {
                    Console.WriteLine("------------------ Number " +k+" ------------------");
                    Console.WriteLine("ID : " +v.Id);
                    Console.WriteLine("Name : "+ v.name);
                    Console.WriteLine("Date of output bill : {0:d}", v.dateBill);
                    Console.WriteLine("Customer  type: "+ v.listCustomer);
                    Console.WriteLine("Money Total : "+billTotal(v));
                    k++;
                }
            }
        }
        
        
        
    }
}