using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgramacionUno.Dominio
{
    class UsuarioOperaciones : AdministradorOperaciones
    {
        private double iva = 0.13;
        private String nombreDelProducto = "LAPTOP";
        //private double precioDelProducto;
        //private int cantidad;


        //public double PrecioDelProducto { get => precioDelProducto; set => precioDelProducto = value; }
        //public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Iva { get => iva; set => iva = value; }
        public string NombreDelProducto { get => nombreDelProducto; set => nombreDelProducto = value; }
    }
}  
