
using p1bpoo.MisClases;
using System;
using p1bpoo.MisClases;
using p1bpoo.Interfases;

namespace p1bpoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Chofer Pablo = new Chofer("Pablo", 30, TipoLicencia.B);
            Chofer Landelino = new Chofer("Landelino", 25, TipoLicencia.M);
            Landelino.MostrarInformacion();
            Console.WriteLine("Puede tener licencia: {0}", Landelino.PuedeTenerLicencia());
            Moto Lamoto = new Moto(2020, "Negro", "Kawasaki");
            Console.WriteLine("---------------------------------------------");
            Lamoto.AsignarPiloto(Landelino);
            Lamoto.Encender();
            Lamoto.acelerar(10);
            Lamoto.HabilidadChofer();
            Console.WriteLine("---------------------------------------------");
            Lamoto.InformacionVehiculo();
        }
    }
}




