using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactoryProject_2.CarParts.TuningParts;
using CarFactoryProject_2.Cars;
using CarFactoryProject_2.CarParts;

namespace CarFactoryProject_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarPartFactory factory = new CarPartFactory();

            List<Tuning> tuninglist = new List<Tuning>();
            tuninglist.Add(new Spoiler());
            tuninglist.Add(new AudioSystem());
            tuninglist.Add(new Turbo());

            Car car = new Car(factory, tuninglist, "green", "coupe", "summer", 18, "gas", 3000);
            car.Assembly();

            Console.ReadKey();
        }
    }
}
