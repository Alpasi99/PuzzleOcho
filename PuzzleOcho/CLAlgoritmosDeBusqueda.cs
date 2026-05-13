using System.Collections.Generic;

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
                Cerrados.Add(Actual);
                Abiertos.RemoveAt(0);

                Hijos = Actual.GenerarHijos();
                Hijos = TratarRepetidos(Hijos, Abiertos, Cerrados);

                foreach (CLEstado a in Hijos)
                    Abiertos.Add(a);
            }

            if (Actual.EsFinal())
            {
                Solucion.Add(Actual);
                while (Actual.padre != null)
                {
                    Solucion.Add(Actual.padre);
                    Actual = Actual.padre;
                }

                Solucion.Reverse();
            }

            return Solucion;
        }

        public static List<CLEstado> ProfundidadLimitada(CLEstado Inicial, int Limite)
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

                Cerrados.Add(Actual);
                Abiertos.RemoveAt(0);

                if (Actual.nivel < Limite)
                {
                    Hijos = Actual.GenerarHijos();
                    Hijos = TratarRepetidos(Hijos, Abiertos, Cerrados);

                    foreach (CLEstado a in Hijos)
                    {
                        Abiertos.Insert(0, a);
                    }
                }
            }

            if (Actual.EsFinal())
            {
                Solucion.Add(Actual);

                while (Actual.padre != null)
                {
                    Solucion.Add(Actual.padre);
                    Actual = Actual.padre;
                }

                Solucion.Reverse();
            }

            return Solucion;
        }
        private static List<CLEstado> TratarRepetidos(List<CLEstado> hijos, List<CLEstado> abiertos, List<CLEstado> cerrados)
        {
            List<CLEstado> HijosDepurado = new List<CLEstado>();
            bool encontrado = false;

            foreach (CLEstado hijo in hijos)
            {
                encontrado = false;

                foreach (CLEstado a in abiertos)
                {
                    if (hijo.EsIgual(a))
                    {
                        encontrado = true;
                        break;
                    }
                }

                if (encontrado) continue;

                foreach (CLEstado c in cerrados)
                {
                    if (hijo.EsIgual(c))
                    {
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    HijosDepurado.Add(hijo);
                }
            }

            return HijosDepurado;
        }

        private static List<CLEstado> TratarRepetidosProfundidad(List<CLEstado> hijos, List<CLEstado> abiertos, List<CLEstado> cerrados)
        {
            List<CLEstado> HijosDepurado = new List<CLEstado>();
            bool encontrado = false;

            foreach (CLEstado hijo in hijos)
            {
                encontrado = false;

                foreach (CLEstado a in abiertos)
                {
                    if (hijo.EsIgual(a))
                    {
                        encontrado = true;
                        break;
                    }
                }

                if (encontrado) continue;

                foreach (CLEstado c in cerrados)
                {
                    if (hijo.EsIgual(c))
                    {
                        if(hijo.nivel>=c.nivel)
                        {
                            encontrado = true;
                            break;
                        }
                    }
                }

                if (!encontrado)
                {
                    HijosDepurado.Add(hijo);
                }
            }

            return HijosDepurado;
        }

    }
}