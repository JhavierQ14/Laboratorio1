using LaboratorioProgramacionUno.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgramacionUno.Negocio
{
    class ClsOperacionUsuario
    {

        

        public Double ca1(UsuarioOperaciones operacion )
        {
            Double total1 = (operacion.PrecioDelProducto * operacion.Cantidad);

            return total1;
        }

        public Double ca2(UsuarioOperaciones operacion)
        {
            Double total2 = (operacion.PrecioDelProducto * operacion.Cantidad) + (operacion.Iva * operacion.PrecioDelProducto);

            return total2;
        }

        public String ca3(UsuarioOperaciones operacion)
        {
            String nombreP =  operacion.NombreDelProducto ;

            return nombreP;
        }

        public double ca4(UsuarioOperaciones operacion)
        {
            double ivaAgregar = operacion.Iva * operacion.PrecioDelProducto;

            return ivaAgregar;
        }
    }
}
