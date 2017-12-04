using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class Cliente
    {
        #region Declaracion de Constructor 
        public Cliente() { }
        #endregion

        #region Declaracion de Metodos

        public DataTable LeerCliente(int pIdCliente)
        {
            DataTable dtResultado = new DataTable();
            CapaDatos.Cliente vDatos = new CapaDatos.Cliente();
            try
            {
                dtResultado = vDatos.LeerCliente(pIdCliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dtResultado;
        }

        public DataTable Select()
        {
            DataTable dtResultado = new DataTable();
            CapaDatos.Cliente vDatos = new CapaDatos.Cliente();
            try
            {
                dtResultado = vDatos.Select();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dtResultado;
        }

        public void Update(CapaEntidad.Estructura.Cliente pDatos)
        {
            CapaDatos.Cliente vDatos = new CapaDatos.Cliente();
            try
            {
               vDatos.Update(pDatos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }


        public void Insert(CapaEntidad.Estructura.Cliente pDatos)
        {
            CapaDatos.Cliente vDatos = new CapaDatos.Cliente();
            try
            {
                vDatos.Insert(pDatos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }


        public void Delete(CapaEntidad.Estructura.Cliente pDatos)
        {
            CapaDatos.Cliente vDatos = new CapaDatos.Cliente();
            try
            {
                vDatos.Delete(pDatos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        #endregion
    }
}
