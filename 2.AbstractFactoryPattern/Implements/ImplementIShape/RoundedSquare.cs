using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class RoundedSquare : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside RoundedSquare::draw() method.");
        }
    }
}
