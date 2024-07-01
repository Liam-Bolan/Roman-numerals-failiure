using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_numerals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] romanchars = { "M", "D", "C", "L", "X", "V", "I" };
            int m = 0;
            int d = 0;
            int c = 0;
            int l = 0;
            int x = 0;
            int v = 0;
            int i2 = 0;
            
            for (int i = 0; i < romanchars.Length; i++)
            {
                if(romanchars[i] == "M")
                {
                    m = 1000;
                }
                if(romanchars[i] == "D")
                {
                    d = 500;
                }
                if (romanchars[i] == "C")
                {
                    c = 100;
                }
                if (romanchars[i] == "L")
                {
                    l = 50;
                }
                if (romanchars[i] == "X")
                {
                    x = 10;
                }
                if (romanchars[i] == "V")
                {
                    v = 5;
                }
                if (romanchars[i] == "I")
                {
                    i2 = 1;
                }
            }


            string romanstring;
            
            int romannum;

            Console.Write("Enter a roman numeral: ");
            romanstring = Console.ReadLine();
            romanstring = romanstring.ToUpper();

            for (int i = 0;i < romanstring.Length; i++)
            {
                for (int j = 0; j < romanchars.Length; j++)
                {
                    if (romanstring[i].ToString() == romanchars[j])
                    {
                        
                    }
                }
            }

            Console.WriteLine($"\nRoman numeral version = {romanstring}");
            Console.ReadLine();


        }
    }
}
