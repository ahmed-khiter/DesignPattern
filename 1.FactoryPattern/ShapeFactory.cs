using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }

            if (shapeType.ToLower() == "circle")
            {
                return new CircleShape();
            }
            else if (shapeType.ToLower() == "square")
            {
                return new SquareShape();
            }
            else if (shapeType.ToLower() == "rectangle")
            {
                return new RectangleShape();
            }
            else
            {
                return null;
            }
        }
    }
}
