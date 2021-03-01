using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgramacionUno.Dominio
{
    class UsuarioOperaciones
    {
     private const double iva = 0.13;
     private const String nombreDelProducto = "LAPTOP";
        private double precioDelProducto;
        private int cantidad;

        public static double Iva => iva;

        public static string NombreDelProducto => nombreDelProducto;

        public double PrecioDelProducto { get => precioDelProducto; set => precioDelProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}  
