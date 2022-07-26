using LibPadarosa;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa.Formularios
{
    public partial class MenuProdutos1 : Form
    {

        //Objetos Globais:
        private Usuario _u;
        int _idSelecionado;
      


        public MenuProdutos1(Usuario u)
        {
            InitializeComponent();
            _u = u;
            AtualizarDgv();
            var r = Banco.CategoriaDAO.ListarTudo();
            ArrayList rows = new ArrayList();
            foreach (DataRow dataRow in r.Rows)
            {
                rows.Add(string.Join(" - ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            // Atribuir os valores nos cmbs:
            cmbcategoriacad.DataSource = rows;
            cmbCategoriaedi.DataSource = rows.Clone();
            // Atribuir a tabela de produtos no dgv:
            dgvProdutos.DataSource = Banco.ProdutoDAO.ListarTudo();
        }

        private void MenuProdutos_Load(object sender, EventArgs e)
        {

        }

        private void grbEditar_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastar_Click(object sender, EventArgs e)
        {
            var p = new Produto();
            var valida = txtprodutocad.Text.Length >= 1;
            if (valida)
            {
                p.Nome = txtprodutocad.Text;
                p.Preco = double.Parse(txtprecocad.Text);
                p.IdCategoria = obterIDdaString(cmbcategoriacad.Text);
                p.IdRespCadastro = _u.Id;
                
            }

            if (Banco.ProdutoDAO.Cadastrar(p) == true)
            {
                MessageBox.Show("Produto Cadastrado!");
                //Limpar os campos:
                txtprodutocad.Clear();
                txtprecocad.Clear();               
                //Atualizar o dgv:
                AtualizarDgv();
            }
            else
            {
                MessageBox.Show("Houve um erro no cadastro!");
            }

        }
        private int obterIDdaString(string texto)
        {
            /* Ao chamar obterIDdaString("12 - Alimentação")
             * o resultador será 12
             * Show?
             */
            return int.Parse(texto.Split(' ')[0]);
        }
        private void AtualizarDgv()
        {
            dgvProdutos.DataSource = Banco.ProdutoDAO.ListarTudo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var p = new Produto();
            p.Nome = txtProdutoedi.Text;
            p.Preco = double.Parse(txtPrecoedi.Text);
            p.IdCategoria = obterIDdaString(cmbCategoriaedi.Text);
            p.Id = _idSelecionado;
            if (Banco.ProdutoDAO.Modificar(p))
            {
                MessageBox.Show("Produto modificado com sucesso!");
                //Limpar os campos:
                txtProdutoedi.Clear();
                txtPrecoedi.Clear();               
                //Atualizar o dgv:
                AtualizarDgv();
                grbEditar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas!");
            }


        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Descobrir o número da célula clicada:
            int numeroLinha = dgvProdutos.CurrentCell.RowIndex;
            //Guardar toda a linha em um objeto DataRow:
            var linha = dgvProdutos.Rows[numeroLinha];
            txtProdutoedi.Text = linha.Cells[1].Value.ToString();
            txtPrecoedi.Text = linha.Cells[2].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());
        }
    }
}
