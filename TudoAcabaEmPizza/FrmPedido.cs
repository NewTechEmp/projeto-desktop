using Google.Protobuf.WellKnownTypes;
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

        }
        private void CarregarStatus()
        {
            var status = Status.ObterLista();
            cmbStatus.DataSource = status; 
            cmbStatus.DisplayMember = "descricao"; 
            cmbStatus.ValueMember = "id"; 
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

            if (radioButtonPizza.Checked)
            {
               
                cmbTamanhoPizza.Visible = true;
               
                CarregarTamanhosPizza();
            }
            else
            {
             // se não for marcado não exibira o campo
                cmbTamanhoPizza.Visible = false;
            }

            ItemPedido itempedido = new(int.Parse(txtNumeroPedido.Text)
             ,Produto.ObterPorId(int.Parse(txtCodBarras.Text))
             ,double.Parse(txtQuantidade.Text)
             ,double.Parse(txtValorUnit.Text)
             , TamanhoPizza.ObterPorId(Convert.ToInt32(cmbTamanhoPizza.SelectedValue))


             );
            itempedido.Inserir();

            // limpar o datagrid 

            // limpar os campos
            txtCodBarras.Clear();
            txtDescricao.Clear();
            txtQuantidade.Text = "1";
            txtCodBarras.Clear();
            txtValorUnit.Clear();
            txtCodBarras.Focus();
            // carrega grid

        }

        private void CarregarTamanhosPizza()
        {
            var tamanhoPizzas = TamanhoPizza.ObterLista(); 
            cmbTamanhoPizza.DataSource = tamanhoPizzas; 
            cmbTamanhoPizza.DisplayMember = "descricao"; 
            cmbTamanhoPizza.ValueMember = "id"; 
        }
    }
}
