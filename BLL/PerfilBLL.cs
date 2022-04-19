using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class PerfilBLL
    {
       public void SalvarCor(Perfil perfil)
        {
            perfil.Login = Login.User;
            PerfilDAL perfildall = new PerfilDAL();
            perfildall.SalvarCor(perfil);
        }

       public void SalvarImagem(Perfil perfil)
        {
            perfil.Login = Login.User;
            PerfilDAL perfilDAL = new PerfilDAL();
            perfilDAL.SalvarImagem(perfil);
        }

        public String VerificaCoreFundo(Perfil perfil)
        {
            PerfilDAL perfilDAL = new PerfilDAL();
            perfil.Login = Login.User;
            return perfilDAL.VerificarCoreFundo(perfil);
        }

        public String RetornarCoreFundo(Perfil perfil)
        {
            PerfilDAL perfilDAL = new PerfilDAL();
            perfil.Login = Login.User;
            return perfilDAL.RetornaCoreFundo(perfil);
        }
    }
}
