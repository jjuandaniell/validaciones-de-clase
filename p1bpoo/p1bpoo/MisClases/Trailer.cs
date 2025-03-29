using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.Interfases;

namespace p1bpoo.MisClases
{
    internal class Trailer : Vehiculo
    {
        public Trailer(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<TipoLicencia> { TipoLicencia.C };
            VelocidadMaxima = 200;
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
        }

        public override void frenar()
        {
            base.frenar();
        }

        public override void apagar()
        {
            base.apagar();
        }

        public void Encender()
        {
            base.Encender();
        }

        public void AsignarPiloto(Chofer elPiloto)
        {
            base.AsignarPiloto(elPiloto);
        }

        public void InformacionVehiculo()
        {
            base.InformacionVehiculo();
        }
    }
}
