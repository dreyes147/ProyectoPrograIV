using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class Credito
    {
        #region Declaracion de Variables
        CapaDatos.Credito vNegocio;
        #endregion
        #region Declaracion de Constructor 
        public Credito()
        {
            vNegocio = new CapaDatos.Credito();
        }
        #endregion

        #region Declaracion de Metodos


        public DataTable Select()
        {
            DataTable dtResultado = new DataTable();
            
            try
            {
                dtResultado = vNegocio.Select();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dtResultado;
        }


        public void Insert(CapaEntidad.Estructura.Credito pDatos)
        {
            DataTable dtResultado = new DataTable();

            try
            {
                vNegocio.Insert(pDatos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Delete(CapaEntidad.Estructura.Credito pDatos)
        {
            DataTable dtResultado = new DataTable();

            try
            {
              vNegocio.Delete(pDatos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Update(CapaEntidad.Estructura.Credito pDatos)
        {
            DataTable dtResultado = new DataTable();

            try
            {
               vNegocio.Update(pDatos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion
    }
}
