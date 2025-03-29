using System;
using p1bpoo.Interfases;

namespace p1bpoo.MisClases
{
    public class Chofer : Piloto
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public TipoLicencia TipoLicencia { get; set; }

        public Chofer(string name, int edadPiloto, TipoLicencia tipoLicencia)
        {
            Nombre = name;
            Edad = edadPiloto;
            TipoLicencia = tipoLicencia;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: {0}", this.Nombre);
            Console.WriteLine("Edad: {0}", this.Edad);
            Console.WriteLine("Licencia Tipo: {0}", this.TipoLicencia);
        }

        public bool PuedeTenerLicencia()
        {
            switch (TipoLicencia)
            {
                case TipoLicencia.A:
                    return Edad >= 23;
                case TipoLicencia.B:
                    return Edad >= 21;
                case TipoLicencia.C:
                case TipoLicencia.M:
                    return Edad >= 16;
                case TipoLicencia.E:
                    return Edad >= 21;
                default:
                    return false;
            }
        }
    }
}
