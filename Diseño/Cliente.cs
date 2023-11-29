using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño
{

    public class Cliente:Persona // Esta clase hereda directamente de la clase Persona
    {
        // Agregar estas dos clases a la base de datos en la tabla Persona solo si se necesitan.
        public string Cedula { get; set; } // tocaria agregar "Cedula" a la tabla Persona en la base de datos
        public string Direccion { get; set; } // tocaria agregar "Direccion" a la tabla Persona en la base de datos

        public class Parqueo
        {
            public string Placa { get; set; }
            public DateTime FechaHoraIngreso { get; set; }
            public DateTime FechaHoraSalida { get; set; }
            public string CodigoDeBarras { get; set; }

            public void Ingresar(string placa)
            {
                this.Placa = placa;
                this.FechaHoraIngreso = DateTime.Now;
            }

            public void Salir()
            {
                this.FechaHoraSalida = DateTime.Now;
            }

            public void ImprimirRecibo()
            {
                // Imprimir recibo
            }

            public double CalcularTiempo()
            {
                // Calcular tiempo de estacionamiento
                return (this.FechaHoraSalida - this.FechaHoraIngreso).TotalHours;
            }

            public double CalcularValorTotal()
            {
                // Calcular valor total del estacionamiento
                return this.CalcularTiempo() * 2000;
            }
        }


    }
}
