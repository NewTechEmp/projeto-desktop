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
    public partial class FrmTipoBorda : Form
    {
        public FrmTipoBorda()
        {
            InitializeComponent();
        }

        private void FrmTipoBorda_Load(object sender, EventArgs e)
        {
            var lista = TipoBorda.ObterLista();
            dgvTipoBorda.Rows.Clear();
            int count = 0;
            btnEditar.Enabled = false;
            foreach (var tipoBorda in lista)
            {
                dgvTipoBorda.Rows.Add();
                dgvTipoBorda.Rows[count].Cells[0].Value = tipoBorda.Id;
                dgvTipoBorda.Rows[count].Cells[0].Value = tipoBorda.Descricao;
                dgvTipoBorda.Rows[count].Cells[0].Value = tipoBorda.Valor;


                count++;

            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            TipoBorda tipoBorda = new(txtDescricao.Text, double.Parse(txtPreco.Text));
            tipoBorda.Inserir();
            if (tipoBorda.Id > 0)
            {
                MessageBox.Show($"O tipo {tipoBorda.Descricao} foi inserido com sucesso.");
            }
        }

        private void btnObterPorId_Click(object sender, EventArgs e)
        {
            if (btnObterPorId.Text == "&Consultar")
            {
                txtDescricao.Clear();
                txtPreco.Clear();
                txtId.ReadOnly = false;
                txtId.Focus();
                btnObterPorId.Text = "&Obter por ID";
            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    Categoria categoria = Categoria.ObterPorId(int.Parse(txtId.Text));
                    txtCategoriaNome.Text = categoria.Nome;
                    txtSigla.Text = categoria.Sigla;
                    txtId.ReadOnly = true;
                    btnConsultar.Text = "&Consultar";
                    btnEditar.Enabled = true;

                }
            }
        }
    }
}
