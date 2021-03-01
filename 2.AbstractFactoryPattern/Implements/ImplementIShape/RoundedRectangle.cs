using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class RoundedRectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside RoundedRectangle::draw() method.");
        }
    }
}
