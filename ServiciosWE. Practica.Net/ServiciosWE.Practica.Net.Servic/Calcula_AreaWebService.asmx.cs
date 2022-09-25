using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServiciosWE.Practica.Net.Servic
{
    /// <summary>
    /// Descripción breve de Calcula_AreaWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Calcula_AreaWebService : System.Web.Services.WebService
    {
        /*-------------------------CUADRADO------------------------------------*/
        /// <summary>
        /// Metodo que calcula el area de un Cuadrado
        /// </summary>
        /// <param name="Dato1">Entrada de dato tipo string</param>
        /// <returns>Devuelve un valor de tipo double</returns> *pd:Cuadrado perfecto es debe ser un entero.Pero este caso ultilice Double por si ingresa un valor decimal.
        [WebMethod (Description ="metodo que calcula el area de cuadrado")]
        public string Cuadrado(string Dato1)
        {
            
            double resultado = Math.Pow(double.Parse(Dato1), 2);
            return "Area del cuadrado es: " + resultado;
        }

        /*-------------------------TRIANGULO------------------------------------*/
        /// <summary>
        /// Metodo que calcula el area de un rectangulo
        /// </summary>
        /// <param name="Base">Entrada de dato tipo string</param>
        /// <param name="Altura">Entrada de dato tipo string</param>
        /// <returns>Devuelve un valor de tipo double</returns>
        [WebMethod(Description = "metodo que calcula el area de Triangulo")]
        public string Triangulo(string Base, string Altura)
        {
            double resultado = (double.Parse(Base) * double.Parse(Altura))/2;
            resultado = Math.Round(resultado, 2);
            return "Area del Triangulo es: " + resultado;
        }

        /*-------------------------CIRCULO------------------------------------*/
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Radio">Entrada de dato tipo string</param>
        /// <returns>Devuelve un valor de tipo double</returns>
        [WebMethod(Description = "metodo que calcula el area de Circulo")]
        public string Circulo(string Radio)
        {
            double resultado = System.Math.PI * Math.Pow(double.Parse(Radio), 2);
            resultado = Math.Round(resultado, 2);
            return "Area del Circulo es: " + resultado;
        }

    }
}
