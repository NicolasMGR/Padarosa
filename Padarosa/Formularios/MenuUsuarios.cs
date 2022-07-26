using LibPadarosa;
using System;
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
    public partial class MenuUsuarios : Form
    {
        //Objetos globais:

        private Usuario _u;
        private int _idSelecionado;

        public MenuUsuarios(Usuario u)
        {
            InitializeComponent();
            _u = u;
            //Carregar dados do bd para o dgv:
            AtualizarDgv();
        }
        private void AtualizarDgv()
        {
            dgvUsuarios.DataSource = Banco.UsuarioDAO.ListarTudo();
        }

        private void MenuUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarcad_Click(object sender, EventArgs e)
        {
            var u = new Usuario();
            var valida = txtnomecad.Text.Length > 5 && txtEmailcad.Text.Length >= 6 && txtSenhacad.Text.Length >= 6;
            if (valida)
            {
                u.NomeCompleto = txtnomecad.Text;
                u.Email = txtEmailcad.Text;
                u.Senha = txtSenhacad.Text;
                //Chamar o cadastrar
                if (Banco.UsuarioDAO.Cadastrar(u) == true)
                {
                    MessageBox.Show("Usuário Cadastrado!");
                    //Limpar os campos:
                    txtnomecad.Clear();
                    txtEmailcad.Clear();
                    txtSenhacad.Clear();
                    //Atualizar o dgv:
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Houve um erro no cadastro!");
                }

            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas");
            }

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Descobrir o número da célula clicada:
            int numeroLinha = dgvUsuarios.CurrentCell.RowIndex;
            //Guardar toda a linha em um objeto DataRow:
            var linha = dgvUsuarios.Rows[numeroLinha];
            txtnomeedi.Text = linha.Cells[1].Value.ToString();
            txtemailedi.Text = linha.Cells[2].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            var u = new Usuario();
            u.NomeCompleto = txtnomeedi.Text;
            u.Email = txtemailedi.Text;
            u.Senha = txtsenhaedi.Text;
            u.Id = _idSelecionado;

            //Chamar modificar:
            if (Banco.UsuarioDAO.Modificar(u))
            {
                MessageBox.Show("Usuário modificado com sucesso!");
                //Limpar os campos:
                txtnomeedi.Clear();
                txtemailedi.Clear();
                txtsenhaedi.Clear();
                //Atualizar o dgv:
                AtualizarDgv();
                grbEditar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas!");
            }

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }   
}
