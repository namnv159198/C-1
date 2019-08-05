using System;
using System.Threading;

namespace T1809E_CSharp
{
    public class LabSession6
    {
        public static void Main(string[] args)
        {
            boom();
        }

        public static void boom()
        {
            for (int i = 9; i >= 0 ; i--)
            {
                
                for (int j = 59; j >= 0; j--)
                {
                    Console.WriteLine(i.ToString(format:"D2") + ":"+j.ToString(format:"D2"));
                    Thread.Sleep(500);
                }
                
            }
            Console.WriteLine("Bum.....! ");
        }
    }
}