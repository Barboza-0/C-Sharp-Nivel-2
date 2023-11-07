using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_6
{
    internal class Botella
    {
        private int capacidad;
        private int capacidadActual;
        private int difCapacidad;

        public Botella(int capacidadActual)
        {
            this.capacidadActual = capacidadActual;
            capacidad = 100;
            difCapacidad = capacidad - capacidadActual;
        }

        public float recarga()
        {
            if (capacidadActual > 0 && capacidadActual < 100)
            {
                int dif = capacidad - capacidadActual;
                float monto = dif * 50 / capacidad;
                capacidadActual += dif;
                return monto;
            }
            capacidadActual = 100;
            return 50;
        }

        public int DifCapacidad
        {
            get { return difCapacidad; }
        }
    }
}
