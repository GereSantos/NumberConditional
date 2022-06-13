using System;

namespace Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Descobrir se o número é Impar ou par
            int n = int.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }
        }
    }
}
