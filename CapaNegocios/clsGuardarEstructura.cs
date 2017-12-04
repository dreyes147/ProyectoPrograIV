using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class clsGuardarEstructura
    {
        public void InsertarEstructura(string pData, int pID)
        {
            CapaDatos.clsGuardarEstructura GuardarDGV = new CapaDatos.clsGuardarEstructura();
             GuardarDGV.InsertarEstructura(pData,pID);
        }
    }
}
