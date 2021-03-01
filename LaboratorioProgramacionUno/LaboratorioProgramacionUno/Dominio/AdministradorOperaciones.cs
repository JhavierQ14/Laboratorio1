using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgramacionUno.Dominio
{
    class AdministradorOperaciones
    {
        private double iva;
        private String nombreDelProducto;
        private double precioDelProducto;
        private int cantidad;

        public double Iva { get => iva; set => iva = value; }
        public string NombreDelProducto { get => nombreDelProducto; set => nombreDelProducto = value; }
        public double PrecioDelProducto { get => precioDelProducto; set => precioDelProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
