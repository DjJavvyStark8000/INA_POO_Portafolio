using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadFuncionario : Persona
    {
        private int horarioId;
        private string puesto;
        private string anotaciones;


        public EntidadFuncionario()
        {
            // Constructor sin parámetros con datos por defecto
            horarioId = 0;
            puesto = "";
            anotaciones = "";

        }

        public EntidadFuncionario(int horarioId, string puesto,string anotaciones)
        {
            // Constructor con parámetros
            this.horarioId = horarioId;
            this.puesto = puesto;
            this.anotaciones = anotaciones;

        }
        public int HorarioId { get { return horarioId; } set { horarioId = value; } }
        public string Puesto { get { return puesto; } set { puesto = value; } }
        public string Anotaciones { get { return anotaciones; } set { anotaciones = value; } }


    }
}
