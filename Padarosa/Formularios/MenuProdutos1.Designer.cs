namespace Padarosa.Formularios
{
    partial class MenuProdutos1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.btnCadastar = new System.Windows.Forms.Button();
            this.cmbcategoriacad = new System.Windows.Forms.ComboBox();
            this.txtprecocad = new System.Windows.Forms.TextBox();
            this.txtprodutocad = new System.Windows.Forms.TextBox();
            this.lblCategoriacad = new System.Windows.Forms.Label();
            this.lblPrecocad = new System.Windows.Forms.Label();
            this.lblProdutocad = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cmbCategoriaedi = new System.Windows.Forms.ComboBox();
            this.txtPrecoedi = new System.Windows.Forms.TextBox();
            this.txtProdutoedi = new System.Windows.Forms.TextBox();
            this.lblCategoriaedi = new System.Windows.Forms.Label();
            this.lblPrecoedi = new System.Windows.Forms.Label();
            this.lblProdutoedi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(203, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(374, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gerenciamento de produtos";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(1, 43);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(754, 233);
            this.dgvProdutos.TabIndex = 1;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.btnCadastar);
            this.grbCadastro.Controls.Add(this.cmbcategoriacad);
            this.grbCadastro.Controls.Add(this.txtprecocad);
            this.grbCadastro.Controls.Add(this.txtprodutocad);
            this.grbCadastro.Controls.Add(this.lblCategoriacad);
            this.grbCadastro.Controls.Add(this.lblPrecocad);
            this.grbCadastro.Controls.Add(this.lblProdutocad);
            this.grbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastro.Location = new System.Drawing.Point(1, 282);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(263, 171);
            this.grbCadastro.TabIndex = 2;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastrar:";
            // 
            // btnCadastar
            // 
            this.btnCadastar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastar.Location = new System.Drawing.Point(6, 119);
            this.btnCadastar.Name = "btnCadastar";
            this.btnCadastar.Size = new System.Drawing.Size(251, 46);
            this.btnCadastar.TabIndex = 6;
            this.btnCadastar.Text = "CADASTRAR";
            this.btnCadastar.UseVisualStyleBackColor = true;
            this.btnCadastar.Click += new System.EventHandler(this.btnCadastar_Click);
            // 
            // cmbcategoriacad
            // 
            this.cmbcategoriacad.FormattingEnabled = true;
            this.cmbcategoriacad.Location = new System.Drawing.Point(95, 89);
            this.cmbcategoriacad.Name = "cmbcategoriacad";
            this.cmbcategoriacad.Size = new System.Drawing.Size(162, 24);
            this.cmbcategoriacad.TabIndex = 5;
            // 
            // txtprecocad
            // 
            this.txtprecocad.Location = new System.Drawing.Point(95, 54);
            this.txtprecocad.Name = "txtprecocad";
            this.txtprecocad.Size = new System.Drawing.Size(162, 22);
            this.txtprecocad.TabIndex = 4;
            // 
            // txtprodutocad
            // 
            this.txtprodutocad.Location = new System.Drawing.Point(95, 19);
            this.txtprodutocad.Name = "txtprodutocad";
            this.txtprodutocad.Size = new System.Drawing.Size(162, 22);
            this.txtprodutocad.TabIndex = 3;
            this.txtprodutocad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCategoriacad
            // 
            this.lblCategoriacad.AutoSize = true;
            this.lblCategoriacad.Location = new System.Drawing.Point(20, 92);
            this.lblCategoriacad.Name = "lblCategoriacad";
            this.lblCategoriacad.Size = new System.Drawing.Size(69, 16);
            this.lblCategoriacad.TabIndex = 2;
            this.lblCategoriacad.Text = "Categoria:";
            // 
            // lblPrecocad
            // 
            this.lblPrecocad.AutoSize = true;
            this.lblPrecocad.Location = new System.Drawing.Point(43, 57);
            this.lblPrecocad.Name = "lblPrecocad";
            this.lblPrecocad.Size = new System.Drawing.Size(46, 16);
            this.lblPrecocad.TabIndex = 1;
            this.lblPrecocad.Text = "Preço:";
            // 
            // lblProdutocad
            // 
            this.lblProdutocad.AutoSize = true;
            this.lblProdutocad.Location = new System.Drawing.Point(32, 25);
            this.lblProdutocad.Name = "lblProdutocad";
            this.lblProdutocad.Size = new System.Drawing.Size(57, 16);
            this.lblProdutocad.TabIndex = 0;
            this.lblProdutocad.Text = "Produto:";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.cmbCategoriaedi);
            this.grbEditar.Controls.Add(this.txtPrecoedi);
            this.grbEditar.Controls.Add(this.txtProdutoedi);
            this.grbEditar.Controls.Add(this.lblCategoriaedi);
            this.grbEditar.Controls.Add(this.lblPrecoedi);
            this.grbEditar.Controls.Add(this.lblProdutoedi);
            this.grbEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.Location = new System.Drawing.Point(482, 282);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(263, 171);
            this.grbEditar.TabIndex = 6;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar:";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(6, 119);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(251, 46);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cmbCategoriaedi
            // 
            this.cmbCategoriaedi.FormattingEnabled = true;
            this.cmbCategoriaedi.Location = new System.Drawing.Point(95, 89);
            this.cmbCategoriaedi.Name = "cmbCategoriaedi";
            this.cmbCategoriaedi.Size = new System.Drawing.Size(162, 24);
            this.cmbCategoriaedi.TabIndex = 5;
            // 
            // txtPrecoedi
            // 
            this.txtPrecoedi.Location = new System.Drawing.Point(95, 54);
            this.txtPrecoedi.Name = "txtPrecoedi";
            this.txtPrecoedi.Size = new System.Drawing.Size(162, 22);
            this.txtPrecoedi.TabIndex = 4;
            // 
            // txtProdutoedi
            // 
            this.txtProdutoedi.Location = new System.Drawing.Point(95, 19);
            this.txtProdutoedi.Name = "txtProdutoedi";
            this.txtProdutoedi.Size = new System.Drawing.Size(162, 22);
            this.txtProdutoedi.TabIndex = 3;
            // 
            // lblCategoriaedi
            // 
            this.lblCategoriaedi.AutoSize = true;
            this.lblCategoriaedi.Location = new System.Drawing.Point(20, 92);
            this.lblCategoriaedi.Name = "lblCategoriaedi";
            this.lblCategoriaedi.Size = new System.Drawing.Size(69, 16);
            this.lblCategoriaedi.TabIndex = 2;
            this.lblCategoriaedi.Text = "Categoria:";
            // 
            // lblPrecoedi
            // 
            this.lblPrecoedi.AutoSize = true;
            this.lblPrecoedi.Location = new System.Drawing.Point(43, 57);
            this.lblPrecoedi.Name = "lblPrecoedi";
            this.lblPrecoedi.Size = new System.Drawing.Size(46, 16);
            this.lblPrecoedi.TabIndex = 1;
            this.lblPrecoedi.Text = "Preço:";
            // 
            // lblProdutoedi
            // 
            this.lblProdutoedi.AutoSize = true;
            this.lblProdutoedi.Location = new System.Drawing.Point(32, 25);
            this.lblProdutoedi.Name = "lblProdutoedi";
            this.lblProdutoedi.Size = new System.Drawing.Size(57, 16);
            this.lblProdutoedi.TabIndex = 0;
            this.lblProdutoedi.Text = "Produto:";
            // 
            // MenuProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 465);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "MenuProdutos";
            this.Text = "MenuProdutos";
            this.Load += new System.EventHandler(this.MenuProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.TextBox txtprodutocad;
        private System.Windows.Forms.Label lblCategoriacad;
        private System.Windows.Forms.Label lblPrecocad;
        private System.Windows.Forms.Label lblProdutocad;
        private System.Windows.Forms.Button btnCadastar;
        private System.Windows.Forms.ComboBox cmbcategoriacad;
        private System.Windows.Forms.TextBox txtprecocad;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cmbCategoriaedi;
        private System.Windows.Forms.TextBox txtPrecoedi;
        private System.Windows.Forms.TextBox txtProdutoedi;
        private System.Windows.Forms.Label lblCategoriaedi;
        private System.Windows.Forms.Label lblPrecoedi;
        private System.Windows.Forms.Label lblProdutoedi;
    }
}