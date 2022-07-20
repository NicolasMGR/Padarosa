using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa
{
    public partial class LoginPadarosa : Form
    {
        public LoginPadarosa()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Verificar tamanho do email e senha digitados:
            if(txtEmail.Text.Length <= 3 && txtSenha.Text.Length <= 3)
            {
                MessageBox.Show("Verifique as informações digitadas!");
            }
            else
            {
                var u = new LibPadarosa.Usuario();
                u.Email= txtEmail.Text;
                u.Senha= txtSenha.Text;
                var resultado =Banco.UsuarioDAO.Logar(u);
                //Verificar se o banco retornou algum dado:
                if(resultado.Rows.Count == 0)
                {
                    MessageBox.Show("Usuário ou senha incorreto.");
                }
                else
                {
                    //Continuar o progama:
                    //Guardar as informções vindas do bd:
                    u.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                    u.Id = int.Parse(resultado.Rows[0]["id"].ToString());
                    //Abrir a janela:
                    var menuprincipal = new Formularios.MenuPrincipal(u);
                    //Esconder janela atual:
                    Hide();
                    //Mostrar a nova:
                    menuprincipal.ShowDialog();
                    //Ao sair da anterior, mostrar novamente:
                    Show();
                    //Limpar campos de e-mail e senha:
                    txtEmail.Clear();
                    txtSenha.Clear();
                }
            }
        }
    }
}
