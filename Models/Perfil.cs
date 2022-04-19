using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Perfil
    {
        private String login;
        private String plano_de_fundo;
        private String descricao;
        private String valor;
        private String cor;
        private String imagem;


        public String Image
        {
            get { return imagem; }
            set { imagem = value; }
        }

        public String Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public String Login
        {
            get { return login; }
            set { login = value; }
        }

        public String Plano_de_Fundo
        {
            get { return plano_de_fundo; }
            set { plano_de_fundo = value; }
        }

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public String Valor
        {
            get { return valor; }
            set { valor = value; }
        }

    }
}
