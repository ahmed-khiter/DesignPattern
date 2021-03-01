using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class RoundedShapeFactory : IAbstractFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (shapeType.ToLower() == "rectangle")
            {
                return new RoundedRectangle();
            }
            else if (shapeType.ToLower() == "square")
            {
                return new RoundedSquare();
            }
            else
            {
                return null;
            }
        }
    }
}
