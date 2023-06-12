using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CapaPresentacion
{
    internal class Configuracion
    {
        public static string getCadenaConeccion
        {
            get
            {
                return Properties.Settings.Default.cadenaConeccion;
            }
            
        }
    }
}
