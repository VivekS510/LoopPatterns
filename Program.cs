using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            int num;
            // Triangle
            Console.WriteLine("Enter the number of lines: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (x = 1; x <= num; x++)      //line number
            {
                for (y = x; y < num; y++)   //Space
                {
                    Console.Write(" ");
                }
                for (z = 1; z < (x * 2); z++)   //Pattern
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            // Left side pattern
            Console.WriteLine("Enter the number of lines: ");
            num = Convert.ToInt32(Console.ReadLine());
            for(x = 1; x <= num; x++)       //on which line number * will be print
            {
                for (y = 1; y <= x; y++)    //how many * will be print
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            // sum of the series
            int n, i, series, sum = 0;
            Console.WriteLine("Input the number of series : ");  //Whichever series want to use
            series = Convert.ToInt32(Console.ReadLine());
            int var = series;  //assigning that series number to temp var
            Console.WriteLine("Input the number of terms : ");  //How many terms you want to sum
            n = Convert.ToInt32(Console.ReadLine());
            
            for (i = 1; i <= n; i++)    //Loop for n number
            {
                Console.Write(series +" + "); //print series
                sum = sum + series; //sum of series
                series = (series * 10) + var; //next step
            }
            Console.WriteLine("The Sum is : " +sum);
            Console.ReadLine();


            int start, end, j, k, flag;

            Console.WriteLine("Enter start point: ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter end point: ");
            end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime numbers between " +
                              "{0} and {1} are: ", start, end);

            for (j = start; j <= end; j++) // checking each numbers
            {
                if(j == 0 || j == 1)    //skip if j=0 or 1
                continue;

                flag = 1;   // set flag to 1

                for (k = 2; k <= j / 2; ++k) 
                {
                    if (j % k == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                if (flag == 1)
                    Console.Write(" " +j);
            }
            Console.ReadLine();
        }
    }
}
