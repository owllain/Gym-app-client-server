using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class AfiliacionSede
    {
        #region Propiedades & Getter/Setter
        public int ID_Afiliacion { get; set; }
        public DateTime Fecha_Afiliacion { get; set; }
        public string IdCliente { get; set; }
        
        #endregion
    }
}
