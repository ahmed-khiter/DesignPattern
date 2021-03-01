using AbstractFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public static class AbstractFactoryProgram
    {
        static void Main(string[] args)
        {
            //implelment Abstract Factory pattern.
            IAbstractFactory shapeFactory = FactoryProducer.GetAbstractFactory(false);
            IShape shape1 = shapeFactory.GetShape("rectangle");
            shape1.Draw();

            IShape shape2 = shapeFactory.GetShape("square");
            shape2.Draw();

            IAbstractFactory shapeFactory1 = FactoryProducer.GetAbstractFactory(true);

            IShape shape3 = shapeFactory1.GetShape("rectangle");
            shape3.Draw();

            IShape shape4 = shapeFactory1.GetShape("rectangle");
            shape4.Draw();

        }
    }
}
