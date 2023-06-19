using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadFuncionario : Persona
    {    
        private string puesto;
        private string diasLibres;
        private string anotaciones;
        private string horaEntrada;
        private string horaSalida;

        public EntidadFuncionario()
        {
            // Constructor sin parámetros con datos por defecto          
            this.puesto = "";
            this.diasLibres = "";
            this.anotaciones = "";
            this.horaEntrada = string.Empty;
            this.horaSalida = string.Empty;
        }

        public EntidadFuncionario(int funcionarioId, string puesto, string nombreFuncionario, string apellidos, string fechaNacimiento,
            string genero, string nacionalidad, string estadoCivil, string diasLibres, string correo, int telefono, string ciudad,
            string provincia, string direccionDetalle, string anotaciones, string horaEntrada, string horaSalida)
        {
            // Constructor con parámetros       
            this.puesto = puesto;
            this.diasLibres = diasLibres;
            this.anotaciones = anotaciones;
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;
        }
        public string Puesto { get { return puesto; } set { puesto = value; } }
        public string DiasLibres { get { return diasLibres; } set { diasLibres = value; } }
        public string Anotaciones { get { return anotaciones; } set { anotaciones = value; } }
        public string HoraEntrada { get { return horaEntrada; } set { horaEntrada = value; } }
        public string HoraSalida { get { return horaSalida; } set { horaSalida = value; } }

    }
}
