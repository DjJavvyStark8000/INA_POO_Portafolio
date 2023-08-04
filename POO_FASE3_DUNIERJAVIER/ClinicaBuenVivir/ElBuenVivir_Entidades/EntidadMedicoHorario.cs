using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadMedicoHorario
    {
        private string nombre;
        private string puesto;
        private string fecha;
        private string horain;
        private string horaout;
        private int medicoid;

        public EntidadMedicoHorario(string nombre, string puesto, string fecha, string horain, string horaout, int medicoid)
        {
            this.nombre = nombre;
            this.puesto = puesto;
            this.fecha = fecha;
            this.horain = horain;
            this.horaout = horaout;
            this.medicoid = medicoid;
        }

        public EntidadMedicoHorario()
        {
            nombre = string.Empty;
            puesto = string.Empty; 
            fecha = string.Empty; 
            horain = string.Empty;
            horaout = string.Empty;
            medicoid = 0;
        }

        public string NombreMedico { get {  return nombre; } set { nombre = value; } }
        public string Puesto { get {  return puesto; } set {  puesto = value; } }
        public string Fecha { get {  return fecha; } set {  fecha = value; } }
        public string Horain { get { return horain; } set {  horain = value; } }
        public string Horaout { get { return horaout; } set { horaout = value; } }
        public int Medicoid { get {  return medicoid; } set {  medicoid = value; } }
    }
}
