using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class LoginBLL
    {
        public bool verificaLogin(Usuario usuario)
        {
            if(usuario.Login.Trim().Length == 0)            
                throw new Exception("Por favor, informe o seu usuário");


            if (usuario.Senha.Trim().Length == 0)
                throw new Exception("Por favor, informe a sua senha");

            usuario.Login = usuario.Login.ToUpper();

            LoginDAL usuarioDAL = new LoginDAL();
            return usuarioDAL.verificaLogin(usuario);
        }
    }
}
