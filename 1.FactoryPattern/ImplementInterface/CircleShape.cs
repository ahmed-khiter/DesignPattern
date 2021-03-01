using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class CircleShape : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle from circle shape class");
        }
    }
}
