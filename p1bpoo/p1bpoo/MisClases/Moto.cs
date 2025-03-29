using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.Interfases;

namespace p1bpoo.MisClases
{
    internal class Moto : Vehiculo
    {
        public Moto(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<TipoLicencia> { TipoLicencia.M};
            VelocidadMaxima = 234;
            CapacidadTanque = 15;
            ConsumoCombustible = 0.5;
        }
        public void InformacionVehiculo()
        {
            base.InformacionVehiculo();
        }

        public void Encender()
        {
            base.Encender();
        }
        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            
        }

        public override void frenar()
        {
            base.frenar();
        }

        public void AsignarPiloto(Chofer elPiloto)
        {
            base.AsignarPiloto(elPiloto);
        }

        public void HabilidadChofer()
        {
            if (estadoVehiculo == 2)
            {
                Console.WriteLine("Haciendo giro 360 grados...");
            }
            else if (estadoVehiculo == 1)
            {
                Console.WriteLine("No se puede lucir el piloto si la moto no esta en movimiento");
            }
            else
            {
                Console.WriteLine("el piloto aun no enciende la moto");
            }
        }
    }
}
