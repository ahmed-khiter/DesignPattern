using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class RectangleShape : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle Shape Class");
        }
    }
}
