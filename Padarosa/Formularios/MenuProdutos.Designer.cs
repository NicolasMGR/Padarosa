namespace Padarosa.Formularios
{
    partial class MenuProdutos
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.lblProdutocad = new System.Windows.Forms.Label();
            this.lblPrecocad = new System.Windows.Forms.Label();
            this.lblCategoriacad = new System.Windows.Forms.Label();
            this.txtprodutocad = new System.Windows.Forms.TextBox();
            this.txtprecocad = new System.Windows.Forms.TextBox();
            this.cmbcategoriacad = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cmbCategoriaedi = new System.Windows.Forms.ComboBox();
            this.txtPrecoedi = new System.Windows.Forms.TextBox();
            this.txtProdutoedi = new System.Windows.Forms.TextBox();
            this.lblCategoriaedi = new System.Windows.Forms.Label();
            this.lblPrecoedi = new System.Windows.Forms.Label();
            this.lblProdutoedi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 47);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(520, 178);
            this.dgvProdutos.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(70, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(389, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gerenciamento dos produtos";
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.cmbcategoriacad);
            this.grbCadastrar.Controls.Add(this.txtprecocad);
            this.grbCadastrar.Controls.Add(this.txtprodutocad);
            this.grbCadastrar.Controls.Add(this.lblCategoriacad);
            this.grbCadastrar.Controls.Add(this.lblPrecocad);
            this.grbCadastrar.Controls.Add(this.lblProdutocad);
            this.grbCadastrar.Location = new System.Drawing.Point(12, 243);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(217, 195);
            this.grbCadastrar.TabIndex = 2;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar:";
            // 
            // lblProdutocad
            // 
            this.lblProdutocad.AutoSize = true;
            this.lblProdutocad.Location = new System.Drawing.Point(21, 35);
            this.lblProdutocad.Name = "lblProdutocad";
            this.lblProdutocad.Size = new System.Drawing.Size(47, 13);
            this.lblProdutocad.TabIndex = 0;
            this.lblProdutocad.Text = "Produto:";
            // 
            // lblPrecocad
            // 
            this.lblPrecocad.AutoSize = true;
            this.lblPrecocad.Location = new System.Drawing.Point(30, 70);
            this.lblPrecocad.Name = "lblPrecocad";
            this.lblPrecocad.Size = new System.Drawing.Size(38, 13);
            this.lblPrecocad.TabIndex = 1;
            this.lblPrecocad.Text = "Preço:";
            // 
            // lblCategoriacad
            // 
            this.lblCategoriacad.AutoSize = true;
            this.lblCategoriacad.Location = new System.Drawing.Point(13, 107);
            this.lblCategoriacad.Name = "lblCategoriacad";
            this.lblCategoriacad.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriacad.TabIndex = 2;
            this.lblCategoriacad.Text = "Categoria:";
            // 
            // txtprodutocad
            // 
            this.txtprodutocad.Location = new System.Drawing.Point(75, 35);
            this.txtprodutocad.Name = "txtprodutocad";
            this.txtprodutocad.Size = new System.Drawing.Size(121, 20);
            this.txtprodutocad.TabIndex = 3;
            // 
            // txtprecocad
            // 
            this.txtprecocad.Location = new System.Drawing.Point(75, 70);
            this.txtprecocad.Name = "txtprecocad";
            this.txtprecocad.Size = new System.Drawing.Size(121, 20);
            this.txtprecocad.TabIndex = 4;
            // 
            // cmbcategoriacad
            // 
            this.cmbcategoriacad.FormattingEnabled = true;
            this.cmbcategoriacad.Location = new System.Drawing.Point(75, 107);
            this.cmbcategoriacad.Name = "cmbcategoriacad";
            this.cmbcategoriacad.Size = new System.Drawing.Size(121, 21);
            this.cmbcategoriacad.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(16, 134);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(180, 55);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.cmbCategoriaedi);
            this.groupBox1.Controls.Add(this.txtPrecoedi);
            this.groupBox1.Controls.Add(this.txtProdutoedi);
            this.groupBox1.Controls.Add(this.lblCategoriaedi);
            this.groupBox1.Controls.Add(this.lblPrecoedi);
            this.groupBox1.Controls.Add(this.lblProdutoedi);
            this.groupBox1.Location = new System.Drawing.Point(315, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 195);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar:";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(16, 134);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(180, 55);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // cmbCategoriaedi
            // 
            this.cmbCategoriaedi.FormattingEnabled = true;
            this.cmbCategoriaedi.Location = new System.Drawing.Point(75, 107);
            this.cmbCategoriaedi.Name = "cmbCategoriaedi";
            this.cmbCategoriaedi.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoriaedi.TabIndex = 5;
            // 
            // txtPrecoedi
            // 
            this.txtPrecoedi.Location = new System.Drawing.Point(75, 70);
            this.txtPrecoedi.Name = "txtPrecoedi";
            this.txtPrecoedi.Size = new System.Drawing.Size(121, 20);
            this.txtPrecoedi.TabIndex = 4;
            // 
            // txtProdutoedi
            // 
            this.txtProdutoedi.Location = new System.Drawing.Point(75, 35);
            this.txtProdutoedi.Name = "txtProdutoedi";
            this.txtProdutoedi.Size = new System.Drawing.Size(121, 20);
            this.txtProdutoedi.TabIndex = 3;
            // 
            // lblCategoriaedi
            // 
            this.lblCategoriaedi.AutoSize = true;
            this.lblCategoriaedi.Location = new System.Drawing.Point(13, 107);
            this.lblCategoriaedi.Name = "lblCategoriaedi";
            this.lblCategoriaedi.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaedi.TabIndex = 2;
            this.lblCategoriaedi.Text = "Categoria:";
            // 
            // lblPrecoedi
            // 
            this.lblPrecoedi.AutoSize = true;
            this.lblPrecoedi.Location = new System.Drawing.Point(30, 70);
            this.lblPrecoedi.Name = "lblPrecoedi";
            this.lblPrecoedi.Size = new System.Drawing.Size(38, 13);
            this.lblPrecoedi.TabIndex = 1;
            this.lblPrecoedi.Text = "Preço:";
            // 
            // lblProdutoedi
            // 
            this.lblProdutoedi.AutoSize = true;
            this.lblProdutoedi.Location = new System.Drawing.Point(21, 35);
            this.lblProdutoedi.Name = "lblProdutoedi";
            this.lblProdutoedi.Size = new System.Drawing.Size(47, 13);
            this.lblProdutoedi.TabIndex = 0;
            this.lblProdutoedi.Text = "Produto:";
            // 
            // MenuProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "MenuProdutos";
            this.Text = "MenuProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.ComboBox cmbcategoriacad;
        private System.Windows.Forms.TextBox txtprecocad;
        private System.Windows.Forms.TextBox txtprodutocad;
        private System.Windows.Forms.Label lblCategoriacad;
        private System.Windows.Forms.Label lblPrecocad;
        private System.Windows.Forms.Label lblProdutocad;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cmbCategoriaedi;
        private System.Windows.Forms.TextBox txtPrecoedi;
        private System.Windows.Forms.TextBox txtProdutoedi;
        private System.Windows.Forms.Label lblCategoriaedi;
        private System.Windows.Forms.Label lblPrecoedi;
        private System.Windows.Forms.Label lblProdutoedi;
    }
}