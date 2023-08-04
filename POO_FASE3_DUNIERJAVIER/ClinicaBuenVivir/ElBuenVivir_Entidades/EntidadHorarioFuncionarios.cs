using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadHorarioFuncionarios
    {
        private int horarioid;
        private string lunes;
        private string martes;
        private string miercoles;
        private string jueves;
        private string viernes;
        private string sabado;
        private string domingo;
        public EntidadHorarioFuncionarios()
        {
            // Constructor sin parámetros con datos por defecto
            horarioid = 0;
            lunes = "";
            martes = "";
            miercoles = "";
            jueves = "";
            viernes = "";
            sabado = "";
            domingo = "";
        }

        public EntidadHorarioFuncionarios(int horarioId, string lunes, string martes, string miercoles, string jueves, string viernes, string sabado, string domingo)
        {
            // Constructor con parámetros
            this.horarioid = horarioId;
            this.lunes = lunes;
            this.martes = martes;
            this.miercoles = miercoles;
            this.jueves = jueves;
            this.viernes = viernes;
            this.sabado = sabado;
            this.domingo = domingo;
        }

        // Propiedades (getters y setters) para los atributos privados
        public int HorarioId { get { return horarioid; } set { horarioid = value; } }
        public string Lunes { get { return lunes; } set { lunes = value; } }
        public string Martes { get { return martes; } set { martes = value; } }
        public string Miercoles { get { return miercoles; } set { miercoles = value; } }
        public string Jueves { get { return jueves; } set { jueves = value; } }
        public string Viernes { get { return viernes; } set { viernes = value; } }
        public string Sabado { get { return sabado; } set { sabado = value; } }
        public string Domingo { get { return domingo; } set { domingo = value; } }
    }
}

