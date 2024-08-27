using Google.Protobuf.WellKnownTypes;
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
        private void btnInserirUsuario_Click(object sender, EventArgs e)
        {
            Nivel nivel = Nivel.ObterPorDescricao("Cliente");
            int nivelId = nivel.Id;
            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Usuario usuario = new Usuario(
                txtNomeUsuario.Text,
                txtEmailUsuario.Text,
                txtSenhaUsuario.Text,
                Nivel.ObterPorId(nivelId)
            );
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                // limpando campos
                txtNomeUsuario.Clear();
                txtEmailUsuario.Clear();
                txtSenhaUsuario.Clear();
                // recuperando id do usuario
                txtIdUsuario.Text = usuario.Id.ToString();
                // inserindo cliente
                Cliente cliente = new(
                    Usuario.ObterPorId(Convert.ToInt32(txtIdUsuario.Text)),
                    mskCpf.Text,
                    dtpDatanasc.Value.Date
                 );
                cliente.Inserir();
                if (cliente.Id > 0)
                {
                    dtpDatanasc.Value = DateTime.Now;
                    mskCpf.Clear();
                    txtClienteId.Text = cliente.Id.ToString();
                    MessageBox.Show($"Cliente {usuario.GetHashCode()} cadastrado com sucesso");
                }
            }
        }
        private void buSalvar_Click(object sender, EventArgs e)
        {
            mskCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskUf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Endereco endereco = new(
                mskCep.Text,
                txtLogradouro.Text,
                txtNumero.Text,
                txtComplemento.Text,
                txtBairro.Text,
                txtCidade.Text,
                mskUf.Text,
                int.Parse(txtClienteId.Text),
                TipoEndereco.ObterPorId(Convert.ToInt32(cmbTipoEndereco.SelectedValue))
            );
            endereco.Inserir();
            FrmCliente_Load(int.Parse(txtClienteId.Text));
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
                dgvEnderecos.Rows[count].Cells[7].Value = endereco.TipoEnderecos.Descricao;
                count++;
            }
        }
        private void btnInserirTelefone_Click(object sender, EventArgs e)
        {
            mskDdi.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskDdd.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskNumeroTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            Telefone telefone = new(
                mskDdi.Text,
                mskDdd.Text,
                mskNumeroTelefone.Text,
                int.Parse(txtClienteId.Text),
                TipoTelefone.ObterPorId(Convert.ToInt32(cmbTipoTelefone.SelectedValue))
            );
            telefone.Inserir();
            if (telefone.Id > 0)
            {
                string telefoneCompleto = $"+{telefone.Ddi} ({telefone.Ddd}) {telefone.Numero}";
                MessageBox.Show($"O telefone {telefoneCompleto} foi cadastrado com sucesso");
            }
        }
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            var tipoEndereco = TipoEndereco.ObterLista();
            cmbTipoEndereco.DataSource = tipoEndereco;
            cmbTipoEndereco.DisplayMember = "descricao";
            cmbTipoEndereco.ValueMember = "id";

            var tipoTelefone = TipoTelefone.ObterLista();
            cmbTipoTelefone.DataSource = tipoTelefone;
            cmbTipoTelefone.DisplayMember = "descricao";
            cmbTipoTelefone.ValueMember = "id";
        }
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {

        }
        private void btnObterUsuarioPorId_Click(object sender, EventArgs e)
        {
            if (btnObterUsuarioPorId.Text == "&Consultar")
            {
                txtNomeUsuario.Clear();
                mskCpf.Clear();
                txtEmailUsuario.Clear();
                txtSenhaUsuario.Clear();
                txtIdUser.ReadOnly = false;
                txtIdUser.Focus();
                btnObterUsuarioPorId.Text = "&Buscar";
            }
            else
            {
                // realizar a busca dos dados do cliente
                Cliente cliente = Cliente.ObterPorId(int.Parse(txtIdUser.Text));
                txtNomeUsuario.Text = cliente.Usuario.Nome;
                txtEmailUsuario.Text = cliente.Usuario.Email;
                dtpDatanasc.Value = Convert.ToDateTime(cliente.DataNasc);
                mskCpf.Text = cliente.Cpf;
                // mudando text e desativando txtId
                txtIdUser.Enabled = false;
                txtSenhaUsuario.PlaceholderText = "[Digite uma senha caso queira mudar-la]";
                btnObterUsuarioPorId.Enabled = true;
            }
        } 
        private void mskCep_TextChanged(object sender, EventArgs e)
        {
            mskCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mskCep.Text.Length == 8)
            {
                WebCEP webCEP = new(mskCep.Text);
                txtLogradouro.Text = webCEP.TipoLagradouro + " " + webCEP.Lagradouro;
                txtBairro.Text = webCEP.Bairro;
                txtCidade.Text = webCEP.Cidade;
                mskUf.Text = webCEP.UF;
                txtNumero.Focus();
            }
        }

        private void dgvEnderecos_SelectionChanged(object sender, EventArgs e)
        {
            btnSalvarEndereco.Enabled = false;
            DataGridViewRow selectedRow = dgvEnderecos.SelectedRows[0];
            mskCep.Text = selectedRow.Cells[0].Value.ToString();
            mskCep.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txtLogradouro.Text = selectedRow.Cells[1].Value.ToString();
            txtNumero.Text = selectedRow.Cells[2].Value.ToString();
            txtComplemento.Text = selectedRow.Cells[3].Value.ToString();
            txtBairro.Text = selectedRow.Cells[4].Value.ToString();
            txtCidade.Text = selectedRow.Cells[5].Value.ToString();
            txtComplemento.Text = selectedRow.Cells[6].Value.ToString();
            cmbTipoEndereco.SelectedValue = selectedRow.Cells[7].Value.ToString();
        }
    }
}