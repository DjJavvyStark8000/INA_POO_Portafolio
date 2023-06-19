using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadHistorial
    {
        private int historialClinicoId;
        private DateTime fechaRegistro;
        private string antecedentes;
        private string medicamentos;
        private string diagnosticos;
        private string resultadoPruebas;
        private string observaciones;


        public EntidadHistorial(int historialClinicoId, DateTime fechaRegistro, string antecedentes, string medicamentos, string diagnosticos, string resultadoPruebas, string observaciones)
        {
            this.historialClinicoId = historialClinicoId;
            this.fechaRegistro = fechaRegistro;
            this.antecedentes = antecedentes;
            this.medicamentos = medicamentos;
            this.diagnosticos = diagnosticos;
            this.resultadoPruebas = resultadoPruebas;
            this.observaciones = observaciones;
        }

        public EntidadHistorial()
        {
            historialClinicoId = 0;
            fechaRegistro = DateTime.MinValue;
            antecedentes = null;
            medicamentos = null;
            diagnosticos = null;
            resultadoPruebas = null;
            observaciones = null;
        }
        public int HistorialId { get => historialClinicoId; set => historialClinicoId = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public string Antecedentes { get => antecedentes; set => antecedentes = value; }
        public string Medicamentos { get => medicamentos; set => medicamentos = value; }
        public string Diagnosticos { get => diagnosticos; set => diagnosticos = value; }
        public string ResultadoPruebas { get => resultadoPruebas; set => resultadoPruebas = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
    }
}
