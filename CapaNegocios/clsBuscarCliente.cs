using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class clsBuscarCliente
    {
        public DataTable SeleccionarCliente(int ID)
        {
            CapaDatos.clsBuscarCliente SeleccionarCliente = new CapaDatos.clsBuscarCliente();
            return SeleccionarCliente.SeleccionarCliente(ID);
        }

       
    }
}
