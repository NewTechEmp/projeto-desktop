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
            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Usuario usuario = new Usuario(
                txtNomeUsuario.Text,
                txtEmailUsuario.Text,
                txtSenhaUsuario.Text,
                Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue))
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
                int.Parse(txtEnderecoClienteId.Text),
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
                mskDdi.Text,
                mskDdd.Text,
                mskNumeroTelefone.Text,
                int.Parse(txtClienteTelefoneId.Text),
                TipoTelefone.ObterPorId(Convert.ToInt32(cmbTipoTelefone.SelectedValue))
            );

            telefone.Inserir();
            if (telefone.Id > 0)
            {
                string telefoneCompleto = $"+{telefone.Ddi} ({telefone.Ddd}) {telefone.Numero}";
                MessageBox.Show($"O telefone {telefoneCompleto} foi cadastrado com sucesso");
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
            var nivel = Nivel.ObterLista();
            cmbNivel.DataSource = nivel;
            cmbNivel.DisplayMember = "sigla";
            cmbNivel.ValueMember = "id";


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
                btnObterUsuarioPorId.Text = "&Obter por ID";
                if (txtIdUser.Text.Length > 0 && txtIdUser.Text != null)
                {
                    Cliente cliente = Cliente.ObterPorId(Convert.ToInt32(txtClienteId.Text));
                    txtNomeUsuario.Text = cliente.Usuario.Nome;
                    txtEmailUsuario.Text = cliente.Usuario.Email;
                    dtpDatanasc.Value = cliente.DataNasc;
                    mskCpf.Text = cliente.Cpf;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
