using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.Interfases;

namespace p1bpoo.MisClases
{
    internal class Hilux : Vehiculo
    {
        public Hilux(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<TipoLicencia> {TipoLicencia.C};
            VelocidadMaxima = 180;
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
