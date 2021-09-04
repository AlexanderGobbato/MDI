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
    public partial class frmTesteMouse : Form
    {
        public frmTesteMouse()
        {
            InitializeComponent();
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmTesteMouse_MouseMove(object sender, MouseEventArgs e)
        {
            txtX.Text = MousePosition.X.ToString();
            txtY.Text = MousePosition.Y.ToString();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            int resposta;
            resposta = Convert.ToInt32(MessageBox.Show("Mensagem ....",
                        "Título da Mensagem", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));

            MessageBox.Show(resposta.ToString());

            if (resposta == 6)
            {
                //sim
            }else if (resposta == 7)
            {
                //não
            }
            else
            {
                //cancelar
            }
        }

        private void btnGravar2_Click(object sender, EventArgs e)
        {
            String mensagem = "Pretende continuar?";
            String titulo = "Decisão";
            MessageBoxButtons botoes = MessageBoxButtons.YesNoCancel;
            DialogResult resposta;

            resposta = MessageBox.Show(mensagem, titulo, botoes);

            if(resposta == System.Windows.Forms.DialogResult.Yes)
            {

            }else if(resposta == System.Windows.Forms.DialogResult.No)
            {

            }
            else
            {

            }
        }
    }
}
