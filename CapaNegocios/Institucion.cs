using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    class Institucion
    {
        #region Declaracion de Constructor 
        public Institucion() { }
        #endregion
        
        #region Declaracion de Metodos


        public DataTable LeerInstitucion(int pInstitucion)
        {
            DataTable dtResultado = new DataTable();
            CapaDatos.Institucion vNegocio = new CapaDatos.Institucion();
            try
            {
                dtResultado = vNegocio.LeerInstitucion(pInstitucion);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dtResultado;
        }

        #endregion
    }
}
