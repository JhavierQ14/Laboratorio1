using LaboratorioProgramacionUno.Dominio;
using LaboratorioProgramacionUno.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioProgramacionUno.Vista
{
    public partial class FrmOperaciones : Form
    {
        public FrmOperaciones()
        {
            InitializeComponent();
        }
        public String nombrePersona;
        private void FrmOperaciones_Load(object sender, EventArgs e)
        {
           
            lblMostrarUser.Text = nombrePersona;

            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MENOR o IGUAL 50 NO TENDRA DESCUENTO", "<=50");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 50 Y MENOR QUE 100 TENDRA UN DESUENTO DEL 0.05 ", ">50 and <100");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL A 100 O MENOR QUE 101 TENDRA UN DESUENTO DEL 0.10 ", ">= 100 and <101");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL 101 Y MENOR QUE 150 TENDRA UN DESUENTO DEL 0.20 ", ">101 and <150");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 150 TENDRA UN DESUENTO DEL 0.50 ", ">150");

        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //try
            //{

            double multiplicarCantidad;

            multiplicarCantidad = Convert.ToDouble(txtPproducto.Text) * Convert.ToDouble(txtCantidad.Text);

            lblTsinIva.Text = multiplicarCantidad.ToString("0.00");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("TUS DATOS NO SON NUMERICOS REVISA" + ex.ToString());

            //AdministradorOperaciones administrador = new AdministradorOperaciones();
            //ClsOperacionAdministrador cls1 = new ClsOperacionAdministrador();

            //administrador.PrecioDelProducto = Convert.ToDouble(value: txtPproducto.Text);
            //administrador.Cantidad = Convert.ToDouble(value: txtCantidad.Text);
            //Double resultado1 = cls1.cal1(administrador);
            //lblTsinIva.Text = resultado1.ToString();
            //lblTotalIniacial.Text = resultado1.ToString() = txtIva.ToString;

            double sumarIva;

            sumarIva = (Convert.ToDouble(txtPproducto.Text) * Convert.ToDouble(txtCantidad.Text)) + Convert.ToDouble(txtIva.Text);

            lblTotalIniacial.Text = sumarIva.ToString("0.00");


            String nombre;
            nombre = txtNproducto.Text;
            lblNombreProducto.Text = nombre;

            //double iva;
            //iva = Convert.ToDouble(txtIva.Text);
            //lblMostrarIva.Text = iva.ToString ;


        }


        private void label2_Click(object sender, EventArgs e)
        {
 
        }
    }
}
