using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadCitas
    {
        private int citasId;
        private int horarioId;
        private int pagosId;
        private string estado;
        private string motivo;
        private string observaciones;
        private string metodo_pago;


        public EntidadCitas()
        {
            // Constructor sin parámetros con datos por defecto
            this.citasId = 0;
            this.horarioId = 0;
            this.pagosId = 0;
            this.estado = "";
            this.motivo = "";
            this.observaciones = "";        
            this.metodo_pago = string.Empty;
        }

        public EntidadCitas(int citasId, int horarioId, int pagosId, string estado, string motivo, string observaciones, string pagado, string metodo_pago)
        {
            // Constructor con parámetros
            this.citasId = citasId;
            this.horarioId = horarioId;
            this.pagosId = pagosId;
            this.estado = estado;
            this.motivo = motivo;
            this.observaciones = observaciones;
            this.metodo_pago = metodo_pago;
        }

        // Propiedades (getters y setters) para los atributos privados
        public int CitasId { get { return citasId; } set { citasId = value; } }
        public int HorarioId { get { return horarioId; } set { horarioId = value; } }
        public int PagosId { get { return pagosId; }set { pagosId = value; } }
        public string Estado { get { return estado; } set { estado = value; } }
        public string Motivo { get { return motivo; } set { motivo = value; } }
        public string Observaciones { get { return observaciones; } set { observaciones = value; } }   
        public string Metodo_Pago { get { return metodo_pago;}set { metodo_pago = value; } }
    }
}
