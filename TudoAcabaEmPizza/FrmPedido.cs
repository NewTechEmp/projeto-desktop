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
            //txtVendedor.Text = $"{Program.Usuario.Id} - {Program.Usuario.Nome}";

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
            pedido.StatusId = Status.ObterPorId(int.Parse(cmbStatus.Text));
            pedido.ClasseDesconto = null;
            pedido.Inserir();
            txtNumeroPedido.Text = pedido.Id.ToString();
            gbProduto.Enabled = true;
            btnAbrirPedido.Enabled = false;
        }

        private void txtClienteId_TextChanged(object sender, EventArgs e)
        {
            txtClienteNome.Clear();
            if (txtClienteId.Text.Length > 0)
            {
                var cliente = Cliente.ObterPorId(int.Parse(txtClienteId.Text));
                if (cliente.Id > 0)
                {
                    txtClienteNome.Text = cliente.Cpf;
                }

            }
        }
    }
}
