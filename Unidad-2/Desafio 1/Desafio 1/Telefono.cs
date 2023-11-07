using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Telefono
    {
        private string modelo { get; }
        private string marca { get; }
        private string numeroTelefonico { get; set; }
        private int codigoOperador { get; set; }

        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { value = numeroTelefonico; }
        }
        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value > 0 && value < 4)
                {
                    codigoOperador = value;
                }
                else
                {
                    value = 0;
                }
            }
        }

        public Telefono(string modelo, string marca)
        {
            modelo = this.modelo;
            marca = this.marca;
        }

        public string llamar()
        {
            return "Realizando llamada...";
        }
        public string llamar(string contacto)
        {
            return "Llamando a " + contacto + "...";
        }
    }
}
