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
    public partial class frmEmpregado : Form
    {
        Empregado emp;
        public frmEmpregado()
        {
            InitializeComponent();
            emp = new Empregado();
        }

        private void trkIdade_Scroll(object sender, EventArgs e)
        {
            lblIdadeSelecionada.Text = trkIdade.Value.ToString();
        }

        private void frmEmpregado_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            emp.Nome = txtNome.Text;
            emp.Idade = Convert.ToInt32(trkIdade.Value);

            lblNomeAtualizado.Text = "Nome:";
            lblIdadeAtualizado.Text = "Idade: ";

            lblNomeAtualizado.Text = lblNomeAtualizado.Text + " " + emp.Nome;
            lblIdadeAtualizado.Text = lblIdadeAtualizado.Text + " " + emp.Idade;
        }
    }
}
