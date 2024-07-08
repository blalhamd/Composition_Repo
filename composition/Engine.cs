using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composition
{
    internal class Engine
    {
        private string name;
        private int power;
        private string type;


        public Engine() { }
        public Engine(string name, int power, string type)
        {
            this.name = name;
            this.power = power;
            this.type = type;
        }


        public void setName(string name)
        {
            this.name = name;
        }

        public void setPower(int power)
        {
            this.power = power;
        }

        public string getName()
        {
            return this.name;
        }

        public int getPower()
        {
            return this.power;
        }
        public string getType()
        {
            return this.type;
        }



    }
}
