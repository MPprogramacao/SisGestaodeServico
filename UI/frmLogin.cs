using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Models;
using BLL;

namespace UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            verificar();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                verificar();
            }
            
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                verificar();
            }
        }


        public void verificar()
        {
            /*
             if ((txtNome.Text != "") && (txtSenha.Text != ""))
              {
                  frmPrincipal principal = new frmPrincipal();
                  principal.usuario = txtNome.Text;
                  principal.Show();
                  this.Dispose();
              }                         
              else
                  MessageBox.Show("Todos os campos devem ser preenchidos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
          */

            try
            {
                Usuario usuario = new Usuario();
                usuario.Login = txtNome.Text;
                usuario.Senha = txtSenha.Text;

                LoginBLL usuarioBLL = new LoginBLL();

                if (usuarioBLL.verificaLogin(usuario)){
                    Login.User = usuario.Login;
                    frmPrincipal principal = new frmPrincipal();
                    principal.usuario = usuario.Login;
                    principal.Show();
                    this.Dispose(false);
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha incorreto! Tente novamente", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtNome.Text = "";
                    txtSenha.Text = "";
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
