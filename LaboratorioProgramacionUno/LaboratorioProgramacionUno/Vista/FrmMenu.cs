using LaboratorioProgramacionUno.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioProgramacionUno
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        
   
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            //FrmOperaciones operacionesU = new FrmOperaciones();  verificar despues
            //operacionesU.evaluarUsuario = true;
            FrmLogin frml = new FrmLogin();
            frml.rolUsuario = true;
            frml.Show();
            this.Hide();

        }

        
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            
            FrmLogin frml = new FrmLogin();
            frml.rolAdministrador = true;
            frml.Show();
            this.Hide();           
            {

            }


        }
    }
       
}



