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
              Usuario.ObterPorId(Convert.ToInt32(txtUsuarioId.Text))
               , dtpDatanasc.Value
               ,mskCpf.Text
               );
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                MessageBox.Show($"Cliente {cliente.GetHashCode()} cadastrado com sucesso");
            }
        }

        private void buSalvar_Click(object sender, EventArgs e)
        {
            mskCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskUf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Endereco endereco = new(
                int.Parse(txtEnderecoClienteId.Text),
                 mskCep.Text,
                 txtLogradouro.Text,
                 txtNumero.Text,
                 txtComplemento.Text,
                 txtBairro.Text,
                 txtCidade.Text,
                 mskUf.Text,
                 TipoEndereco.ObterPorId(Convert.ToInt32(cmbTipoEndereco.SelectedValue))

                 );
            endereco.Inserir();
            FrmCliente_Load(int.Parse(txtEnderecoClienteId.Text));

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
            mskNumeroTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            Telefone telefone = new(
                mskDdi.Text
                , mskDdd.Text
                , mskNumeroTelefone.Text
                , int.Parse(txtClienteTelefoneId.Text)
                , TipoTelefone.ObterPorId(Convert.ToInt32(cmbTipoTelefone.SelectedValue))

                );

            telefone.Inserir();
            if (telefone.Id > 0)
            {
                MessageBox.Show($"O telefone {telefone.Numero} foi cadastrado com sucesso");
            }


        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            if (btnConsultarCliente.Text == "&Consultar")
            {
                txtUsuarioId.Clear();
                mskCpf.Clear();
                txtId.ReadOnly = false;
                txtId.Focus();
                btnConsultarCliente.Text = "&Obter por ID";
            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    Cliente cliente = Cliente.ObterPorId(int.Parse(txtId.Text));
                    Usuario usuario = Usuario.ObterPorId(int.Parse(txtUsuarioId.Text));
                    mskCpf.Text = cliente.Cpf;
                    txtId.ReadOnly = true;
                    btnConsultarCliente.Text = "&Consultar";
                    btnEditarCliente.Enabled = true;

                }
            }
        }

        private void btnConsultarEndereco_Click(object sender, EventArgs e)
        {
            if (btnConsultarEndereco.Text == "&Consultar")
            {
                mskCep.Clear();
                txtLogradouro.Clear();
                txtComplemento.Clear();
                txtEnderecoClienteId.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtNumero.Clear();
                txtIdEndereco.ReadOnly = false;
                txtIdEndereco.Focus();
                btnConsultarEndereco.Text = "&Obter por ID";
            }
            else
            {
                if (txtIdEndereco.Text.Length > 0)
                {
                    Endereco endereco = Endereco.ObterPorId(int.Parse(txtIdEndereco.Text));
                    mskCep.Text = endereco.Cep;
                    txtLogradouro.Text = endereco.Logradouro;
                    txtComplemento.Text = endereco.Complemento;
                    
                    txtBairro.Text = endereco.Bairro;
                    txtCidade.Text = endereco.Cidade;
                    txtNumero.Text = endereco.Numero;


                    txtIdEndereco.ReadOnly = true;
                    btnConsultarEndereco.Text = "&Consultar";
                    btnEditarEndereco.Enabled = true;

                }
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            var tipoEndereco = TipoEndereco.ObterLista();
            cmbTipoEndereco.DataSource = tipoEndereco;
            cmbTipoEndereco.DisplayMember = "descricao";
            cmbTipoEndereco.ValueMember = "id";
        }

        private void tbpDadosCliente_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
