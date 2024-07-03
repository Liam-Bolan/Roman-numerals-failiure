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
            string romanstring;
            int romannum = 0;

            Console.Write("Enter a roman numeral: ");
            romanstring = Console.ReadLine();
            romanstring = romanstring.ToUpper();



            for (int i = 0; i < romanstring.Length; i++)
            {
                if (i < romanstring.Length-1)
                {
                    
                    if (romanstring[i] == 'I' && romanstring[i + 1] == 'V')
                    {
                        romannum -= 6;
                        romannum += 4;
                    }
                    if (romanstring[i] == 'I' && romanstring[i + 1] == 'X')
                    {
                        romannum -= 11;
                        romannum += 9;
                    }
                    if (romanstring[i] == 'X' && romanstring[i + 1] == 'L')
                    {
                        romannum -= 60;
                        romannum += 40;
                    }
                    if (romanstring[i] == 'X' && romanstring[i + 1] == 'C')
                    {
                        romannum -= 110;
                        romannum += 90;
                    }
                    if (romanstring[i] == 'C' && romanstring[i + 1] == 'D')
                    {
                        romannum -= 600;
                        romannum += 400;
                    }
                    if (romanstring[i] == 'C' && romanstring[i + 1] == 'M')
                    {
                        romannum -= 1100;
                        romannum += 900;
                    }
                }
                
                if (romanstring[i] == 'M')
                {
                    romannum += 1000;
                }
                if (romanstring[i] == 'D')
                {
                    romannum += 500;
                }
                if (romanstring[i] == 'C')
                {
                    romannum += 100;
                }
                if (romanstring[i] == 'L')
                {
                    romannum += 50;
                }
                if (romanstring[i] == 'X')
                {
                    romannum += 10;
                }
                if (romanstring[i] == 'V')
                {
                    romannum += 5;
                }
                if (romanstring[i] == 'I')
               {
                    romannum += 1;
                }
            }
                Console.WriteLine($"\nRoman numeral version = {romanstring}");
                Console.WriteLine($"\nRoman number is {romannum}");
                Console.ReadLine();
            
        }
    }
}
            
    

