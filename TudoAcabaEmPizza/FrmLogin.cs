using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAEPClass;

namespace TudoAcabaEmPizza
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);
                if (usuario == null)
                {
                    MessageBox.Show("Email e/ou senha inválidos!");
                }
                else if (usuario.Id > 0 )
                {
                    Program.Usuario = usuario;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email e/ou senha inválidos!");

                }
            }
            else
            {
                MessageBox.Show("Digite um Email e Senha para prosseguir!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
