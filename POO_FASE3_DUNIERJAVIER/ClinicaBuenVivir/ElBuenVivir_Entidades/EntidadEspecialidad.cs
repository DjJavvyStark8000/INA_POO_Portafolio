using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadEspecialidad
    {
        private int id_especialidad;
        private string nombre_especialidad;
        private string descripcion;
        private string area;
        private decimal costo;
        private string disponibilidad;
        private string observaciones;

        public EntidadEspecialidad()
        {
            id_especialidad = 0;
            nombre_especialidad = string.Empty;
            descripcion = string.Empty;
            area = string.Empty;
            costo = 0;
            disponibilidad = string.Empty;
            observaciones = string.Empty;
        }
        public EntidadEspecialidad(int id_especialidad, string nombre_especialidad, string descripcion, string area, decimal costo, string disponibilidad, string observaciones)
        {
            this.id_especialidad = id_especialidad;
            this.nombre_especialidad = nombre_especialidad;
            this.descripcion = descripcion;
            this.area = area;
            this.costo = costo;
            this.disponibilidad = disponibilidad;
            this.observaciones = observaciones;
        }

        public int ID_Especialidad { get { return id_especialidad; } set  { id_especialidad = value; } } 
        public string Nombre_Especialidad { get { return  nombre_especialidad; } set { nombre_especialidad = value; } }
        public string Descripcion { get {  return descripcion; } set {  descripcion = value; } }
        public string Area { get { return area; } set {  area = value; } }
        public decimal Costo { get { return costo; } set { costo = value; } }
        public string Disponibilidad { get { return disponibilidad; } set { disponibilidad = value; } }
        public string Observaciones { get {  return observaciones; } set {  observaciones = value; } }
    }
}
