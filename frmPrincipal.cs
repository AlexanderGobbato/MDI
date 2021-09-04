using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void empregadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpregado frmEmp;
            frmEmp = new frmEmpregado();
            frmEmp.MdiParent = this;
            frmEmp.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String mensagem = "Deseja finalizar?";
            String titulo = "Sistema";
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            MessageBoxIcon icone = MessageBoxIcon.Question;
            DialogResult resposta;

            resposta = MessageBox.Show(mensagem, titulo, botoes, icone);

            if (resposta == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }          
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
