using Abstrack_Interface_task.Models;
using System;

namespace Abstrack_Interface_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter one of the following");
            Console.WriteLine("1. Square"  );
            Console.WriteLine("2. Rectangular");
            Console.WriteLine("0. Quit");
            double Num = Convert.ToDouble(Console.ReadLine());
            if (Num==1)
            {
                Square a = new Square();
                Console.WriteLine("Please add Side");
                a.Side = Convert.ToDouble(Console.ReadLine());
                a.CalcArea();
            }
            if (Num==2)
            {
                Rectangular a = new Rectangular();
                Console.WriteLine("Please add Length");
                a.Length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please add Width");
                a.Width = Convert.ToDouble(Console.ReadLine());
                a.CalcArea();
            }
            else if (Num==0)
            {

            }
         
        }
    }
}
