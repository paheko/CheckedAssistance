using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarCodigos.DTO
{
    public class DTOCatecismo
    {
        public int id_catecismo { set; get; }
        public string catecismo { set; get; }

        public DTOCatecismo() { }

        public DTOCatecismo(int id_catecismo, string catecismo) 
        {
            this.id_catecismo = id_catecismo;
            this.catecismo = catecismo;            
        }
    }
}
