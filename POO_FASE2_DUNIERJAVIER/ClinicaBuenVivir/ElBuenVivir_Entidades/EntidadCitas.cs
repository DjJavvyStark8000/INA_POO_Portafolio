using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadCitas
    {
        private int citasId;
        private int idMedicosEspecialidades;
        private int horarioId;
        private string estado;
        private string motivo;
        private string observaciones;
        //private int horario_id;
        private DateTime fecha;
        private TimeSpan horaInicio;
        private TimeSpan horaFin;
        private string medico;
        private string pagado;
        private string metodo_pago;

        public EntidadCitas()
        {
            // Constructor sin parámetros con datos por defecto
            this.citasId = 0;
            this.idMedicosEspecialidades = 0;
            this.horarioId = 0;
            this.estado = "";
            this.motivo = "";
            this.observaciones = "";
            //this.horario_id = 0;
            this.fecha = DateTime.MinValue;
            this.horaInicio = TimeSpan.Zero;
            this.horaFin = TimeSpan.Zero;
            this.medico = "";
            this.pagado = string.Empty;
            this.metodo_pago = string.Empty;
        }

        public EntidadCitas(int citasId, int idMedicosEspecialidades, int horarioId, 
            string estado, string motivo, string observaciones, int id, DateTime fecha, 
            TimeSpan horaInicio, TimeSpan horaFin, string medico, string pagado, string metodo_pago)
        {
            // Constructor con parámetros
            this.citasId = citasId;
            this.idMedicosEspecialidades = idMedicosEspecialidades;
            this.horarioId = horarioId;
            this.estado = estado;
            this.motivo = motivo;
            this.observaciones = observaciones;
           // this.horario_id = id;
            this.fecha = fecha;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.medico = medico;
            this.pagado = pagado;
            this.metodo_pago = metodo_pago;
        }

        // Propiedades (getters y setters) para los atributos privados
        public int CitasId { get { return citasId; } set { citasId = value; } }
        public int IdMedicosEspecialidades { get { return idMedicosEspecialidades; } set { idMedicosEspecialidades = value; } }
        public int HorarioId { get { return horarioId; } set { horarioId = value; } }
        public string Estado { get { return estado; } set { estado = value; } }
        public string Motivo { get { return motivo; } set { motivo = value; } }
        public string Observaciones { get { return observaciones; } set { observaciones = value; } }
        //public int  Id { get { return id; } set { id = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public TimeSpan HoraInicio { get { return horaInicio; } set { horaInicio = value; } }
        public TimeSpan HoraFin { get { return horaFin; } set { horaFin = value; } }
        public string Medico { get { return medico; } set { medico = value; } }
        public string Pagado { get { return pagado; } set {  pagado = value; } }
        public string Metodo_Pago { get { return metodo_pago;}set { metodo_pago = value; } }
    }
}
