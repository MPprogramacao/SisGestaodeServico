using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Models;
using DAL;

namespace UI
{
    public partial class frmPrincipal : Form
    {
        public string usuario;
        public int id_user;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void sair()
        {
            if (MessageBox.Show("Deseja sair do sistema", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Data: " + DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = "Hora: " + DateTime.Now.ToShortTimeString();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sair();
        }

        private void úteisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracao frmConfiguracao1 = new frmConfiguracao();
            frmConfiguracao1.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Bem-vindo(a) " + usuario + " !";

            SincBancos sincBancos = new SincBancos();
            sincBancos.Sinc_tb_login();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void exibirBarraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exibirBarraToolStripMenuItem.Checked)            
                toolStrip1.Show();            
            else            
                toolStrip1.Hide();           
        }

        private void corDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {           

            DialogResult dlg1 = new DialogResult();

            if(this.BackgroundImage != null)
            {
                dlg1 = MessageBox.Show("Deseja descartar o papel de parede atual?", "Cor de fundo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            };

            if((dlg1 == DialogResult.Yes) || (dlg1 == DialogResult.None))
            {
                colorDialog1.ShowDialog();
                this.BackColor = colorDialog1.Color;
                this.BackgroundImage = null;
            }
        }

        private void papelDeParedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Selecione a figura para o fundo";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Arquivos de Imagem|(*.bmp;*.jpg;*.gif)|Todos os arquivos|*.*";
            openFileDialog1.Multiselect = false;

            openFileDialog1.ShowDialog();
            

            if (openFileDialog1.FileName != "")
                this.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
