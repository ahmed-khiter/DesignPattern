using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class FactoryProducer
    {
        public static IAbstractFactory GetAbstractFactory(bool rounded)
        {
            if (rounded)
            {
                return new RoundedShapeFactory();
            }
            else
            {
                return new ShapeFactory();
            }
        }
    }
}
