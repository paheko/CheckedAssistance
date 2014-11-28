using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarCodigos
{
    public class DTOAlumnos
    {
        public string codigo {set;get;}
        public string Nombre { set; get; }
        public string grado { set; get; }
        public string catecismo { set; get; }


        public DTOAlumnos() { }
        public DTOAlumnos(string codigo, string nombre, string grado, string catecismo) 
        {
            this.codigo = codigo;
            this.Nombre = nombre;
            this.grado = grado;
            this.catecismo = catecismo;
        }

    }
}
