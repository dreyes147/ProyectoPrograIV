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

        #endregion
    }
}
