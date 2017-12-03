using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Estructura
{
    class Credito
    {

        #region Declaracion de atributos

        private int vIdCredito;
        private int vIdCliente;
        private decimal vMontoAprobado;
        private int vTasa;
        private decimal vSaldo;
        private string vUltimaProyeccion;

        #endregion

        #region Declaracion de Constructor

        public Credito()
        {
        }
        #endregion

        #region Declaracion de Propiedades

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

        public decimal MontoAprobado
        {
            get
            {
                return vMontoAprobado;
            }
            set
            {
                vMontoAprobado = value;
            }
        }

        public int Tasa
        {
            get
            {
                return vTasa;
            }
            set
            {
                vTasa = value;
            }
        }

        public decimal Saldo
        {
            get
            {
                return vSaldo;
            }
            set
            {
                vSaldo = value;
            }
        }

        public string UltimaProyeccion
        {
            get
            {
                return vUltimaProyeccion;
            }
            set
            {
                vUltimaProyeccion = value;
            }
        }


        #endregion



    }
}
