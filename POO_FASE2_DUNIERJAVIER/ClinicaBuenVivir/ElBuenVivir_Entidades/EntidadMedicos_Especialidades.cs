using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadMedicos_Especialidades
    {
        private int idMedEsp;
        private int idEspecialidades;
        private int idMedicos;

        public EntidadMedicos_Especialidades()
        {
            idMedEsp = 0;
            idEspecialidades = 0;
            idMedicos = 0;
        }

        public EntidadMedicos_Especialidades(int medEspId, int idEspecialidades, int idMedicos)
        {
            // Constructor con parámetros
            this.idMedEsp = medEspId;
            this.idEspecialidades = idEspecialidades;
            this.idMedicos = idMedicos;
        }

        public int IdMedicoEspecialidad
        {
            get { return idMedEsp; }
            set { idMedEsp = value; }
        }

        public int IdEspecialidades
        {
            get { return idEspecialidades; }
            set { idEspecialidades = value; }
        }

        public int IdMedicos
        {
            get { return idMedicos; }
            set { idMedicos = value; }
        }
    }
}
