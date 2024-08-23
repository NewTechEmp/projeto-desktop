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
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace TudoAcabaEmPizza
{
    public partial class FrmProduto : Form
    {
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Banco.caminhoFotos;
        string destinoCompleto = "";
        string DestinoCortado = "";
      
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
                pb_foto.Image = null;
                txtId.ReadOnly = false;
                txtId.Focus();
                btnConsultar.Text = "&Obter por ID";
            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    Produto produto = Produto.ObterPorId(int.Parse(txtId.Text));
                    txtRotulo.Text = produto.Rotulo;
                    txtDescricao.Text = produto.Descricao;
                    txtValor.Text = Convert.ToString(produto.ValorUnit);
                    mskCodigo.Text = produto.CodBarras;
                    pb_foto.Image = Image.FromFile(produto.NomeImagem);
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
                dgvProdutos.Rows[count].Cells[1].Value = produto.Rotulo;
                dgvProdutos.Rows[count].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[count].Cells[3].Value = produto.ValorUnit;
                dgvProdutos.Rows[count].Cells[4].Value = produto.CodBarras;
                dgvProdutos.Rows[count].Cells[5].Value = produto.NomeImagem;
                dgvProdutos.Rows[count].Cells[6].Value = produto.CategoriaId;


                count++;
                //
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (destinoCompleto == "")
            {
                if(MessageBox.Show("Sem foto selecionada, deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if(destinoCompleto != "")
            {
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    pb_foto.ImageLocation = destinoCompleto;
                }
                else
                {
                    if(MessageBox.Show("Erro ao localizar foto, deseja continuar ?","ERRO",MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
                
            }
            string[] destinoCortado = destinoCompleto.Split('\\');

            // Mostra o resultado para verificar se o array foi dividido corretamente
            if (destinoCortado.Length > 0)
            {
                string ultimaParte = destinoCortado[destinoCortado.Length - 1];
                Random a = new Random();
                int num = a.Next(10000,99999);
                int userID = Program.Usuario.Id;
                string userName = Program.Usuario.Nome;
                string userEmail = Program.Usuario.Email;
                DateTime data = DateTime.Now;
                string userNivel = Program.Usuario.Nivel.Descricao;
                var concat = $"{userID}-{userName}-{userEmail}-{userNivel}-{data}-{num}-";

                MessageBox.Show("A última parte do caminho é: " + ultimaParte);
                DestinoCortado = concat + ultimaParte;

                
            }
            else
            {
                MessageBox.Show("O array está vazio.");
            }

            


            mskCodigo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            Produto produto = new Produto(
                txtRotulo.Text
              , txtDescricao.Text
              , Convert.ToDouble(txtValor.Text)
              , mskCodigo.Text
              , pb_foto.ImageLocation = DestinoCortado
              , cbDestaque.Checked
              , Categoria.ObterPorId(Convert.ToInt32(cbmCategoria.SelectedValue))
                ) ;  

            produto.Inserir();
            MessageBox.Show("produto inserido com sucesso");

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produto = new(
                int.Parse(txtId.Text)
                , txtNome.Text
                , txtDescricao.Text
                , double.Parse(txtValor.Text)
                , mskCodigo.Text
                , pb_foto.ImageLocation = destinoCompleto
                , cbDestaque.Checked
                , Categoria.ObterPorId(Convert.ToInt32(cbmCategoria.SelectedValue))
                );
            if (produto.Editar(produto.Id))
            {
                FrmProduto_Load(sender, e);
                MessageBox.Show($"O produto \" {produto.Rotulo} \" foi alterado com sucesso!");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar o produto \" {produto.Rotulo} \"!");
            }
        }

        private void btnAddFoto_Click(object sender, EventArgs e)
        {
            origemCompleto = "";
            foto = "";
            pastaDestino = Banco.caminhoFotos;
            destinoCompleto = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto=openFileDialog1.FileName;
                foto=openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }
            if(File.Exists(destinoCompleto))
            {
                if(MessageBox.Show("Arquivo já existe, deseja substituir ?","Substituir",MessageBoxButtons.YesNo)==DialogResult.No)
                {
                    return;
                }
            }
            System.IO.File.Copy(origemCompleto, destinoCompleto, true);
            if (File.Exists(destinoCompleto))
            {
                pb_foto.ImageLocation = origemCompleto;
                MessageBox.Show("arquivo achado com sucesso");
            }
            else
            {
                MessageBox.Show("Arquivo não copiado");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
