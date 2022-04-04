using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizacionDolarLibrary.DTO
{
    public class CotizacionDolarDTO
    {
        public DateTime fecha { get; set; }

        public Decimal compra { get; set; }

        public Decimal venta { get; set; }
    }
}
