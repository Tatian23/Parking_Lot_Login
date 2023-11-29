using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño
{
    public class Administrador:Persona // toca borrar esta clase o la de arriba // SE BORRO LA INTERNAL
    {
        /*  
            En esta clase según la base de datos se heredan las variables de la clase Persona.
            "Definir cuales se heredaran según la necesidad."
            BASADO EN LA IMAGEN DEL WORD NO HEREDA NADA DE CLASE PERSONA, SI PUEDEN VER PERTINENTE AGREGAR UNA HERENCIA
            EN ESTE ESPACIO ME LO HACEN SABER COMPAÑER@S
        */
        

       
        public string Usuario { get; set; } /* Tocaria agregarlo a la base de datos como una tabla
                                           debido a que serviria mejor como una clase padre para
                                           manejar los 3 tipos de usuar = "Administrador", "Colaborador", "Cliente".
                                           y esta clase Usuario Heredara de Persona y dara herencia a esas 3 subclases.
                                        */

        public class Parqueadero
        {
            //Agregar la variable: id_parqueadero; //AGREGADA
            
            public int id_parqueadero { get; set; }
            public string nombre { get; set; } // Esta variable es: "nombre" //CORREGIDO 
            public string clase { get; set; } // Esta variable es: "clase" //CORREGIDO
            public string direccion { get; set; } // Esta variable es: "direccion" //CORREGIDO
            public string ciudad { get; set; } // Esta variable es: "ciudad" //CORREGIDO
            public string coordenadas { get; set; } // Esta variable es: "coordenadas" //CORREGIDO
            public string modoDeControl { get; set; } // Esta variable es: "modoDeControl" //CORREGIDO
            public int capacidad { get; set; } // Esta variable es: "capacidad" //CORREGIDO
                                               //Agregar la variable: disponibilidad;// AGREGADA, YA ESTA EN LA PARTE DE ABAJI
            public int Tarifa { get; set; } // Esta variable es una llave Foranea FK heredada de la clase o tabla tarifa
            public int Horario { get; set; } // Igual que tarifa solo que en la base de datos no esta relacionada a parqueadero
                                             //ESTAS VARIABLES FK Tarifa y Horario SE HICIERON EN BASE A LA IMAGEN DEL WORD, LAS CUALES DICEN QUE SON DE LA 
                                             //CLASE Parqueadero, MEPODRIAN EXPLICAR A QUE SE REFIEREN, OSEA SI VA FUERA DE ESTA CLASE O COMO
            
            public bool disponibilidad()
            {
                // Calcular disponibilidad
                return this.capacidad > 0;
            }
            /*
            public void Ingresar(String placa)
            {
                this.Placa = placa;
                this.FechaHoraIngreso = DateTime.Now;

                // Calcular tarifa
                double tarifaHora = this.Tarifa.TipoVehiculo == "Carro" ? this.Tarifa.ValorHora : this.Tarifa.ValorHoraAdicional;
                this.ValorTotal = tarifaHora * this.CalcularTiempo();
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
                return this.CalcularTiempo() * this.TarifaHora;
            }
        }*/
            
        }
    }
}
            
