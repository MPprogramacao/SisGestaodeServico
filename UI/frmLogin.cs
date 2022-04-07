using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            MessageBox.Show("Teste", "Ok");
        }
    }
}
