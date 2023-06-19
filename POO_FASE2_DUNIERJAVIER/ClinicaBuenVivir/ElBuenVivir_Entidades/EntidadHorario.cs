using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadHorario
    {
        private int horarioId;
        private string fecha;
        private string horaInicio;
        private string horaFin;


        public EntidadHorario()
        {
            // Constructor sin parámetros con datos por defecto
            this.horarioId = 0;
            this.fecha = "";
            this.horaInicio = string.Empty;
            this.horaFin = string.Empty;

        }

        public EntidadHorario(int id, string fecha, string horaInicio, string horaFin, string medico)
        {
            // Constructor con parámetros
            this.horarioId = id;
            this.fecha = fecha;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;

        }

        // Propiedades (getters y setters) para los atributos privados
        public int HorarioId { get { return horarioId; } set { horarioId = value; } }
        public string Fecha { get { return fecha; } set { fecha = value; } }
        public string HoraInicio { get { return horaInicio; } set { horaInicio = value; } }
        public string HoraFin { get { return horaFin; } set { horaFin = value; } }

    }
}
