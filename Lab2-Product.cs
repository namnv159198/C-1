using System;
using System.Collections;
using System.Collections.Generic;

namespace SESSION_2
{
    public class Product
    {
        public string id,name;
        public double price;
        public string image;
        public string desc;
        public int qty;
        public List <string> gallery = new List<string>();
        public Product()
        {
            
        }

        public Product(string id, string name, double price, int qty,string image, string desc,List<string> gallery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = gallery;
        }

        
        
        public void getInfor()
        {
            int k = 1;
            Console.WriteLine("ID : "+id);
                Console.WriteLine("Name : "+name);
                Console.WriteLine("Price : "+price);
                Console.WriteLine("Price : " + qty);
                Console.WriteLine("Image : "+image);
                Console.WriteLine("Desc: " + desc);
                Console.WriteLine("Gallery : ");
                foreach (var p in gallery)
                {
                    Console.WriteLine(k+"."+p);
                    k++;
                }
                Console.WriteLine();
            
        }

        public void thongBao()
        {
            if (qty > 0)
            {
                Console.WriteLine("Con hang ");
            }else
                Console.WriteLine("Het hang");
        }

        public void themAnh()
        {
            string n;
            if (gallery.Count > 10)
            {
                Console.WriteLine("KHONG THE THEM ANH VI DA DU 10 TAM ! NEU MUON THEM HAY XOA BOT");
            }
            else
            {
                Console.WriteLine("Nhap anh : ");
                n = Console.ReadLine();
                gallery.Add(n);
            }
            
            Console.WriteLine("---------------");
            
        }

        public void xoaAnh()
        {
            Console.WriteLine("Nhap vi tri can xoa  anh : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < gallery.Count; i++)
            {
                if (n == i)
                {
                    gallery.RemoveAt(i-1);
                }
            }
            Console.WriteLine();
        }
        
        
    }
}