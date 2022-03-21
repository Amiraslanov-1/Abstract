using System;
using System.Collections.Generic;
using System.Text;

namespace Task18march
{
    class Bycle : Vehicle
    {
        public override void Drive(double km)
        {
            Millage += km;
        }
        public override void ShowInfo()
        { 
            base.ShowInfo();
            Console.WriteLine("Class Bycle");
        }
    }
}
