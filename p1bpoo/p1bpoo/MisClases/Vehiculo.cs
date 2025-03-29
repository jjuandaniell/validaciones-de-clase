using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.Interfases;

namespace p1bpoo.MisClases
{
    public class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }

        protected int velocidad = 0;
        protected int CapacidadTanque = 50;
        protected double ConsumoCombustible = 1;
        protected int VelocidadMaxima = 100;

        //tipo de licencia 
        protected List<TipoLicencia> tiposLicenciaAceptados = new List<TipoLicencia> { TipoLicencia.A, TipoLicencia.B, TipoLicencia.C, TipoLicencia.M };
        private Chofer piloto = null;
        protected int estadoVehiculo = 0; // 0=apagado 1=encendido 2=en movimiento;

        //agregar el metedo de asignar piloto :
        public string Encender()
        {
            if (piloto == null)
            {
                return "No puedes encender el vehiculo sin un piloto asignado";
            }
            if (estadoVehiculo == 0)
            {
                estadoVehiculo = 1;
                return "El vehiculo esta encendido";
            }
            return "El carro ya esta encendido";
        }

        public string AsignarPiloto(Chofer elPiloto)
        {
            if (elPiloto == null)
            {
                return "No se puede asignar un piloto nulo";
            }
            if (!tiposLicenciaAceptados.Contains(elPiloto.TipoLicencia))
            {
                return "El piloto no tiene el tipo de licencia adecuado para este vehiculo";
            }
            if (piloto != null)
            {
                return "Este vehiculo ya tiene asignado un piloto";
            }
            piloto = elPiloto;
            return "Piloto asignado con exito";
        }

        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color: {0}", this.Color);
            Console.WriteLine("Modelo: {0}", this.Modelo);
            Console.WriteLine("Año: {0}", this.Year);
            Console.WriteLine("La velocidad actual es {0} KMS / Hora", this.velocidad);
            Console.WriteLine("La velocidad maxima del vehiculo es {0} KMS / Hora", this.VelocidadMaxima);
            if (estadoVehiculo == 0)
            {
                Console.WriteLine("El vehiculo esta apagado");
            }
            else if (estadoVehiculo == 1)
            {
                Console.WriteLine("El vehiculo esta encendido");
            }
            else
            {
                Console.WriteLine("El vehiculo esta en movimiento");
            }

            if (piloto != null)
            {
                Console.WriteLine("El piloto asignado es {0}", piloto.Nombre);
                Console.WriteLine("El piloto cuenta con la licencia tipo {0}", piloto.TipoLicencia);
            }
            else
            {
                Console.WriteLine("No hay piloto asignado");
            }
        }

        public virtual void acelerar(int cuanto)
        {
            if (estadoVehiculo == 0)
            {
                Console.WriteLine("No puedes acelerar si el vehiculo esta apagado");
                return;
            }
            velocidad += cuanto;
            if (velocidad > VelocidadMaxima)
            {
                velocidad = VelocidadMaxima;
                Console.WriteLine("Cuidado, ya no puedes acelerar mas, no puedes superar {0} KMS / Hora", VelocidadMaxima);
            }
            Console.WriteLine("Haz acelerado a {0} KMS / Hora", velocidad);
            estadoVehiculo = 2;
        }

        public virtual void frenar()
        {
            velocidad = 0;
            estadoVehiculo = 1;
            Console.WriteLine("Vehiculo frenado, vas a {0} KMS / Hora", velocidad);
        }

        public virtual void apagar()
        {
            if (velocidad >= 1)
            {
                Console.WriteLine("No puedes apagar el vehiculo en movimiento");
            }
            else
            {
                estadoVehiculo = 0;
                Console.WriteLine("Vehiculo apagado");
            }
        }
    }
}