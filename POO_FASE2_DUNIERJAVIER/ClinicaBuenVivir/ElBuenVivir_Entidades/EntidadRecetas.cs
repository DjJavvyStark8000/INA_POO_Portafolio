using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadRecetas
    {

        private int recetaId;
        private int inventarioId;
        private int idMedEspecial;
        private String nombreReceta;
        private String dosis;
        private DateTime fechaRetiro;
        private string duracion;
        private String indicaciones;
        private int cantidadRecetas;
        private DateTime proximaReceta;

        // Constructor con parámetros
        public EntidadRecetas(int recetaId,int inventarioId, int idMedEspecial, String nombreReceta, String dosis, DateTime fechaRetiro,
                      string duracion, String indicaciones, int cantidadRecetas, DateTime proximaReceta)
        {
            this.recetaId = recetaId;
            this.inventarioId = inventarioId;
            this.idMedEspecial = idMedEspecial;
            this.nombreReceta = nombreReceta;
            this.dosis = dosis;
            this.fechaRetiro = fechaRetiro;
            this.duracion = duracion;
            this.indicaciones = indicaciones;
            this.cantidadRecetas = cantidadRecetas;
            this.proximaReceta = proximaReceta;
        }

        // Constructor sin parámetros con datos por defecto
        public EntidadRecetas()
        {
            this.recetaId = 0;
            this .inventarioId = 0;
            this.idMedEspecial = 0;
            this.nombreReceta = null;
            this.dosis = null;
            this.fechaRetiro = DateTime.MinValue;
            this.duracion = "";
            this.indicaciones = null;
            this.cantidadRecetas = 0;
            this.proximaReceta = DateTime.MinValue;
        }

        // Getters y setters en una sola línea
        public int RecetaId { get => recetaId; set => recetaId = value; }
        public int InventarioId { get => inventarioId; set => inventarioId = value; }
        public int IdMedEspecial { get => idMedEspecial; set => idMedEspecial = value; }
        public string NombreReceta { get => nombreReceta; set => nombreReceta = value; }
        public string Dosis { get => dosis; set => dosis = value; }
        public DateTime FechaRetiro { get => fechaRetiro; set => fechaRetiro = value; }
        public string Duracion { get => duracion; set => duracion = value; }
        public string Indicaciones { get => indicaciones; set => indicaciones = value; }
        public int CantidadRecetas { get => cantidadRecetas; set => cantidadRecetas = value; }
        public DateTime ProximaReceta { get => proximaReceta; set => proximaReceta = value; }
    }
}
