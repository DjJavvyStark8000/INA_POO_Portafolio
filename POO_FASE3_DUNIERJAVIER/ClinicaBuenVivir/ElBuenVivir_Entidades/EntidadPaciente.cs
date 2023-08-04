using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadPaciente : Persona
    {
        private string tipo_id;
        private string laborando;
        private string asegurado;
        private int numero_emergencia;
        private string guardian;

        public EntidadPaciente()
        {  
            tipo_id = string.Empty;
            laborando = string.Empty;
            asegurado = string.Empty;
            numero_emergencia = 0;
            guardian = string.Empty;
        }
        public EntidadPaciente(int id_historial, string tipo_id, string laborando, string asegurado, int numero_emergencia, string guardian)
        {
            this.tipo_id = tipo_id;
            this.laborando = laborando;
            this.asegurado = asegurado;
            this.numero_emergencia = numero_emergencia;
            this.guardian = guardian;
        }

        public string Tipo_id { get { return tipo_id; } set { tipo_id = value; } }
        public string Laborando { get {  return laborando; } set {  laborando = value; } }
        public string Asegurado { get { return asegurado; }set { asegurado = value; } }
        public int NumeroEmergencia { get { return numero_emergencia; }set { numero_emergencia = value; } }
        public string Guardian { get {  return guardian; }set {  guardian = value; } }
    }
}
