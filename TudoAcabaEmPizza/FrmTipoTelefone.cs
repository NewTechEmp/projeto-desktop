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
    public partial class FrmTipoTelefone : Form
    {
        public FrmTipoTelefone()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            TipoTelefone tipoTelefone = new(txtNome.Text, txtSigla.Text);
            tipoTelefone.Inserir();
            FrmTipoTelefone_Load(sender, e);
        }

        private void FrmTipoTelefone_Load(object sender, EventArgs e)
        {
            var lista = TipoTelefone.ObterLista();
            dgvtipoTelefone.Rows.Clear();
            int count = 0;
            btnEditar.Enabled = false;
            foreach (var tipoTelefone in lista)
            {
                dgvtipoTelefone.Rows.Add();
                dgvtipoTelefone.Rows[count].Cells[0].Value = tipoTelefone.Id;
                dgvtipoTelefone.Rows[count].Cells[1].Value = tipoTelefone.Descricao;
                dgvtipoTelefone.Rows[count].Cells[2].Value = tipoTelefone.Sigla;


                count++;
            }
        }
    }
}
