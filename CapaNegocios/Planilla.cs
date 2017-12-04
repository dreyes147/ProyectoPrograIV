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

        public DataTable LeerPlanilla (int pIdCredito)
        {
            DataTable dtResultado = new DataTable();
            CapaDatos.Planilla vDatos = new CapaDatos.Planilla();
            try
            {
                dtResultado = vDatos.LeerPlanilla(pIdCredito);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return dtResultado;
        }


        public DataTable LeerExcel(string filename, string sheetName)
        {
            DataTable dtResultado = new DataTable();
            CapaDatos.Planilla vDatos = new CapaDatos.Planilla();
            try
            {
                dtResultado = vDatos.LeerExcel(filename, sheetName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return dtResultado;
        }

        public void Insert (CapaEntidad.Estructura.Planilla pDatos)
        {
            CapaDatos.Planilla vDatos = new CapaDatos.Planilla();
            try
            {
                vDatos.Insert(pDatos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion
    }
}
