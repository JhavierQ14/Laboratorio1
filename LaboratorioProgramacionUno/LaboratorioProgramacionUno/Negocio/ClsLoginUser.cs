using LaboratorioProgramacionUno.DAO;
using LaboratorioProgramacionUno.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgramacionUno.Negocio
{
    class ClsLoginUser
    {
        Login log = new Login();
        ClsListUsuarios Cls = new ClsListUsuarios();
        public int acceso(Login log)
        {
            int estado = 0;
            for (int i = 0; i < Cls.user.Length; i++)
            {
                if (log.NombreUsuario.Equals(Cls.user[i]) && log.Password.Equals(Cls.pass[i]))
                    estado = 1;
                {

                }
            }
            return estado;
        }

    }

}

