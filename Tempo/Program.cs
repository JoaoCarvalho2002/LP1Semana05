using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    class Program
    {

        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();
            crono1.Start();
            Thread.Sleep(500);
            crono2.Start();
            Thread.Sleep(300);
            crono1.Stop();
            crono2.Stop();
            TimeSpan cro1 = crono1.Elapsed;
            TimeSpan cro2 = crono2.Elapsed;
            Console.WriteLine(cro1);
            Console.WriteLine(cro2);
        }

    }
}
