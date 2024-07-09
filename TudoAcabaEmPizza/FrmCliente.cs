using MySqlX.XDevAPI;
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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Cliente cliente = new(
                txtNome.Text,
                dtpDatanasc.Value,
                mskCpf.Text,
                txtEmail.Text,
                txtSenha.Text);
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                MessageBox.Show($"Cliente {cliente.GetHashCode()} cadastro com sucesso");
            }
        }

        private void buSalvar_Click(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(int clienteId)
        {
            var listaEnderecos = Endereco.ObterListaPorCliente(clienteId);
            int count = 0;
            // Preenche o DataGridView com todos os endereços
            dgvEnderecos.Rows.Clear();
            foreach (var endereco in listaEnderecos)
            {
                int rowIndex = dgvEnderecos.Rows.Add();
                dgvEnderecos.Rows[count].Cells[0].Value = endereco.Cep;
                dgvEnderecos.Rows[count].Cells[1].Value = endereco.Logradouro;
                dgvEnderecos.Rows[count].Cells[2].Value = endereco.Numero;
                dgvEnderecos.Rows[count].Cells[3].Value = endereco.Complemento;
                dgvEnderecos.Rows[count].Cells[4].Value = endereco.Bairro;
                dgvEnderecos.Rows[count].Cells[5].Value = endereco.Cidade;
                dgvEnderecos.Rows[count].Cells[6].Value = endereco.Uf;
                dgvEnderecos.Rows[count].Cells[7].Value = endereco.TipoEnderecos;
                count++;
            }
        }

        private void btnInserirTelefone_Click(object sender, EventArgs e)
        {
            mskDdi.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskDdd.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskNumeroTelefone.TextMaskFormat= MaskFormat.ExcludePromptAndLiterals;

            Telefone telefone = new(
                mskDdi.Text
                ,mskDdd.Text
                , mskNumeroTelefone.Text
                ,TipoTelefone.ObterPorId(Convert.ToInt32(cmbTipoTelefone.SelectedValue))
                ,Convert.ToInt32(txtClienteId.Text)
                );

            telefone.Inserir();
            if (telefone.Id > 0)
            {
                MessageBox.Show($"O telefone {telefone.Numero} foi cadastrado com sucesso");
            }


        }
    }
}
