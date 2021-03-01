using LaboratorioProgramacionUno.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgramacionUno.Negocio
{
    class ClsOperacionAdministrador
    {
        AdministradorOperaciones adminOperacion = new AdministradorOperaciones();

        public Double cal1(AdministradorOperaciones administrador)
        {
            Double total1 = (administrador.PrecioDelProducto * administrador.Cantidad);

            return total1;
        }

    }
}
