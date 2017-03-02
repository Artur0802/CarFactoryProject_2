using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactoryProject_2.CarParts;
using CarFactoryProject_2.CarParts.TuningParts;

namespace CarFactoryProject_2.Cars
{
    class Car : CarFactoryProject_2.IAssemblyItem.IAssembly, CarFactoryProject_2.IItemPrice.IItemPrice
    {
        private CarPartFactory factory = null;
        private Body body = null;
        private Wheel wheel = null;
        private Engine engine = null;
        private float price = 0;

        public Car(CarPartFactory factory, List<Tuning> tuninglist, string color, string type, string gumtype, int diameter, string etype, int volume)
        {
            this.factory = factory;
            this.factory.TuningValid(tuninglist);
            this.body = factory.CreateBody(color, type);
            this.wheel = factory.CreateWheel(gumtype, diameter);
            this.engine = factory.CreateEngine(etype, volume);
            this.Price = this.body.Price + 4 * this.wheel.Price + this.engine.Price;
        }

        public float Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        
        public void Assembly()
        {
            Console.WriteLine("Your car is assembled. It contains:");
            this.body.Assembly();
            this.wheel.Assembly();
            this.engine.Assembly();
            Console.WriteLine("Car price - {0}", this.Price);
        }
    }
}
