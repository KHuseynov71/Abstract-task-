using System;
using System.Collections.Generic;
using System.Text;

namespace Abstrack_Interface_task.Models
{
    class Rectangular:Figure
    {
        private double _width;
        private double _length;
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value>=0)
                {
                    _width = value;
                }
            }
        }
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value >= 0)
                {
                    _length = value;
                }
            }
        }
        public Rectangular()
        {

        }
        public Rectangular(double Width, double Length)
        {

        }
        public override void CalcArea()
        {
            Console.WriteLine(Width*Length);
        }
    }
}
