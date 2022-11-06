using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACE
{
    public class Car : IVEHICLe
    {
        public int carTank { get; set; }
        public Car()
        {
            carTank = 0;
        }
        public void Drive()
        {
        if (carTank < 1)
            {
                Console.WriteLine("NOT DRIVING");
            }
            else
            {
                Console.WriteLine("DRIVING");
            }
    }
    public bool Refuel(int liters)
    {
       carTank += liters;
            return true;
    }
}

    public class IVEHICLe
    {
    }
}
    
