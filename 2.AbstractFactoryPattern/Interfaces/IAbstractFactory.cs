using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public interface IAbstractFactory
    {
        IShape GetShape(string shapeType);
    }
}
