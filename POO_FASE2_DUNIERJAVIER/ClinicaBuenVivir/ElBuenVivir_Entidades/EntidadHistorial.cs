using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadHistorial
    {
        private int historialId;
        private int pacienteId;
        private string fechaRegistro;
        private string antecedentes;
        private string medicamentos;
        private string diagnosticos;
        private string resultadoPruebas;
        private string observaciones;


        public EntidadHistorial(int historialClinicoId,int pacienteId, string fechaRegistro, string antecedentes, string medicamentos, string diagnosticos, string resultadoPruebas, string observaciones)
        {
            this.historialId = historialClinicoId;
            this.pacienteId = pacienteId;
            this.fechaRegistro = fechaRegistro;
            this.antecedentes = antecedentes;
            this.medicamentos = medicamentos;
            this.diagnosticos = diagnosticos;
            this.resultadoPruebas = resultadoPruebas;
            this.observaciones = observaciones;
        }

        public EntidadHistorial()
        {
            historialId = 0;
            pacienteId = 0;
            fechaRegistro = string.Empty;
            antecedentes = string.Empty;
            medicamentos = string.Empty;
            diagnosticos = string.Empty;
            resultadoPruebas = string.Empty;
            observaciones = string.Empty;
        }
        public int HistorialId { get => historialId; set => historialId = value; }
        public int PacienteId { get => pacienteId; set => pacienteId = value; }
        public string FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public string Antecedentes { get => antecedentes; set => antecedentes = value; }
        public string Medicamentos { get => medicamentos; set => medicamentos = value; }
        public string Diagnosticos { get => diagnosticos; set => diagnosticos = value; }
        public string ResultadoPruebas { get => resultadoPruebas; set => resultadoPruebas = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
    }
}
