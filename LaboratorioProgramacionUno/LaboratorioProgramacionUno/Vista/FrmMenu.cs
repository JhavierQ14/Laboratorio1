﻿using LaboratorioProgramacionUno.Vista;
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

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmLogin frml = new FrmLogin();
            frml.Show();
            this.Hide();
            int tipo = 0;
            {

            }


            //MessageBox.Show("Bienvenido");

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }

        }
       
    }
}
