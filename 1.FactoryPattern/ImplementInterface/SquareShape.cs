using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class SquareShape : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square from SquareShape class");
        }
    }
}
