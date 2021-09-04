
namespace WinFormsApp4
{
    partial class frmEmpregado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDadosEmpregado = new System.Windows.Forms.GroupBox();
            this.lblIdadeSelecionada = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.trkIdade = new System.Windows.Forms.TrackBar();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpDadosAtualizados = new System.Windows.Forms.GroupBox();
            this.lblIdadeAtualizado = new System.Windows.Forms.Label();
            this.lblNomeAtualizado = new System.Windows.Forms.Label();
            this.grpDadosEmpregado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkIdade)).BeginInit();
            this.grpDadosAtualizados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDadosEmpregado
            // 
            this.grpDadosEmpregado.Controls.Add(this.lblIdadeSelecionada);
            this.grpDadosEmpregado.Controls.Add(this.btnAtualizar);
            this.grpDadosEmpregado.Controls.Add(this.trkIdade);
            this.grpDadosEmpregado.Controls.Add(this.txtNome);
            this.grpDadosEmpregado.Controls.Add(this.lblIdade);
            this.grpDadosEmpregado.Controls.Add(this.lblNome);
            this.grpDadosEmpregado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpDadosEmpregado.Location = new System.Drawing.Point(53, 29);
            this.grpDadosEmpregado.Name = "grpDadosEmpregado";
            this.grpDadosEmpregado.Size = new System.Drawing.Size(381, 166);
            this.grpDadosEmpregado.TabIndex = 0;
            this.grpDadosEmpregado.TabStop = false;
            this.grpDadosEmpregado.Text = "Dados Empregados";
            // 
            // lblIdadeSelecionada
            // 
            this.lblIdadeSelecionada.AutoSize = true;
            this.lblIdadeSelecionada.Location = new System.Drawing.Point(77, 102);
            this.lblIdadeSelecionada.Name = "lblIdadeSelecionada";
            this.lblIdadeSelecionada.Size = new System.Drawing.Size(0, 15);
            this.lblIdadeSelecionada.TabIndex = 5;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(157, 124);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // trkIdade
            // 
            this.trkIdade.Location = new System.Drawing.Point(77, 73);
            this.trkIdade.Maximum = 130;
            this.trkIdade.Minimum = 1;
            this.trkIdade.Name = "trkIdade";
            this.trkIdade.Size = new System.Drawing.Size(266, 45);
            this.trkIdade.TabIndex = 3;
            this.trkIdade.Value = 1;
            this.trkIdade.Scroll += new System.EventHandler(this.trkIdade_Scroll);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(266, 23);
            this.txtNome.TabIndex = 2;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(27, 73);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(39, 15);
            this.lblIdade.TabIndex = 1;
            this.lblIdade.Text = "Idade:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(27, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // grpDadosAtualizados
            // 
            this.grpDadosAtualizados.Controls.Add(this.lblIdadeAtualizado);
            this.grpDadosAtualizados.Controls.Add(this.lblNomeAtualizado);
            this.grpDadosAtualizados.Location = new System.Drawing.Point(53, 211);
            this.grpDadosAtualizados.Name = "grpDadosAtualizados";
            this.grpDadosAtualizados.Size = new System.Drawing.Size(381, 100);
            this.grpDadosAtualizados.TabIndex = 1;
            this.grpDadosAtualizados.TabStop = false;
            this.grpDadosAtualizados.Text = "Dados Atualizados";
            // 
            // lblIdadeAtualizado
            // 
            this.lblIdadeAtualizado.AutoSize = true;
            this.lblIdadeAtualizado.Location = new System.Drawing.Point(27, 57);
            this.lblIdadeAtualizado.Name = "lblIdadeAtualizado";
            this.lblIdadeAtualizado.Size = new System.Drawing.Size(39, 15);
            this.lblIdadeAtualizado.TabIndex = 1;
            this.lblIdadeAtualizado.Text = "Idade:";
            // 
            // lblNomeAtualizado
            // 
            this.lblNomeAtualizado.AutoSize = true;
            this.lblNomeAtualizado.Location = new System.Drawing.Point(27, 28);
            this.lblNomeAtualizado.Name = "lblNomeAtualizado";
            this.lblNomeAtualizado.Size = new System.Drawing.Size(43, 15);
            this.lblNomeAtualizado.TabIndex = 0;
            this.lblNomeAtualizado.Text = "Nome:";
            // 
            // frmEmpregado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 336);
            this.Controls.Add(this.grpDadosAtualizados);
            this.Controls.Add(this.grpDadosEmpregado);
            this.Name = "frmEmpregado";
            this.Text = "frmEmpregado";
            this.Load += new System.EventHandler(this.frmEmpregado_Load);
            this.grpDadosEmpregado.ResumeLayout(false);
            this.grpDadosEmpregado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkIdade)).EndInit();
            this.grpDadosAtualizados.ResumeLayout(false);
            this.grpDadosAtualizados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosEmpregado;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TrackBar trkIdade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox grpDadosAtualizados;
        private System.Windows.Forms.Label lblIdadeAtualizado;
        private System.Windows.Forms.Label lblNomeAtualizado;
        private System.Windows.Forms.Label lblIdadeSelecionada;
    }
}