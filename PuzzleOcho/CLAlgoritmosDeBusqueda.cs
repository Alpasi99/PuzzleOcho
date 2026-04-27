using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleOcho
{
    public static class CLAlgoritmosDeBusqueda
    {
        public static List<CLEstado> AnchuraPrioritaria(CLEstado Inicial)
        {
            List<CLEstado> Solucion = new List<CLEstado>();
            List<CLEstado> Abiertos = new List<CLEstado>();
            List<CLEstado> Cerrados = new List<CLEstado>();
            List<CLEstado> Hijos = new List<CLEstado>();

            CLEstado Actual = Inicial;

            Abiertos.Add(Inicial);

            while (Abiertos.Count > 0 && !Actual.EsFinal())
            {
                Actual = Abiertos[0];
                Abiertos.RemoveAt(0);
                Cerrados.Add(Actual);

                Hijos = Actual.GenerarHijos();

                foreach (CLEstado a in Hijos)
                {
                    Abiertos.Add(a);
                }

                if (Actual.EsFinal())
                {
                    Solucion.Add(Actual);
                }
            }

            return Solucion;
        }

    }
}
