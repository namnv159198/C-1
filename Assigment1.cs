using System;

namespace T1809E_CSharp
{
    public class Assigment1
    {
        public static void Main(string[] args)
        {
            int x1 = 1, x2 = 1, x3 = 2;
            int n;
            
         
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1 || n == 2) Console.WriteLine("So thu " + n + " trong  day fibonaci la :" + x1);
            if (n == 3) Console.WriteLine("So thu " + n + " trong  day fibonaci la :" + x3);

            if (n >=4)
            {
                for (int i = 4; i <= n ; i++)
                {
                
                    x3 = x1 + x2;
                    x1 = x2;
                    x2 = x3;
                    
                }
                Console.WriteLine("So thu " +n+" trong  day fibonaci la :" +x3);
            }
            
            
        } 
    }
}