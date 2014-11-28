using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarCodigos.DTO
{
    public class DTOAsistencia
    {
        public string id { set; get; }
        public string codigo_alumno { set; get; }
        public DTOAsistencia() { }
        public DTOAsistencia(string id,string codigo_alumno) 
        {
            this.id = id;
            this.codigo_alumno = codigo_alumno;
        }
    }
}
