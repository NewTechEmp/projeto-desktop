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
    public partial class FrmTipoEndereco : Form
    {
        public FrmTipoEndereco()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            TipoEndereco tipoEndereco = new TipoEndereco(
                txtNome.Text
                , txtSigla.Text
                );
            tipoEndereco.Inserir();
            FrmTipoEndereco_Load(sender, e);
            
        }

        private void FrmTipoEndereco_Load(object sender, EventArgs e)
        {
            var lista = TipoEndereco.ObterLista();
            dgvTipoEndereco.Rows.Clear();
            int count = 0;
            btnEditar.Enabled = false;
            foreach (var tipoEndereco in lista)
            {
                dgvTipoEndereco.Rows.Add();
                dgvTipoEndereco.Rows[count].Cells[0].Value = tipoEndereco.Id;
                dgvTipoEndereco.Rows[count].Cells[1].Value = tipoEndereco.Descricao;
                dgvTipoEndereco.Rows[count].Cells[2].Value =tipoEndereco.Sigla;


                count++;
            }
        }
    }
}
