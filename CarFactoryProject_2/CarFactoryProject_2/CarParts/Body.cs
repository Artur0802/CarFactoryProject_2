using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryProject_2.CarParts
{
    class Body : CarPartFactory
    {
        private string color = "";
        private string type = "";
        private float price = 0;
        private string name = "";

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = this.name + value;
            }
        }

        public Body(string color, string type)
        {
            this.color = color;
            this.type = type;
            this.price = 3000;
            this.name = "Body";
        }

        public override float Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = this.price + value;
            }
        }

        public override void Assembly()
        {
            Console.WriteLine("{0} {1} {2}", this.color, this.type, this.name);
            Console.WriteLine("Body price - {0}", this.price);
        }
    }
}
