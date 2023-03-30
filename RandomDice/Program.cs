using System;

namespace RandomDice
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int soman1=0;
            Random rand = new Random();
            Console.WriteLine("Number plz!");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0;i<n;i++){
                int n1=rand.Next(1, 7);
                Console.WriteLine(n1);
                soman1=soman1+n1;

            }
            Console.WriteLine("Total: "+soman1);
        }
    }
}
