using System;
using System.Data.Common;
using Spectre.Console;

namespace DungeonStats
{
    public class Program
    {
       
        private static void Main(string[] args)
        {
            var table = new Table();
            table.AddColumn("Operation");
            table.AddColumn("Result");

            
            string value=Console.ReadLine();
            int valueint=Int32.Parse(value);
            int value2int=2;
            
            Damage(valueint,value2int);
            Damage(valueint);
            CriticalHit(valueint);

            table.AddRow("Damage",value);
            table.AddRow("Damage", value);
            table.AddRow("CriticalHit", value);
            AnsiConsole.Write(table);
            
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
