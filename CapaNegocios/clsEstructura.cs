using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class clsEstructura
    {
        public DataTable CargarEstructura()
        {
            CapaDatos.clsEstructura CargarDGV = new CapaDatos.clsEstructura();
            return CargarDGV.CargarPlanilla();
        }
    }
}
