using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic;
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
                    dtpDatanasc.Value.Date,
                    mskCpf.Text

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
            if (endereco.Id > 0)
            {
                mskCep.Clear();
                txtLogradouro.Clear();
                txtNumero.Clear();
                txtComplemento.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                mskUf.Clear();
                MessageBox.Show($"Endereço de Cep: \"{endereco.Cep} \" cadastrado com sucesso");
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
        private void CarregaGridEndereco(int clienteId)
        {
            var listaEnderecos = Endereco.ObterListaPorCliente(clienteId);
            int count = 0;
            // Preenche o DataGridView com todos os endereços
            dgvEnderecos.Rows.Clear();
            foreach (var endereco in listaEnderecos)
            {
                int rowIndex = dgvEnderecos.Rows.Add();
                dgvEnderecos.Rows[count].Cells[0].Value = endereco.Id;
                dgvEnderecos.Rows[count].Cells[1].Value = endereco.Cep;
                dgvEnderecos.Rows[count].Cells[2].Value = endereco.Logradouro;
                dgvEnderecos.Rows[count].Cells[3].Value = endereco.Numero;
                dgvEnderecos.Rows[count].Cells[4].Value = endereco.Complemento;
                dgvEnderecos.Rows[count].Cells[5].Value = endereco.Bairro;
                dgvEnderecos.Rows[count].Cells[6].Value = endereco.Cidade;
                dgvEnderecos.Rows[count].Cells[7].Value = endereco.Uf;
                dgvEnderecos.Rows[count].Cells[8].Value = endereco.TipoEnderecos.Descricao;
                count++;
            }
        }
        private void CarregaGridTelefone(int clienteId)
        {
            var listaTelefones = Telefone.ObterListaPorCliente(clienteId);
            dgvTelefones.Rows.Clear();
            int count = 0;
            foreach (var telefone in listaTelefones)
            {
                dgvTelefones.Rows[count].Cells[0].Value = telefone.Id;
                dgvTelefones.Rows[count].Cells[1].Value = telefone.Ddi;
                dgvTelefones.Rows[count].Cells[2].Value = telefone.Ddd;
                dgvTelefones.Rows[count].Cells[3].Value = telefone.Numero;
                dgvTelefones.Rows[count].Cells[4].Value = telefone.TipoTelefone.Descricao;
                count++;
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
            if (txtClienteId.Text.Length > 0)
            {
                CarregaGridEndereco(int.Parse(txtClienteId.Text));
                CarregaGridEndereco(int.Parse(txtClienteId.Text));
            }            
        }
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            
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
                Cliente cliente = Cliente.ObterPorId(Convert.ToInt32(txtIdUser.Text));
                txtClienteId.Text = txtIdUser.Text;
                txtNomeUsuario.Text = cliente.Usuario.Nome;
                txtEmailUsuario.Text = cliente.Usuario.Email;
                dtpDatanasc.Value = cliente.DataNasc;
                dtpDatanasc.Enabled = false;
                mskCpf.Text = cliente.Cpf;
                mskCpf.Enabled = false;
                // mudando text e desativando txtId
                txtIdUser.Enabled = false;
                txtSenhaUsuario.PlaceholderText = "[Digite uma senha caso queira mudar-la]";
                btnObterUsuarioPorId.Enabled = true;
                btnObterUsuarioPorId.Text = "&Consultar";
                // recuperando enderecos do cliente
                int count = 0;
                var enderecoCliente = Endereco.ObterListaPorCliente(int.Parse(txtIdUser.Text));
                foreach (var endereco in enderecoCliente)
                {
                    int rowIndex = dgvEnderecos.Rows.Add();
                    dgvEnderecos.Rows[count].Cells[0].Value = endereco.Id;
                    dgvEnderecos.Rows[count].Cells[1].Value = endereco.Cep;
                    dgvEnderecos.Rows[count].Cells[2].Value = endereco.Logradouro;
                    dgvEnderecos.Rows[count].Cells[3].Value = endereco.Numero;
                    dgvEnderecos.Rows[count].Cells[4].Value = endereco.Complemento;
                    dgvEnderecos.Rows[count].Cells[5].Value = endereco.Bairro;
                    dgvEnderecos.Rows[count].Cells[6].Value = endereco.Cidade;
                    dgvEnderecos.Rows[count].Cells[7].Value = endereco.Uf;
                    dgvEnderecos.Rows[count].Cells[8].Value = endereco.TipoEnderecos.Descricao;
                    count++;
                }
                count = 0;
                var telefoneCliente = Telefone.ObterListaPorCliente(int.Parse(txtIdUser.Text));
                foreach (var telefone in telefoneCliente)
                {
                    dgvEnderecos.Rows[count].Cells[0].Value = telefone.Id;
                    dgvTelefones.Rows[count].Cells[1].Value = telefone.Ddi;
                    dgvTelefones.Rows[count].Cells[2].Value = telefone.Ddd;
                    dgvTelefones.Rows[count].Cells[3].Value = telefone.Numero;
                    dgvTelefones.Rows[count].Cells[4].Value = telefone.TipoTelefone.Descricao;
                }
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
    }
}