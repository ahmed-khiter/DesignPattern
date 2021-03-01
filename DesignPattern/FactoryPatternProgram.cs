using FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class FactoryPatternProgram
    {
        static void Main(string[] args)
        {
            //implelment Factory pattern.

            ShapeFactory shapeFactory = new ShapeFactory();

            IShape shape1 = shapeFactory.GetShape("square");
            shape1.Draw();

            IShape shape2 = shapeFactory.GetShape("rectangle");
            shape2.Draw();

            IShape shape3 = shapeFactory.GetShape("circle");
            shape3.Draw();

        }
    }
}
