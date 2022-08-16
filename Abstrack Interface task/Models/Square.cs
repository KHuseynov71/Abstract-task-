using System;
using System.Collections.Generic;
using System.Text;

namespace Abstrack_Interface_task.Models
{
    class Square:Figure
    {
        private double _side;
        public double Side
        {
            get
            {
                return _side;
            }
            set
            {
                if (value>=0)
                {
                    _side = value;
                }
            }
        }
        public Square()
        {

        }
        public Square(double Side)
        {

        }

        public override void CalcArea()
        {
            Console.WriteLine(Side * Side);
        }
    }
}
