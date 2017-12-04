using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class clsCargarPlantilla
    {
        public DataTable CargarPlantilla(int a)
        {
            CapaDatos.clsCargarPlantilla SeleccionarCliente = new CapaDatos.clsCargarPlantilla();
            return SeleccionarCliente.CargarPlantilla(a);
        }



       
    }
}
