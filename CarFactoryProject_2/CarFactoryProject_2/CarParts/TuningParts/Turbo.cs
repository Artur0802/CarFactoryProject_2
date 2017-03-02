using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryProject_2.CarParts.TuningParts
{
    class Turbo : Tuning
    {
        private float price = 0;

        public Turbo()
        {
            this.price = 2000;
        }

        public override string Name { get { return "turbo"; } }

        public override float Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = Control(value);
            }
        }

        private float Control(float num)
        {
            num = this.price;
            return num;
        }
    }
}
