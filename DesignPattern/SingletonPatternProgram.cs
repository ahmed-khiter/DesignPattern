using _3.SingletonPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class SingletonPatternProgram
    {
        static void Main(string[] args)
        {
            //illegal construct
            //Compile Time Error: The constructor SingleObject() is not visible
            //SingleObject object = new SingleObject();

            //Get the only object available
            SingleObject singleObject = SingleObject.GetInstance();

            singleObject.ShowMessage();

        }
    }
}
