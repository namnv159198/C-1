using System;

namespace SESSION_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Product p = new Product();
            p.id = "ID-1";
            p.name = "Tu lanh";
            p.price = 102.20;
            p.qty = 10;
            p.image = "anh_1";
            p.desc = "Binh thuong";
            p.gallery.Add("anh_ID-1.png");
            p.gallery.Add("and_ID-1.2.jpg");
            int choice;
            do {            
                Console.WriteLine("\n-------------------------Menu-------------------------");
                Console.WriteLine("1.Kiem tra hang");
                Console.WriteLine("2.Them anh");
                Console.WriteLine("3.Xoa anh");
                Console.WriteLine("4.Hien thi thong tin san pham");
                Console.WriteLine("0.Exit");
                do {            
                    Console.WriteLine("Nhập các số để chọn từng chức năng (1/2/3/4/0) : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < 0 || choice > 6) {
                        Console.WriteLine("Nhập sai ! xin hãy nhập lại");
                    }
                } while (choice < 0 || choice > 6);           
                switch (choice){
                    case 1:
                        Console.WriteLine("Bạn đã chọn chức năng Kiem tra hang ");
                        p.thongBao();
                        break;
                    case 2 :
                        Console.WriteLine("Bạn đã chọn chức năng Them anh");
                        p.themAnh();
                        break;
                    case 3 :
                        Console.WriteLine("Bạn đã chọn chức năng Xoa anh ");
                        p.xoaAnh();
                        break;
                    case 4 :
                        Console.WriteLine("Bạn đã chọn chức năng Hien thi thong tin san pham :");
                        Console.WriteLine();
                        p.getInfor();
                        break;
        
                    case 0 :
                        Console.WriteLine("Bạn đã chọn chức năng thoát chương trình ! Tạm biệt");
                        return;
               
                }
            
            } while (choice != 0);

        }
    }
}