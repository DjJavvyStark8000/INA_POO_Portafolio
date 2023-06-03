using System;

namespace LogicaNegocio
{
    public class ClsPromedio
    {
        private string condicion;
        private string color;
        private double promedio;

        public ClsPromedio()
        {
            condicion = string.Empty;
            color = string.Empty;
            promedio = 0.0;
        }

        public ClsPromedio(string condicion, string color, double promedio)
        {
            this.condicion = condicion;
            this.color = color;
            this.promedio = promedio;
        }

        //getters
        public string Condicion {get { return condicion; }}

        public string Color { get { return color; } }

        public double Promedio { get {  return promedio; }}

        //calcula promedio
        public double calculaPromedio(double sumaNotas, int cantidadNotas) 
        {
            promedio = sumaNotas / cantidadNotas;
            return promedio;
        }

        //aprueba o reprueba
        public void calculaAprobReprob(double promedio)
        {
         if(promedio >= 70 & promedio <= 100)
            {
                condicion = "Aprobado";
                color = "Green";
            }if(promedio < 70 & promedio >= 0)
            {
                condicion = "Reprobado";
                color = "Red";
            }
            
        }

        public double calculaPromedio(double totalSumaNotas, object count)
        {
            throw new NotImplementedException();
        }
    }
}
