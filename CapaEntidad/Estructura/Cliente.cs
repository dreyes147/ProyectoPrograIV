using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Estructura
{
    public class Cliente
    {

        #region Declaracion de atributos

        private int vIdCliente;
        private string vNombre;
        private string vApellido1;
        private string vApellido2;
        private int vIdInstitucion;

        #endregion

        #region Declaracion de Constructor

        public Cliente()
        {
        }
        #endregion

        #region Declaracion de Propiedades

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

        public string Nombre
        {
            get
            {
                return vNombre;
            }
            set
            {
                vNombre = value;
            }
        }

        public string Apellido1
        {
            get
            {
                return vApellido1;
            }
            set
            {
                vApellido1 = value;
            }
        }

        public string Apellido2
        {
            get
            {
                return vApellido2;
            }
            set
            {
                vApellido2 = value;
            }
        }

        public int IdInstitucion
        {
            get
            {
                return vIdInstitucion;
            }
            set
            {
                vIdInstitucion = value;
            }
        }


        #endregion

    }
}
