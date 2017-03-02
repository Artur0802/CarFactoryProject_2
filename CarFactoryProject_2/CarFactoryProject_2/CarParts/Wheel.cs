using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryProject_2.CarParts
{
    class Wheel : CarPartFactory
    {
        private string gumtype;
        private int diameter;
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

        public Wheel(string gumtype, int diameter)
        {
            this.gumtype = gumtype;
            this.diameter = diameter;
            this.price = PriceValid;
            this.name = "Wheel";
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
            Console.WriteLine("{0}" + '"' +" {1} with {2} gum type", this.diameter, this.name, this.gumtype);
            Console.WriteLine("Wheel price - {0}", this.price);
        }

        private int Diam_Valid(int d)
        {
            if (d <= 10)
            {
                Console.WriteLine("Disk diameter can't be smaller than 11" + '"');
                return 11;
            }
            else return d;
        }

        private float PriceValid
        {
            get
            {
                if (this.diameter <= 15)
                {
                    if (this.gumtype == "universal")
                        return 300;
                    else return 400;
                }
                else
                {
                    if (this.gumtype == "universal")
                        return 500;
                    else return 600;
                }
            }
        } 
    }
}
