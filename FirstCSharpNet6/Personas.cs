using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharpNet6
{
    public class Personas
    {
        public int dni { get; set; }
        public string Nombre { get; set; }
        public int telefono { get; set; }
        public bool estado { get; set; }



        // Constructor con parámetros
        public Personas(int dni, string nombre, int telefono, bool estado)
        {
            this.dni = dni;
            this.Nombre = nombre;
            this.telefono = telefono;
            this.estado = estado;
        }

        // Constructor vacío
        public Personas()
        {
        }
    }
}
