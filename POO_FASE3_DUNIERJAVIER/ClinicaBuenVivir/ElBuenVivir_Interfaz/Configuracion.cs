using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Interfaz
{

    //Clase de cadena de conexion
    public class Configuracion
    {
        public static string getCadenaConeccion
        {
            get
            {
                return Properties.Settings.Default.cadena_Conexion;
            }

        }


        public static string getUsuario
        {
            get
            {
                return Properties.Settings.Default.role_Usuario;
            }

        }
    }
}
