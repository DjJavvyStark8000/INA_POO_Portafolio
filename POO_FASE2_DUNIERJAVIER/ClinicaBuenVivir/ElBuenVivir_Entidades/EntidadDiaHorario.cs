using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadDiaHorario
    {
        private int medicoId;
        private string lunes;
        private string martes;
        private string miercoles;
        private string jueves;
        private string viernes;
        private string sabado;
        private string domingo;
        public EntidadDiaHorario()
        {
            // Constructor sin parámetros con datos por defecto
            medicoId = 0;
            lunes = "";
            martes = "";
            miercoles = "";
            jueves = "";
            viernes = "";
            sabado = "";
            domingo = "";
        }

        public EntidadDiaHorario(int medicoId, string lunes, string martes, string miercoles, string jueves, string viernes, string sabado, string domingo)
        {
            // Constructor con parámetros
            this.medicoId = medicoId;
            this.lunes = lunes;
            this.martes = martes;
            this.miercoles = miercoles;
            this.jueves = jueves;
            this.viernes = viernes;
            this.sabado = sabado;
            this.domingo = domingo;
        }

        // Propiedades (getters y setters) para los atributos privados
        public int MedicoID { get { return medicoId; } set { medicoId = value; } }
        public string Lunes { get { return lunes; } set { lunes = value; } }
        public string Martes { get { return martes; } set { martes = value; } }
        public string Miercoles { get { return miercoles; } set { miercoles = value; } }
        public string Jueves { get { return jueves; } set { jueves = value; } }
        public string Viernes { get { return viernes; } set { viernes = value; } }
        public string Sabado { get { return sabado; } set { sabado = value; } }
        public string Domingo { get { return domingo; } set { domingo = value; } }
    }
}
