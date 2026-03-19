using System;
using System.Data.Common;

namespace DungeonStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP!");
            
        }
        private static int Damage(int attack, int defense)
        {
            return attack - defense;
        }
        private static int Damage(int attack)
        {
            return attack;
        }
        private static int CriticalHit(int damage)
        {
         
            if (damage<=0)
            {
                return 0;
            }
            else
            {
                return CriticalHit(damage+1);
            }


        }
    }
}
