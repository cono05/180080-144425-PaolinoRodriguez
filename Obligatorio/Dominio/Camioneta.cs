using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Camioneta
    {
        public string Chapa { get; set; }

        public string Marca { get; set; }
        public int Capacidad { get; set; }

        public int ConsumoCada100Km{ get; set; }

        public float RelacionCantAlumnosConsumo { get; set; }

        private Camioneta()
        {
            Chapa = string.Empty;
            Capacidad = 0;            
        }

        public static Camioneta CrearCamioneta()
        {
            Camioneta camioneta = new Camioneta();
            return camioneta;
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj != null && this.GetType() == obj.GetType())
            {
                Camioneta camioneta = (Camioneta)obj;
                equals = camioneta.Chapa.Equals(Chapa);
            }
            return equals;
        }

        public override string ToString()
        {
            return Marca + " (" + Chapa + ")";
        }
    }
}
