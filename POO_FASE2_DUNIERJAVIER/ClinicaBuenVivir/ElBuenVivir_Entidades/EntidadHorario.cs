using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadHorario
    {
        private int horarioId;
        private string fechaHorario;
        private string horaInicio;
        private string horaFin;
        private int medicoId;


        public EntidadHorario()
        {
            // Constructor sin parámetros con datos por defecto
            this.horarioId = 0;
            this.fechaHorario = string.Empty;
            this.horaInicio = string.Empty;
            this.horaFin = string.Empty;
            this.medicoId = 0;

        }

        public EntidadHorario(int horarioId, string fechaHorario, string horaInicio, string horaFin, int medicoId)
        {
            // Constructor con parámetros
            this.horarioId = horarioId;
            this.fechaHorario = fechaHorario;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.medicoId = medicoId;
        }

        // Propiedades (getters y setters) para los atributos privados
        public int HorarioId { get { return horarioId; } set { horarioId = value; } }
        public string FechaHorario { get { return fechaHorario; } set { fechaHorario = value; } }
        public string HoraInicio { get { return horaInicio; } set { horaInicio = value; } }
        public string HoraFin { get { return horaFin; } set { horaFin = value; } }
        public int MedicoId { get { return medicoId; } set {  medicoId = value; } }

    }
}
