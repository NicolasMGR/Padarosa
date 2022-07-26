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
    public partial class MenuPrincipal : Form { 

        //UObjeto global:
         private Usuario _u;
    
        public MenuPrincipal(Usuario u)
        {
            InitializeComponent();
            _u = u;
            lblFrase.Text = "Olá, " + u.NomeCompleto + "! Escolha uma opção:";
            //Ocultar o botão de usuario de todos, exceto do adm:
            if(u.Id != 1)
            {
                btnUsuarios.Visible = false;
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnComanda_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            var menuusuarios = new MenuUsuarios(_u);
            menuusuarios.ShowDialog();
            
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            var menuprodutos = new MenuProdutos1(_u);
            menuprodutos.ShowDialog();
        }
    }
}
