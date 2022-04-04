using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CotizacionDolarLibrary.DTO;

namespace CotizacionDolar.Models
{
    public class CotizacionDolarModel
    {
        public DateTime fecha { get; set; }

        public Decimal cotizacionVenta { get; set; }

        public Decimal cotizacionCompra { get; set; }

        public CotizacionDolarModel(CotizacionDolarDTO cot)
        {
            this.fecha = cot.fecha;
            this.cotizacionCompra = cot.compra;
            this.cotizacionVenta = cot.venta;
        }
    }

    
}
