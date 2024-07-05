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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                mskCodigo.Clear();
                txtDescricao.Clear();
                txtNome.Clear();

                txtValor.Clear();
                txtLinkImage.Clear();
                txtId.ReadOnly = false;
                txtId.Focus();
                btnConsultar.Text = "&Obter por ID";
            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    Produto produto = Produto.ObterPorId(int.Parse(txtId.Text));
                    txtNome.Text = produto.Nome;
                    txtDescricao.Text = produto.Descricao;
                    txtValor.Text = Convert.ToString(produto.ValorUnit);
                    mskCodigo.Text = produto.CodBarras;
                    txtLinkImage.Text = produto.LinkImagem;
                    cbmCategoria.SelectedIndex = cbmCategoria.FindString(produto.CategoriaId.Descricao);
                    btnEditar.Enabled = true;
                }
            }
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            var categorias = Categoria.ObterLista();
            cbmCategoria.DataSource = categorias;
            cbmCategoria.DisplayMember = "descricao";
            cbmCategoria.ValueMember = "id";

            var lista = Produto.ObterLista();
            dgvProdutos.Rows.Clear();
            int count = 0;



            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[count].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[count].Cells[1].Value = produto.Nome;
                dgvProdutos.Rows[count].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[count].Cells[3].Value = produto.ValorUnit;
                dgvProdutos.Rows[count].Cells[4].Value = produto.CodBarras;
                dgvProdutos.Rows[count].Cells[5].Value = produto.LinkImagem;
                dgvProdutos.Rows[count].Cells[6].Value = produto.CategoriaId;


                count++;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            mskCodigo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            Produto produto = new Produto(
                txtNome.Text
              , txtDescricao.Text
              , Convert.ToDouble(txtValor.Text)
              , mskCodigo.Text
              , txtLinkImage.Text
              , Categoria.ObterPorId(Convert.ToInt32(cbmCategoria.SelectedValue))
                );

            produto.Inserir();
            FrmProduto_Load(sender, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produto = new(
                txtNome.Text
                ,txtDescricao.Text
                ,double.Parse(txtValor.Text)
                , mskCodigo.Text
                , txtLinkImage.Text
                , Categoria.ObterPorId(Convert.ToInt32(cbmCategoria.SelectedValue))
                );
            if(produto.Editar(produto.Id))
            {
                FrmProduto_Load(sender, e); ;
                MessageBox.Show($"O produto \" {produto.Nome} \" foi alterado com sucesso!");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar o produto \" {produto.Nome} \"!");
            }
        }
    }
}
