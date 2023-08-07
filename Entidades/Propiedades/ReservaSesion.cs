using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class ReservaSesion
    {
        #region Propiedades & Getter/Setter
        public int IdReserva { get; set; }
        public int IdSede { get; set; }
        public string IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        #endregion
    }
}
