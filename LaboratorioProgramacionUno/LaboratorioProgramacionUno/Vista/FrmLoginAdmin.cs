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
    public partial class FrmLoginAdmin : Form
    {
        public FrmLoginAdmin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            log.NombreUsuario = txtUsuario.Text;
            log.Password = txtContra.Text;

            ClsLoginAdmin clsl = new ClsLoginAdmin();

            int evalucion = clsl.acceso(log);

            if (evalucion == 1)


            {

                MessageBox.Show("Welcome");
                FrmOperaciones frmM = new FrmOperaciones();
                frmM.nombrePersona = txtUsuario.Text;
                frmM.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("No se encuentra en el sistema");

            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
