using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class Planilla
    {

        #region Declaracion de Constructor 
        public Planilla() { }
        #endregion

        #region Declaracion de Metodos

        public DataTable LeerPlanilla (int pIdPlanilla)
        {
            DataTable dtResultado = new DataTable();
            CapaDatos.Planilla vDatos = new CapaDatos.Planilla();
            try
            {
                dtResultado = vDatos.LeerPlanilla(pIdPlanilla);
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
