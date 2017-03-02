using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryProject_2.CarParts.TuningParts
{
    abstract class Tuning : CarFactoryProject_2.IItemPrice.IItemPrice
    {
        public abstract string Name { get; }

        public abstract float Price { get; set; }
    }
}
