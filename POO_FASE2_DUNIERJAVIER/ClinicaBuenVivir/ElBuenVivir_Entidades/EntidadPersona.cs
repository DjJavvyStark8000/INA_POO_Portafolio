using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public abstract class Persona
    {
        private int identificacion;
        private string nombre;
        private string apellidos;
        private string fechaNacimiento;
        private string genero;
        private string nacionalidad;
        private string estadoCivil;
        private int telefono;
        private string correo;
        private string ciudad;
        private string provincia;
        private string detalleDireccion;

        //Constructor vacio
        public Persona()
        {
            identificacion = 0;
            nombre = string.Empty;
            apellidos = string.Empty;
            fechaNacimiento = string.Empty;
            genero = string.Empty;
            nacionalidad = string.Empty;
            estadoCivil = string.Empty;
            telefono = 0;
            correo = string.Empty;
            ciudad = string.Empty;
            provincia = string.Empty;
            detalleDireccion = string.Empty;
        }

        // Constructor que acepta parámetros
        public Persona(int identificacion, string nombre, string apellidos, 
            string fechaNacimiento, string genero, string nacionalidad, 
            string estadoCivil, int telefono, string correo, string ciudad, 
            string provincia, string detalleDireccion)
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.genero = genero;
            this.nacionalidad = nacionalidad;
            this.estadoCivil = estadoCivil;
            this.telefono = telefono;
            this.correo = correo;
            this.ciudad = ciudad;
            this.provincia = provincia;
            this.detalleDireccion = detalleDireccion;
        }

        //setters y getters
        public int Identificacion { get { return identificacion; } set { identificacion = value; } }   
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }
        public string FechaNacimiento { get { return fechaNacimiento; } set { fechaNacimiento = value; } }
        public string Genero { get { return genero; } set { genero = value; } }
        public string Nacionalidad { get { return nacionalidad; } set { nacionalidad = value; } }
        public string EstadoCivil { get { return estadoCivil; } set { estadoCivil = value; } }
        public int Telefono { get { return telefono; } set { telefono = value; } }
        public string Correo { get { return correo; } set { correo = value; } }
        public string Ciudad { get { return ciudad; } set { ciudad = value; } }
        public string Provincia { get { return provincia; } set { provincia = value; } }
        public string DetalleDireccion { get { return detalleDireccion; } set { detalleDireccion = value; } }

    }
}
