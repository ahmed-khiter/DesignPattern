using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ShapeFactory : IAbstractFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (shapeType.ToLower() == "rectangle")
            {
                return new Rectangle();
            }
            else if (shapeType.ToLower() == "square")
            {
                return new Square();
            }
            else
            {
                return null;
            }
        }
    }
}
