using System;
using System.Text;

using System.Text.RegularExpressions;

namespace UpperUnion
{
    class Program
    {
        static void Main(string[] args)
        {
          
          if (args.Length== 0){
              Console.WriteLine("NO ARGUMENTS");


          }else{
              Array.Sort(args);
              foreach(string i in args){
              string word= i.ToUpper();

              

              Console.Write(word);
              

          }





          }
         





        }
    }
}
