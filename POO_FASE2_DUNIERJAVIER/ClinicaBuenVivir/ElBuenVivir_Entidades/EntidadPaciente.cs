using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadPaciente : Persona
    {
        private int id_historial; 
        private string tipo_id;
        private string laborando;
        private string aseguado;
        private int numero_emergencia;
        private string guardian;

        public EntidadPaciente()
        {  
            id_historial = 0;
            tipo_id = string.Empty;
            laborando = string.Empty;
            aseguado = string.Empty;
            numero_emergencia = 0;
            guardian = string.Empty;
        }
        public EntidadPaciente(int id_historial, string tipo_id, string laborando, string aseguado, int numero_emergencia, string guardian)
        {
            this.id_historial = id_historial;
            this.tipo_id = tipo_id;
            this.laborando = laborando;
            this.aseguado = aseguado;
            this.numero_emergencia = numero_emergencia;
            this.guardian = guardian;
        }

        public int Id_Historial { get { return id_historial; }set { id_historial = value; } }
        public string Tipo_id { get { return tipo_id; } set { tipo_id = value; } }
        public string Laborando { get {  return laborando; } set {  laborando = value; } }
        public string Asegurado { get { return laborando; }set { laborando = value; } }
        public int NumeroEmergencia { get { return numero_emergencia; }set { numero_emergencia = value; } }
        public string Guardian { get {  return guardian; }set {  guardian = value; } }
    }
}
