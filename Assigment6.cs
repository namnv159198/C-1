using System;
using System.Threading;

namespace T1809E_CSharp
{
    public class Assigment6
    {
        private static bool stop = false;
        public static void Main(string[] args)
        {
            Console.WriteLine("input : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Thread t1 = new Thread(time);
            Thread t = new Thread(Fibonacci);
            t1.Start();
            t.Start(n);
        }

        public static void time()
        {
            for (int i = 0 ; i >=0; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    Console.WriteLine(i.ToString(format:"D2") +":"+j.ToString(format:"D2") );
                    Thread.Sleep(200);
                    if (stop) break;
                }
                if (stop) break;
            }
        }
        public static void Fibonacci(object o)
        {
            int n = (int) o;
            int m1 = 1, m2 = 1, m3 = 2;
            for (int i = 0; m1+m2 < n; i++)
            {
                m3 = m1 + m2;
                m1 = m2;
                m2 = m3;
                Console.WriteLine(m3);
                Thread.Sleep(100);
                
            }

            stop = true;
        }
    }
}