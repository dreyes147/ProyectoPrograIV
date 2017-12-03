using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Estructura
{
    public class Planilla
    {

        #region Declaracion de atributos

        private int vIdLote;
        private int vIdCliente;
        private DateTime vFechaCorte;
        private int vIdCredito;
        private decimal vCuotaCobrada;
        private decimal vCuotaPaga;
        private decimal vSaldoPendiente;
        private decimal vAmortizacion;
        private decimal vIntereses;
        private string vEstadoPlanilla;

        #endregion
        #region Declaracion de Constructor

        public Planilla()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public int IdLote
        {
            get
            {
                return vIdLote;
            }
            set
            {
                vIdLote = value;
            }
        }

        public int IdCliente
        {
            get
            {
                return vIdCliente;
            }
            set
            {
                vIdCliente = value;
            }
        }

        public DateTime FechaCorte
        {
            get
            {
                return vFechaCorte;
            }
            set
            {
                vFechaCorte = value;
            }
        }

        public int IdCredito
        {
            get
            {
                return vIdCredito;
            }
            set
            {
                vIdCredito = value;
            }
        }

        public decimal CuotaCobrada
        {
            get
            {
                return vCuotaCobrada;
            }
            set
            {
                vCuotaCobrada = value;
            }
        }

        public decimal CuotaPaga
        {
            get
            {
                return vCuotaPaga;
            }
            set
            {
                vCuotaPaga = value;
            }
        }

        public decimal SaldoPendiente
        {
            get
            {
                return vSaldoPendiente;
            }
            set
            {
                vSaldoPendiente = value;
            }
        }

        public decimal Amortizacion
        {
            get
            {
                return vAmortizacion;
            }
            set
            {
                vAmortizacion = value;
            }
        }

        public decimal Intereses
        {
            get
            {
                return vIntereses;
            }
            set
            {
                vIntereses = value;
            }
        }

        public string EstadoPlanilla
        {
            get
            {
                return vEstadoPlanilla;
            }
            set
            {
                vEstadoPlanilla = value;
            }
        }


        #endregion

    }
}
