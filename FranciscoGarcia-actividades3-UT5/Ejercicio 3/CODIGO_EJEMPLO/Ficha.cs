using System;
using System.Text.RegularExpressions;

namespace ej1
{
    /// <summary>
    /// Tipo Valor. Permite convertir una cadena que simula una ficha de domino.
    /// </summary>
    struct Ficha
    {
        /// <summary>
        /// Enumerado que contiene todos los valores posibles que puede tomar la ficha.
        /// </summary>
        public enum Punto
        {
            Cero, Uno, Dos, Tres, Cuatro, Cinco, Seis, NoAsignado
        }
        /// <summary>
        /// Variable que almacena el primer valor de la ficha.
        /// </summary>
        /// <remarks>
        /// Es de tipo enumerado Punto. Puede ser modificada.
        /// </remarks>
        public Punto puntosArriba;
        /// <summary>
        /// Variable que almacena el segundo valor de la ficha.
        /// </summary>
        /// <remarks>
        /// Es de tipo enumerado Punto. Puede ser modificada.
        /// </remarks>
        public Punto puntosAbajo;
        /// <summary>
        /// Constructor del struct
        /// </summary>
        /// <param name="cadena"></param>
        /// <remarks>
        /// Mediante una expresión regular comprueba si la cadena coincide con el patrón indicado. Si es así,
        /// asigna los valores a las variables puntosArriba y puntosAbajo.
        ///</remarks>
        public Ficha(string cadena)
        {
            string patron = @"cero|uno|dos|tres|cuatro|cinco|seis|[0-6]";
            string patron2 = @"\s?,\s?";

            Regex patronFicha = new Regex($@"^(?<puntosArriba>{patron}){patron2}(?<puntosAbajo>{patron})$", RegexOptions.IgnoreCase);
            Match match = patronFicha.Match(cadena);

            if (match.Success)
            {
                puntosArriba = (Punto)Enum.Parse(typeof(Punto), match.Groups["puntosArriba"].Value, true);
                puntosAbajo = (Punto)Enum.Parse(typeof(Punto), match.Groups["puntosAbajo"].Value, true);
            }
            else
            {
                puntosArriba = Punto.NoAsignado;
                puntosAbajo = Punto.NoAsignado;
            }
        }
        /// <summary>
        /// Invalida el método ToString()
        /// </summary>
        /// <returns>Devuelve una cadena string para imprimir por pantalla la Ficha.</returns>
        public override string ToString()
        {
            if (puntosAbajo == Punto.NoAsignado || puntosArriba == Punto.NoAsignado)
                return "Ficha no válida";
            string cadena = "╔═════════════════╗\n";
            cadena += $"║ {puntosArriba,-6} ♦ {puntosAbajo,6} ║";
            cadena += "\n╚═════════════════╝";
            return cadena;
        }
    }
}
