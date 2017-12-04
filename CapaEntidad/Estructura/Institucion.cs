using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Estructura
{
    public class Institucion
    {

        #region Declaracion de atributos

        private int vIdInstitucion;
        private string vNombreInstitucion;
        private int vIdLote;

        #endregion
        #region Declaracion de Constructor

        public Institucion()
        {
        }
        #endregion

        #region Declaracion de Propiedades

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

        public string NombreInstitucion
        {
            get
            {
                return vNombreInstitucion;
            }
            set
            {
                vNombreInstitucion = value;
            }
        }

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


        #endregion



    }
}
