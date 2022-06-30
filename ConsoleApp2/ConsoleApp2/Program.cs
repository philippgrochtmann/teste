using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
            Console.ReadLine();
            int tempo = 5;

        }
        
        static int Points(int levels)
        {
            if (levels == 1)
            {
                return 1;
            }
            else
            {
                return levels + Points(levels - 1);
            }
            


            

        }

        

    }



}
