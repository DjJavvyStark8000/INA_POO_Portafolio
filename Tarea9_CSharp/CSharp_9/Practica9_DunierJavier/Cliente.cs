using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portafolio9_DunierJavier
{
    internal class Cliente
    {
        private int idCliente;
        private string? nombre;
        private string? apellido1;
        private string? fechaNacimiento;
        private int telefono;
        private string? direccion;

        //constructors
        public Cliente()
        {
            idCliente = 0;
            nombre = string.Empty;
            apellido1 = string.Empty;
            fechaNacimiento = string.Empty;
            telefono = 00000000;
            direccion = string.Empty;
        }

        public Cliente(int telefono)
        {
            this.telefono = telefono;
        }

        public Cliente(string nombre, string apellido1)
        {
            this.nombre = nombre;
            this.apellido1 = apellido1;
        }


        //setters y getters mas simplificados en esta ocacion.
        public int IdCliente 
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public string? Nombre 
        {
            get { return nombre; }
            set { nombre = value; }  
        }
        public string? Apellido1 
        {
            get { return apellido1; }
            set { apellido1 = value; } 
        }
        public string? FechaNacimiento 
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; } 
        }
        public int Telefono 
        {
            get { return telefono; }
            set { telefono = value; } 
        }
        public string? Direccion 
        {
            get { return direccion; }
            set { direccion = value; }
        }

        //metodos get
        public string getNombreApell()
        {
            string result = $"Nombre: {nombre}\nApellido: {apellido1}";
            return result;
        }

        public string getNombreId()
        {
            string result = $"Nombre: {nombre}\nIdentificador: {idCliente}";
            return result;
        }

        //metodos set
        public void setTelefono(int telefono)
        {
            this.telefono = telefono;
        }

        public void setNombreApellido(string nombre, string apellido1)
        {
            this.nombre = nombre;
            this.apellido1 = apellido1;
        }

        //funcionalidades y sobrecarga de metodos
        public void printClientInfo()
        {
            Console.WriteLine($"Identificador: {idCliente}\n" +
                $"Nombre: {nombre}\n" +
                $"Apellido1: {apellido1}\n" +
                $"Nacimiento: {fechaNacimiento}\n" +
                $"Telefono: {telefono}\n" +
                $"Direccion: {direccion}");
        }

        public bool checkPhone(int telefono)
        {
            bool check = false;
            if (telefono > 22222222 && telefono <= 99999999)
            {
                check = true;
            }
            return check;
        }

        public void printClientInfo(string nombre)
        {
            
            if (nombre[0].ToString().ToLower() == "a" || nombre[0].ToString().ToLower() == "b" ||
                nombre[0].ToString().ToLower() == "c")
            {
                Console.WriteLine("Participantes del sorteo de un libro");
            }
            else if(nombre[0].ToString().ToLower() == "x" || nombre[0].ToString().ToLower() == "y" ||
                nombre[0].ToString().ToLower() == "z")
            {
                Console.WriteLine("Participantes del sorteo de dos libros");
            }else
            {
                Console.WriteLine("Participan el proximo mes");
            }
        }




    }
}