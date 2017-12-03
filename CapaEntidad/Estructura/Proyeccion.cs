using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Estructura
{
    public class Proyeccion
    {
        #region Declaracion de Constructor 
        public Proyeccion() { }
        #endregion

        #region Declaracion de Propiedades
        public int NumeroCuota { get; set; }
        public decimal MontoPrincipal { get; set; }
        public decimal Cuota { get; set; }
        public decimal Interes { get; set; }
        public decimal Pago { get; set; }
        public decimal Saldo { get; set; }
        public DateTime FechaCorte { get; set; }
        #endregion

    }
}
