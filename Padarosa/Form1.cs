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
                var resultado = LibPadarosa.Banco.UsuarioDAO.Logar(u);
                MessageBox.Show(resultado.Rows.Count.ToString());
            }
        }
    }
}
