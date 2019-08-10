using System;

namespace Assigment2
{
    public class News:INews
    {
        public int ID;
        public String Title;
        public String PublishDate;
        public String Author;
        public String Content;
        public float AverageRate;
        

        public News()
        {
            
        }

        public News(int id, string title, string publishDate, string author, string content)
        {
            ID = id;
            Title = title;
            PublishDate = publishDate;
            Author = author;
            Content = content;
            
        }

        

        public int Id
        {
            get => ID;
            set => ID = value;
        }

        public string Title1
        {
            get => Title;
            set => Title = value;
        }

        public string PublishDate1
        {
            get => PublishDate;
            set => PublishDate = value;
        }

        public string Author1
        {
            get => Author;
            set => Author = value;
        }

        public string Content1
        {
            get => Content;
            set => Content = value;
        }

        public float AverageRate1
        {
            get => AverageRate;
            set => AverageRate = value;
        }
        
        public void display()
        {
            int k = 1;
            Console.WriteLine("ID : "+ID);
            Console.WriteLine("Title : "+Title);
            Console.WriteLine("PublishDate : "+PublishDate);
            Console.WriteLine("Author : "+Author);
            Console.WriteLine("Content : "+Content);
            Console.WriteLine("AverageRate : "+AverageRate);
            foreach (int i in RateList)
            {
                Console.WriteLine(k+".( "+i+")");
                k++;
            }
        }
        public int[] RateList = new int [3];

        public int this [int index]
        {
            get => RateList[index];
            set
            {
                if (value >= 1 && value <=5)
                {
                    RateList[index] = value;
                }
                else if (value < 1 )
                {
                    RateList[index] = 1;
                }
                else if (value > 5)
                {
                    RateList[index] = 5;
                }
                
            }
        }
        
        
        

        public void Calculate()
        {
            int n = 0;
            foreach (int i in RateList)
            {
                n = +i;
            }

            AverageRate  = (float) n / 3;
            
        }
    }
}