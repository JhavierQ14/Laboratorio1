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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public Boolean rolAdministrador;
        public Boolean rolUsuario;

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Boolean D = rolAdministrador;
            Boolean F = rolUsuario;
            if (D == true && F == false)
            {
                Login log = new Login();

                log.NombreUsuario = txtUsuario.Text;
                log.Password = txtContra.Text;

                ClsLoginAdmin clsl = new ClsLoginAdmin();

                int evalucion = clsl.acceso(log);

                if (evalucion == 1)

                {
                    MessageBox.Show("Welcome" + txtUsuario.Text);                    
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
            else
            {
                Login log = new Login();

                log.NombreUsuario = txtUsuario.Text;
                log.Password = txtContra.Text;

                ClsLoginUser clsl = new ClsLoginUser();

                int evalucion = clsl.acceso(log);

                if (evalucion == 1)


                {

                    MessageBox.Show("Welcome" + txtUsuario.Text);
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
        }

       
        
    }
}
