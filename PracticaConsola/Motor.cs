using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConsola
{
    class Motor
    {
            private string tipo;
            private double potencia;

            public double Potencia
            {
                get
                {
                    return potencia;
                }
                set
                {
                    potencia = value;
                }

            }

            public string Tipo
            {
                get
                {
                    return tipo;

                }
                set
                {
                    tipo = value;
                }
            }

            public Motor()
            {
                tipo = "";
                potencia = 0;
            }

            public override string ToString()
            {
                return " Tipo:" + tipo + " Potencia:" + potencia;
            }

        
    }
}
