using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConsola
{
    class Vehiculo
    {
        private string color;
        private Motor motor;

        public Motor Motor
        {
            get
            {
                return motor;
            }
            set
            {
                motor = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public Vehiculo()
        {
            color = "";
            motor = new Motor();
        }

        public override string ToString()
        {
            return " Color:" + color + " Motor " + motor;
        }

    }
}
