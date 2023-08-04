using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadMisCitas
    {
        private int citasId;
        private string fechaCita;
        private string horaCita;
        private string estado;
        private string motivo;
        private string medico;
        private decimal monto;
        private string observaciones;    


        public EntidadMisCitas()
        {
            // Constructor sin parámetros con datos por defecto
            this.citasId = 0;
            this.fechaCita = "";
            this.horaCita = "";
            this.estado = "";
            this.motivo = "";
            this.medico = "";
            this.monto = 0;
            this.observaciones = "";
       
        }

        public EntidadMisCitas(int citasId, string fechaCita, string horaCita, string estado, string motivo, 
            string medico, decimal monto, string observaciones)
        {
            // Constructor con parámetros
            this.citasId = citasId;
            this.fechaCita = fechaCita;
            this.horaCita = horaCita;
            this.estado = estado;
            this.motivo = motivo;
            this.medico = medico;
            this.monto = monto;
            this.observaciones = observaciones;
        }

     
        // Propiedades (getters y setters) para los atributos privados
        public int CitasId
        {
            get { return citasId; }
            set { citasId = value; }
        }

        public string FechaCita
        {
            get { return fechaCita; }
            set { fechaCita = value; }
        }

        public string HoraCita
        {
            get { return horaCita; }
            set { horaCita = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        public string Medico
        {
            get { return medico; }
            set { medico = value; }
        }

        public decimal Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

    }
}
