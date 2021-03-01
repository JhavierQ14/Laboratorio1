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
    public partial class FrmLoginUsuario : Form
    {
        public FrmLoginUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtP_Click(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            Login log = new Login();

            log.NombreUsuario = txtUsuario.Text;
            log.Password = txtContra.Text;

            ClsLoginUser clsl = new ClsLoginUser();

            int evalucion = clsl.acceso(log);

            if (evalucion == 1)

              
            {

                MessageBox.Show("Welcome");
                FrmOpers frmM = new FrmOpers();
                frmM.namePerson = txtUsuario.Text;
                frmM.Show();
                this.Hide();

            }
            else {
                MessageBox.Show("No se encuentra en el sistema");

            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
