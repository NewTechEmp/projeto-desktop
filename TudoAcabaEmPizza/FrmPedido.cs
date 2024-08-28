using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAEPClass;

namespace TudoAcabaEmPizza
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            var dataAtual = DateTime.Now;
            txtVendedor.Text = $"{Program.Usuario.Id} - {Program.Usuario.Nome}";
            CarregarStatus();
            CarregarTipoDesconto();
            CarregaGridProduto();
            TamanhoDePizza();

        }
        private void CarregaGridProduto()
        {
            var produto = Produto.ObterLista();
            int count = 0;
            // Preenche o DataGridView com todos os endereços
            dgvProdutos.Rows.Clear();
            foreach (var produtos in produto)
            {
                int rowIndex = dgvProdutos.Rows.Add();
                dgvProdutos.Rows[count].Cells[0].Value = produtos.Id;
                dgvProdutos.Rows[count].Cells[1].Value = produtos.Rotulo;
                dgvProdutos.Rows[count].Cells[2].Value = produtos.Descricao;
                dgvProdutos.Rows[count].Cells[3].Value = produtos.ValorUnit;
                dgvProdutos.Rows[count].Cells[4].Value = produtos.CodBarras;
                dgvProdutos.Rows[count].Cells[5].Value = produtos.NomeImagem;
                dgvProdutos.Rows[count].Cells[6].Value = produtos.CategoriaId.Descricao;
                count++;
            }
        }
        private void CarregarStatus()
        {
            var status = Status.ObterLista();
            cmbStatus.DataSource = status;
            cmbStatus.DisplayMember = "descricao";
            cmbStatus.ValueMember = "id";
        }

        public void TamanhoDePizza()
        {
            var tamanhoPizza = TamanhoPizza.ObterLista();
            cmbTamanhoPizza.DataSource = tamanhoPizza;
            cmbTamanhoPizza.DisplayMember = "descricao";
            cmbTamanhoPizza.ValueMember = "id";
        }

        private void CarregarTipoDesconto()
        {
            var classeDesconto = ClasseDesconto.ObterLista();
            cmbDesconto.DataSource = classeDesconto;
            cmbDesconto.DisplayMember = "descricao";
            cmbDesconto.ValueMember = "id";
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbItemAdicional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrirPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new();
            pedido.Cliente = Cliente.ObterPorId(int.Parse(txtClienteId.Text));
            pedido.Usuario = Program.Usuario;
            pedido.StatusId = Status.ObterPorId(Convert.ToInt32(cmbStatus.SelectedValue));
            pedido.ClasseDesconto = ClasseDesconto.ObterPorId(Convert.ToInt32(cmbDesconto.SelectedValue));
            pedido.Inserir();
            txtNumeroPedido.Text = pedido.Id.ToString();
            gbProduto.Enabled = true;
            gbBuscaProduto.Enabled = true;
            btnAbrirPedido.Enabled = false;
        }

        private void txtClienteId_TextChanged(object sender, EventArgs e)
        {
            txtClienteCPF.Clear();
            if (txtClienteId.Text.Length > 0)
            {
                var cliente = Cliente.ObterPorId(int.Parse(txtClienteId.Text));
                if (cliente.Id > 0)
                {
                    txtClienteCPF.Text = cliente.Cpf;
                }

            }
        }

        private void txtVendedor_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnInserirProduto_Click(object sender, EventArgs e)
        {

            ItemPedido itempedido = new(int.Parse(txtNumeroPedido.Text)
             , Produto.ObterPorId(int.Parse(txtCodProduto.Text))
             , double.Parse(txtQuantidade.Text)
             , double.Parse(txtValorUnit.Text)
             , TamanhoPizza.ObterPorId(Convert.ToInt32(cmbTamanhoPizza.SelectedValue))
             , radioButtonMeia.Checked




             );
            itempedido.Inserir();

            // limpar o datagrid 

            // limpar os campos
            txtCodProduto.Clear();
            txtRotulo.Clear();
            txtQuantidade.Text = "1";
            txtCodProduto.Clear();
            txtValorUnit.Clear();
            txtCodProduto.Focus();
            // carrega grid

        }

        private void CarregarTamanhosPizza()
        {
            var tamanhoPizzas = TamanhoPizza.ObterLista();
            cmbTamanhoPizza.DataSource = tamanhoPizzas;
            cmbTamanhoPizza.DisplayMember = "descricao";
            cmbTamanhoPizza.ValueMember = "id";
        }

        private void txtBuscaProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaProduto.Text.Length > 0)
            {
                var produto = Produto.ObterLista(txtBuscaProduto.Text);
                dgvProdutos.Rows.Clear();
                int count = 0;
                foreach (var produtos in produto)
                {
                    dgvProdutos.Rows.Add();
                    dgvProdutos.Rows[count].Cells[0].Value = produtos.Id;
                    dgvProdutos.Rows[count].Cells[1].Value = produtos.Rotulo;
                    dgvProdutos.Rows[count].Cells[2].Value = produtos.Descricao;
                    dgvProdutos.Rows[count].Cells[3].Value = produtos.ValorUnit;
                    dgvProdutos.Rows[count].Cells[4].Value = produtos.CodBarras;
                    dgvProdutos.Rows[count].Cells[5].Value = produtos.NomeImagem;
                    dgvProdutos.Rows[count].Cells[6].Value = produtos.CategoriaId.Descricao;
                    count++;
                }
            }
            else
            {
                FrmPedido_Load(sender, e);
            }
        }
        Produto produto = new();
        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtCodProduto.Text.Length > 0)
            {
                produto = Produto.ObterPorId(int.Parse(txtCodProduto.Text));
                if (produto.Id > 0)
                {
                    txtRotulo.Text = produto.Rotulo;
                    txtValorUnit.Text = produto.ValorUnit.ToString();


                }
            }
        }

        private void radioButtonPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPizza.Checked)
            {
                cmbTamanhoPizza.Enabled = true;
                TamanhoDePizza();
            }
            else
            {
                cmbTamanhoPizza.Enabled = false;
            }
        }

        private void cmbTamanhoPizza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMeia_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMeia.Checked)
            {
                txtSaborDois.Enabled = true;
                

            }
            else
            {
                txtSaborDois.Enabled = false;
            }
        }
    }
}

