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

        public Double cal2(AdministradorOperaciones administrador)
        {
            Double total2 = (administrador.PrecioDelProducto * administrador.Cantidad) + (administrador.Iva * administrador.PrecioDelProducto);

            return total2;
        }

        public String cal3(AdministradorOperaciones administrador)
        {
            String nombreP = administrador.NombreDelProducto;

            return nombreP ;
        }

        public double cal4(AdministradorOperaciones administrador)
        {
            double ivaAgregar = administrador.Iva * administrador.PrecioDelProducto;

            return ivaAgregar;
        }
    }

}
