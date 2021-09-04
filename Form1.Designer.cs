
namespace WinFormsApp4
{
    partial class frmTesteMouse
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.chk = new System.Windows.Forms.CheckBox();
            this.cboFrutas = new System.Windows.Forms.ComboBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnGravar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(237, 51);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 23);
            this.txtX.TabIndex = 0;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(237, 81);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 23);
            this.txtY.TabIndex = 1;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(170, 58);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(61, 15);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "Posição X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(170, 88);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(61, 15);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "Posição Y:";
            // 
            // chk
            // 
            this.chk.AutoSize = true;
            this.chk.Location = new System.Drawing.Point(34, 127);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(83, 19);
            this.chk.TabIndex = 5;
            this.chk.Text = "checkBox1";
            this.chk.UseVisualStyleBackColor = true;
            // 
            // cboFrutas
            // 
            this.cboFrutas.FormattingEnabled = true;
            this.cboFrutas.Items.AddRange(new object[] {
            "Pera",
            "Uva",
            "Maça",
            "Salada Mista"});
            this.cboFrutas.Location = new System.Drawing.Point(115, 169);
            this.cboFrutas.Name = "cboFrutas";
            this.cboFrutas.Size = new System.Drawing.Size(121, 23);
            this.cboFrutas.TabIndex = 6;
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 15;
            this.lstItems.Items.AddRange(new object[] {
            "Opção 1",
            "Opção 2",
            "...",
            "Opção 1",
            "Opção 2",
            "...",
            "Opção 1",
            "Opção 2",
            "...",
            "Opção 1",
            "Opção 2",
            "...",
            "Opção 1",
            "Opção 2",
            "..."});
            this.lstItems.Location = new System.Drawing.Point(389, 112);
            this.lstItems.Name = "lstItems";
            this.lstItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstItems.Size = new System.Drawing.Size(120, 94);
            this.lstItems.TabIndex = 7;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3"});
            this.checkedListBox1.Location = new System.Drawing.Point(263, 127);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 8;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(87, 253);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 9;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnGravar2
            // 
            this.btnGravar2.Location = new System.Drawing.Point(183, 253);
            this.btnGravar2.Name = "btnGravar2";
            this.btnGravar2.Size = new System.Drawing.Size(75, 23);
            this.btnGravar2.TabIndex = 10;
            this.btnGravar2.Text = "Gravar 2";
            this.btnGravar2.UseVisualStyleBackColor = true;
            this.btnGravar2.Click += new System.EventHandler(this.btnGravar2_Click);
            // 
            // frmTesteMouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 288);
            this.Controls.Add(this.btnGravar2);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.cboFrutas);
            this.Controls.Add(this.chk);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Name = "frmTesteMouse";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmTesteMouse_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.CheckBox chk;
        private System.Windows.Forms.ComboBox cboFrutas;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnGravar2;
    }
}

