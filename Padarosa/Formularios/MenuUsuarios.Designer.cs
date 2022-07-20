namespace Padarosa.Formularios
{
    partial class MenuUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.lblNomeCompletocad = new System.Windows.Forms.Label();
            this.lblEmailcad = new System.Windows.Forms.Label();
            this.lblSenhacad = new System.Windows.Forms.Label();
            this.txtnomecad = new System.Windows.Forms.TextBox();
            this.txtEmailcad = new System.Windows.Forms.TextBox();
            this.txtSenhacad = new System.Windows.Forms.TextBox();
            this.btnCadastrarcad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 53);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(776, 183);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(198, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(371, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gerenciamento de usuários";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.btnCadastrarcad);
            this.grbCadastro.Controls.Add(this.txtSenhacad);
            this.grbCadastro.Controls.Add(this.txtEmailcad);
            this.grbCadastro.Controls.Add(this.txtnomecad);
            this.grbCadastro.Controls.Add(this.lblSenhacad);
            this.grbCadastro.Controls.Add(this.lblEmailcad);
            this.grbCadastro.Controls.Add(this.lblNomeCompletocad);
            this.grbCadastro.Location = new System.Drawing.Point(12, 242);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(215, 145);
            this.grbCadastro.TabIndex = 2;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro:";
            // 
            // lblNomeCompletocad
            // 
            this.lblNomeCompletocad.AutoSize = true;
            this.lblNomeCompletocad.Location = new System.Drawing.Point(7, 20);
            this.lblNomeCompletocad.Name = "lblNomeCompletocad";
            this.lblNomeCompletocad.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCompletocad.TabIndex = 0;
            this.lblNomeCompletocad.Text = "Nome Completo:";
            // 
            // lblEmailcad
            // 
            this.lblEmailcad.AutoSize = true;
            this.lblEmailcad.Location = new System.Drawing.Point(57, 47);
            this.lblEmailcad.Name = "lblEmailcad";
            this.lblEmailcad.Size = new System.Drawing.Size(35, 13);
            this.lblEmailcad.TabIndex = 1;
            this.lblEmailcad.Text = "Email:";
            // 
            // lblSenhacad
            // 
            this.lblSenhacad.AutoSize = true;
            this.lblSenhacad.Location = new System.Drawing.Point(51, 74);
            this.lblSenhacad.Name = "lblSenhacad";
            this.lblSenhacad.Size = new System.Drawing.Size(41, 13);
            this.lblSenhacad.TabIndex = 2;
            this.lblSenhacad.Text = "Senha:";
            // 
            // txtnomecad
            // 
            this.txtnomecad.Location = new System.Drawing.Point(89, 17);
            this.txtnomecad.Name = "txtnomecad";
            this.txtnomecad.Size = new System.Drawing.Size(120, 20);
            this.txtnomecad.TabIndex = 3;
            // 
            // txtEmailcad
            // 
            this.txtEmailcad.Location = new System.Drawing.Point(89, 44);
            this.txtEmailcad.Name = "txtEmailcad";
            this.txtEmailcad.Size = new System.Drawing.Size(120, 20);
            this.txtEmailcad.TabIndex = 4;
            // 
            // txtSenhacad
            // 
            this.txtSenhacad.Location = new System.Drawing.Point(89, 71);
            this.txtSenhacad.Name = "txtSenhacad";
            this.txtSenhacad.Size = new System.Drawing.Size(120, 20);
            this.txtSenhacad.TabIndex = 5;
            // 
            // btnCadastrarcad
            // 
            this.btnCadastrarcad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarcad.Location = new System.Drawing.Point(6, 98);
            this.btnCadastrarcad.Name = "btnCadastrarcad";
            this.btnCadastrarcad.Size = new System.Drawing.Size(203, 33);
            this.btnCadastrarcad.TabIndex = 6;
            this.btnCadastrarcad.Text = "CADASTRAR";
            this.btnCadastrarcad.UseVisualStyleBackColor = true;
            // 
            // MenuUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "MenuUsuarios";
            this.Text = "Gerenciamentos de usuarios";
            this.Load += new System.EventHandler(this.MenuUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Button btnCadastrarcad;
        private System.Windows.Forms.TextBox txtSenhacad;
        private System.Windows.Forms.TextBox txtEmailcad;
        private System.Windows.Forms.TextBox txtnomecad;
        private System.Windows.Forms.Label lblSenhacad;
        private System.Windows.Forms.Label lblEmailcad;
        private System.Windows.Forms.Label lblNomeCompletocad;
    }
}