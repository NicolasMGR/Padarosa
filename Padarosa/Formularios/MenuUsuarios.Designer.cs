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
            this.btnCadastrarcad = new System.Windows.Forms.Button();
            this.txtSenhacad = new System.Windows.Forms.TextBox();
            this.txtEmailcad = new System.Windows.Forms.TextBox();
            this.txtnomecad = new System.Windows.Forms.TextBox();
            this.lblSenhacad = new System.Windows.Forms.Label();
            this.lblEmailcad = new System.Windows.Forms.Label();
            this.lblNomeCompletocad = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.txtsenhaedi = new System.Windows.Forms.TextBox();
            this.txtemailedi = new System.Windows.Forms.TextBox();
            this.txtnomeedi = new System.Windows.Forms.TextBox();
            this.lblsenhaedi = new System.Windows.Forms.Label();
            this.lblemailedi = new System.Windows.Forms.Label();
            this.lblnomeedi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(1, 53);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(591, 183);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(92, 9);
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
            this.grbCadastro.Size = new System.Drawing.Size(214, 145);
            this.grbCadastro.TabIndex = 2;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro:";
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
            this.btnCadastrarcad.Click += new System.EventHandler(this.btnCadastrarcad_Click);
            // 
            // txtSenhacad
            // 
            this.txtSenhacad.Location = new System.Drawing.Point(89, 71);
            this.txtSenhacad.Name = "txtSenhacad";
            this.txtSenhacad.Size = new System.Drawing.Size(120, 20);
            this.txtSenhacad.TabIndex = 5;
            // 
            // txtEmailcad
            // 
            this.txtEmailcad.Location = new System.Drawing.Point(89, 44);
            this.txtEmailcad.Name = "txtEmailcad";
            this.txtEmailcad.Size = new System.Drawing.Size(120, 20);
            this.txtEmailcad.TabIndex = 4;
            // 
            // txtnomecad
            // 
            this.txtnomecad.Location = new System.Drawing.Point(89, 17);
            this.txtnomecad.Name = "txtnomecad";
            this.txtnomecad.Size = new System.Drawing.Size(120, 20);
            this.txtnomecad.TabIndex = 3;
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
            // lblEmailcad
            // 
            this.lblEmailcad.AutoSize = true;
            this.lblEmailcad.Location = new System.Drawing.Point(57, 47);
            this.lblEmailcad.Name = "lblEmailcad";
            this.lblEmailcad.Size = new System.Drawing.Size(35, 13);
            this.lblEmailcad.TabIndex = 1;
            this.lblEmailcad.Text = "Email:";
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
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btneditar);
            this.grbEditar.Controls.Add(this.txtsenhaedi);
            this.grbEditar.Controls.Add(this.txtemailedi);
            this.grbEditar.Controls.Add(this.txtnomeedi);
            this.grbEditar.Controls.Add(this.lblsenhaedi);
            this.grbEditar.Controls.Add(this.lblemailedi);
            this.grbEditar.Controls.Add(this.lblnomeedi);
            this.grbEditar.Location = new System.Drawing.Point(362, 242);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(215, 145);
            this.grbEditar.TabIndex = 7;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar:";
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(6, 98);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(203, 33);
            this.btneditar.TabIndex = 6;
            this.btneditar.Text = "EDITAR";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txtsenhaedi
            // 
            this.txtsenhaedi.Location = new System.Drawing.Point(89, 71);
            this.txtsenhaedi.Name = "txtsenhaedi";
            this.txtsenhaedi.Size = new System.Drawing.Size(120, 20);
            this.txtsenhaedi.TabIndex = 5;
            // 
            // txtemailedi
            // 
            this.txtemailedi.Location = new System.Drawing.Point(89, 44);
            this.txtemailedi.Name = "txtemailedi";
            this.txtemailedi.Size = new System.Drawing.Size(120, 20);
            this.txtemailedi.TabIndex = 4;
            // 
            // txtnomeedi
            // 
            this.txtnomeedi.Location = new System.Drawing.Point(89, 17);
            this.txtnomeedi.Name = "txtnomeedi";
            this.txtnomeedi.Size = new System.Drawing.Size(120, 20);
            this.txtnomeedi.TabIndex = 3;
            // 
            // lblsenhaedi
            // 
            this.lblsenhaedi.AutoSize = true;
            this.lblsenhaedi.Location = new System.Drawing.Point(51, 74);
            this.lblsenhaedi.Name = "lblsenhaedi";
            this.lblsenhaedi.Size = new System.Drawing.Size(41, 13);
            this.lblsenhaedi.TabIndex = 2;
            this.lblsenhaedi.Text = "Senha:";
            // 
            // lblemailedi
            // 
            this.lblemailedi.AutoSize = true;
            this.lblemailedi.Location = new System.Drawing.Point(57, 47);
            this.lblemailedi.Name = "lblemailedi";
            this.lblemailedi.Size = new System.Drawing.Size(35, 13);
            this.lblemailedi.TabIndex = 1;
            this.lblemailedi.Text = "Email:";
            // 
            // lblnomeedi
            // 
            this.lblnomeedi.AutoSize = true;
            this.lblnomeedi.Location = new System.Drawing.Point(7, 20);
            this.lblnomeedi.Name = "lblnomeedi";
            this.lblnomeedi.Size = new System.Drawing.Size(85, 13);
            this.lblnomeedi.TabIndex = 0;
            this.lblnomeedi.Text = "Nome Completo:";
            // 
            // MenuUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 391);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "MenuUsuarios";
            this.Text = "Gerenciamentos de usuarios";
            this.Load += new System.EventHandler(this.MenuUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.TextBox txtsenhaedi;
        private System.Windows.Forms.TextBox txtemailedi;
        private System.Windows.Forms.TextBox txtnomeedi;
        private System.Windows.Forms.Label lblsenhaedi;
        private System.Windows.Forms.Label lblemailedi;
        private System.Windows.Forms.Label lblnomeedi;
    }
}