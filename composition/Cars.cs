using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public enum Name { BMW, LANCER, MS, KIA };

namespace composition
{
    internal class Cars
    {
        private Name name;
        private int model;
        private double price;
        private Engine engine;

        public Cars() { }
        public Cars(Name name, int model, double price, Engine engine)
        {
            this.name = name;
            this.model = model;
            this.price = price;
            this.engine = engine;
        }

        public void setName(Name name)
        {
            this.name = name;
        }

        public Name getName()
        {
            return this.name;
        }
        public double getPrice()
        {
            return this.price;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }

        public int getModel()
        {
            return this.model;
        }
        public void setModel(int model)
        {
            this.model = model;
        }

        public void setEngine(Engine engine)
        {
            this.engine = engine;
        }

        public Engine getEngine()
        {
            return this.engine;
        }

    }
}
