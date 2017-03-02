using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryProject_2.CarParts.TuningParts
{
    class AudioSystem : Tuning
    {
        private float price = 0;
        
        public AudioSystem()
        {
            this.price = 1000;
        }

        public override string Name { get { return "audiosystem"; } }

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
