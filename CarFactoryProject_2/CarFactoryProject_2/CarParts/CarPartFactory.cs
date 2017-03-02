using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactoryProject_2.CarParts;
using CarFactoryProject_2.CarParts.TuningParts;

namespace CarFactoryProject_2.CarParts
{
    class CarPartFactory : CarFactoryProject_2.IAssemblyItem.IAssembly, CarFactoryProject_2.IItemPrice.IItemPrice
    {
        private List<Tuning> bodytuning = null;
        private List<Tuning> wheeltuning = null;
        private List<Tuning> enginetuning = null;
        private Body body = null;
        private Wheel wheel = null;
        private Engine engine = null;

        public void TuningValid(List<Tuning> tuninglist)
        {
            this.bodytuning = new List<Tuning>();
            this.wheeltuning = new List<Tuning>();
            this.enginetuning = new List<Tuning>();

            foreach (Tuning item in tuninglist)
            {
                if (item.Name.Equals("spoiler") || item.Name.Equals("audiosystem"))
                {
                    bodytuning.Add(item);
                }
                if (item.Name.Equals("turbo"))
                {
                    enginetuning.Add(item);
                }
            }
        }

        public CarPartFactory(){}

        public Body CreateBody(string color, string type)
        {
            this.body = new Body(color, type);

            if (bodytuning.Count != 0)
            {
                foreach (Tuning item in bodytuning)
                {
                    this.body.Name = " tuned by " + item.Name;
                    this.body.Price = item.Price;
                }
            }

            return this.body;
        }

        public Wheel CreateWheel(string gumtype, int diameter)
        {
            this.wheel = new Wheel(gumtype, diameter);

            if (wheeltuning.Count != 0)
            {
                foreach (Tuning item in wheeltuning)
                {
                    this.wheel.Name = " tuned by " + item.Name;
                    this.wheel.Price = item.Price;
                }
            }

            return this.wheel;
        }

        public Engine CreateEngine(string etype, int volume)
        {
            this.engine = new Engine(etype, volume);

            if (enginetuning.Count != 0)
            {
                foreach (Tuning item in enginetuning)
                {
                    this.engine.Name = " tuned by " + item.Name;
                    this.engine.Price = item.Price;
                }
            }

            return this.engine;
        }

        public virtual void Assembly() { }

        public virtual float Price { get; set; }
    }
}
