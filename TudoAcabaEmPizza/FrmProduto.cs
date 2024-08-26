using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using TAEPClass;

namespace TudoAcabaEmPizza
{
    public partial class FrmProduto : Form
    {
        private string origemCompleto = "";
        private string destinoCompleto = "";
        private string pastaDestino = Banco.caminhoFotos;

        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            // Carregar categorias e produtos na inicialização
            CarregarCategorias();
            CarregarProdutos();
        }

        private void CarregarCategorias()
        {
            var categorias = Categoria.ObterLista();
            cbmCategoria.DataSource = categorias;
            cbmCategoria.DisplayMember = "descricao";
            cbmCategoria.ValueMember = "id";
        }

        private void CarregarProdutos()
        {
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
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                LimparCampos();
                txtId.ReadOnly = false;
                txtId.Focus();
                btnConsultar.Text = "&Obter por ID";
            }
            else
            {
                if (int.TryParse(txtId.Text, out int id))
                {
                    CarregarProdutoPorId(id);
                }
            }
        }

        private void LimparCampos()
        {
            mskCodigo.Clear();
            txtDescricao.Clear();
            txtRotulo.Clear();
            txtValor.Clear();
            pb_foto.Image = null;
        }

        private void CarregarProdutoPorId(int id)
        {
            Produto produto = Produto.ObterPorId(id);
            txtRotulo.Text = produto.Rotulo;
            txtDescricao.Text = produto.Descricao;
            txtValor.Text = produto.ValorUnit.ToString();
            mskCodigo.Text = produto.CodBarras;
            pb_foto.Image = Image.FromFile(produto.NomeImagem);
            cbmCategoria.SelectedIndex = cbmCategoria.FindString(produto.CategoriaId.Descricao);
            btnEditar.Enabled = true;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(origemCompleto) || !File.Exists(origemCompleto))
            {
                if (MessageBox.Show("Sem foto selecionada, deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                // Copiar a imagem para a pasta de destino se necessário
                CopiarImagemParaDestino();
            }

            Produto produto = new Produto(
                txtRotulo.Text,
                txtDescricao.Text,
                Convert.ToDouble(txtValor.Text),
                mskCodigo.Text,
                destinoCompleto,
                cbDestaque.Checked,
                Categoria.ObterPorId(Convert.ToInt32(cbmCategoria.SelectedValue))
            );

            produto.Inserir();
            MessageBox.Show("Produto inserido com sucesso");
        }


        private void CopiarImagemParaDestino()
        {
            if (!string.IsNullOrEmpty(origemCompleto) && File.Exists(origemCompleto))
            {
                // Obtém o nome do arquivo original e a extensão
                string nomeArquivoOriginal = Path.GetFileName(origemCompleto);
                string extensaoArquivo = Path.GetExtension(origemCompleto);

                // Remove a extensão para obter o nome base do arquivo
                string nomeBase = Path.GetFileNameWithoutExtension(nomeArquivoOriginal).Replace(" ", "_");

                // Gera um novo nome para o arquivo com base nas propriedades fornecidas
                Random random = new Random();
                int numeroAleatorio = random.Next(100000, 999999); // Número aleatório
                int usuarioId = Program.Usuario.Id;
                string usuarioNome = Program.Usuario.Nome.Replace(" ", "-");
                string usuarioEmail = Program.Usuario.Email.Replace("@", "");
                DateTime dataAtual = DateTime.Now;
                string dataFormatada = dataAtual.ToString("yyyy-MM-dd_HH-mm-ss");
                string nivelUsuario = Program.Usuario.Nivel.Descricao;
                string enderecoIp = GetLocalIPAddress().Replace(".", "_");

                // Monta o novo nome para o arquivo com a mesma extensão do arquivo original
                string novoNomeArquivo = $"{enderecoIp}-{usuarioId}-{usuarioNome}-{usuarioEmail}-{nivelUsuario}-{dataFormatada}-{numeroAleatorio}-{nomeBase}{extensaoArquivo}";

                // Define o novo caminho completo com o novo nome
                destinoCompleto = Path.Combine(pastaDestino, novoNomeArquivo);

                // Verifica se o arquivo já existe no destino e renomeia se necessário
                if (File.Exists(destinoCompleto))
                {
                    MessageBox.Show("O arquivo já existe no destino, troque o nome dessa imagem");
                }
                else
                {
                    // Copia o arquivo para o destino com o novo nome
                    File.Copy(origemCompleto, destinoCompleto);
                }

                // Armazena apenas o nome do arquivo no destino
                destinoCompleto = novoNomeArquivo;
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(
                int.Parse(txtId.Text),
                txtRotulo.Text,
                txtDescricao.Text,
                double.Parse(txtValor.Text),
                mskCodigo.Text,
                destinoCompleto,
                cbDestaque.Checked,
                Categoria.ObterPorId(Convert.ToInt32(cbmCategoria.SelectedValue))
            );

            if (produto.Editar(produto.Id))
            {
                CarregarProdutos();
                MessageBox.Show($"O produto \"{produto.Rotulo}\" foi alterado com sucesso!");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar o produto \"{produto.Rotulo}\"!");
            }
        }

        private void btnAddFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.BMP;*.JPG;*.JPEG;*.JFIF;*.GIF;*.PNG;*.TIFF;*.ICO;*.WEBP;*.RAW;*.HEIF;*.HEIC;*.SVG)|*.BMP;*.JPG;*.JPEG;*.JFIF;*.GIF;*.PNG;*.TIFF;*.ICO;*.WEBP;*.RAW;*.HEIF;*.HEIC;*.SVG|Common Image Files|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG;*.TIFF;*.ICO;*.WEBP|All Image Files (*.*)|*.BMP;*.JPG;*.JPEG;*.JFIF;*.GIF;*.PNG;*.TIFF;*.ICO;*.WEBP;*.RAW;*.HEIF;*.HEIC;*.SVG";
            openFileDialog1.Title = "Selecione uma imagem";
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                pb_foto.Image = Image.FromFile(origemCompleto);
                pb_foto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private string GetLocalIPAddress()
        {
            try
            {
                string hostName = Dns.GetHostName();
                IPAddress[] addresses = Dns.GetHostAddresses(hostName);

                foreach (IPAddress address in addresses)
                {
                    if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        return address.ToString();
                    }
                }

                return "IP não encontrado";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter IP: {ex.Message}");
                return "Erro ao obter IP";
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Se necessário, você pode adicionar algum código aqui para lidar com a seleção do arquivo
        }
    }
}
