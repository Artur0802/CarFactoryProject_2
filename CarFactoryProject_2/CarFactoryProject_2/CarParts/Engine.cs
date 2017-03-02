using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryProject_2.CarParts
{
    class Engine : CarPartFactory
    {
        private string etype = "";
        private int volume = 0;
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

        public Engine(string etype, int volume)
        {
            this.etype = etype;
            this.volume = Vol_Valid(volume);
            this.price = PriceValid;
            this.name = "Engine";
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
            Console.WriteLine("{0} {1} with volume = {2} cm3", this.etype, this.name, this.volume);
            Console.WriteLine("Engine price - {0}", this.price);
        }

        private int Vol_Valid(int v)
        {
            if (v <= 0)
            {
                Console.WriteLine("Engine's volume can't be 0");
                return 1300;
            }
            else return v;
        }

        private float PriceValid
        {
            get
            {
                if (this.etype == "gas")
                {
                    if (this.volume >= 2000)
                        return 2000;
                    else return 1500;
                }
                else
                {
                    if (this.volume >= 2000)
                        return 3000;
                    else return 2500;
                }
            }
        }
    }
}
