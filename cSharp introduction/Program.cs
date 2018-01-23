using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            double Input;

            //input
            Console.WriteLine("Please enter a number! Like now!");
            //Input = Convert.ToInt32(Console.ReadLine());
            Input = double.Parse(Console.ReadLine());

            //processing

            Input = Math.Sqrt(Input);

            //output

            //Console.WriteLine("Output is equal to: "+Input);
            Console.WriteLine($"Output is equal to {Input}");


        }
    }
}
