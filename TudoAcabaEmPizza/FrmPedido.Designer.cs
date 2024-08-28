namespace TudoAcabaEmPizza
{
    partial class FrmPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cmbStatus = new ComboBox();
            label12 = new Label();
            label9 = new Label();
            label11 = new Label();
            cmbDesconto = new ComboBox();
            label10 = new Label();
            txtSubTotal = new TextBox();
            txtDesconto = new TextBox();
            txtTotal = new TextBox();
            btnExcluirItem = new Button();
            button3 = new Button();
            label5 = new Label();
            dgvItemPedido = new DataGridView();
            btnAbrirPedido = new Button();
            gbProduto = new GroupBox();
            txtDescricaoSaborDois = new TextBox();
            txtCodSaborDois = new TextBox();
            radioButtonMeia = new CheckBox();
            radioButtonPizza = new CheckBox();
            cmbTamanhoPizza = new ComboBox();
            btnInserirProduto = new Button();
            label8 = new Label();
            Quantidade = new Label();
            label7 = new Label();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            label17 = new Label();
            label6 = new Label();
            txtRotulo = new TextBox();
            label16 = new Label();
            label15 = new Label();
            txtCodProduto = new TextBox();
            gbCliente = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            txtClienteCPF = new TextBox();
            txtClienteId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtVendedor = new TextBox();
            txtNumeroPedido = new TextBox();
            gbBuscaProduto = new GroupBox();
            txtBuscaProduto = new TextBox();
            dgvProdutos = new DataGridView();
            clnIdItemPedido = new DataGridViewTextBoxColumn();
            clnValorUnitItemPedido = new DataGridViewTextBoxColumn();
            clnQuantidadeItemPedido = new DataGridViewTextBoxColumn();
            clnValorItem = new DataGridViewTextBoxColumn();
            clnCodProdutoItemPedido = new DataGridViewTextBoxColumn();
            clnSaborDois = new DataGridViewTextBoxColumn();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnDescricaoproduto = new DataGridViewTextBoxColumn();
            clnValorProduto = new DataGridViewTextBoxColumn();
            clnCodBarrasProduto = new DataGridViewTextBoxColumn();
            clnImagem = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemPedido).BeginInit();
            gbProduto.SuspendLayout();
            gbCliente.SuspendLayout();
            gbBuscaProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 573);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(417, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(174, 46);
            label1.TabIndex = 0;
            label1.Text = "Pedido!";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbStatus);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(cmbDesconto);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtSubTotal);
            groupBox1.Controls.Add(txtDesconto);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(btnExcluirItem);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dgvItemPedido);
            groupBox1.Controls.Add(btnAbrirPedido);
            groupBox1.Controls.Add(gbProduto);
            groupBox1.Controls.Add(gbCliente);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtVendedor);
            groupBox1.Controls.Add(txtNumeroPedido);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(gbBuscaProduto);
            groupBox1.ForeColor = Color.ForestGreen;
            groupBox1.Location = new Point(50, 22);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(1223, 854);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(134, 619);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(160, 29);
            cmbStatus.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(995, 720);
            label12.Name = "label12";
            label12.Size = new Size(48, 21);
            label12.TabIndex = 18;
            label12.Text = "Total";
            label12.Click += label9_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(308, 621);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 18;
            label9.Text = "Tipo de Desconto";
            label9.Click += label9_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.Location = new Point(995, 691);
            label11.Name = "label11";
            label11.Size = new Size(82, 21);
            label11.TabIndex = 18;
            label11.Text = "Desconto";
            label11.Click += label9_Click;
            // 
            // cmbDesconto
            // 
            cmbDesconto.FormattingEnabled = true;
            cmbDesconto.Location = new Point(417, 619);
            cmbDesconto.Name = "cmbDesconto";
            cmbDesconto.Size = new Size(215, 29);
            cmbDesconto.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(994, 664);
            label10.Name = "label10";
            label10.Size = new Size(83, 21);
            label10.TabIndex = 18;
            label10.Text = "Sub-Total";
            label10.Click += label9_Click;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSubTotal.Location = new Point(1083, 663);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(133, 22);
            txtSubTotal.TabIndex = 21;
            // 
            // txtDesconto
            // 
            txtDesconto.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDesconto.Location = new Point(1083, 691);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(133, 22);
            txtDesconto.TabIndex = 21;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(1049, 723);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(167, 22);
            txtTotal.TabIndex = 21;
            // 
            // btnExcluirItem
            // 
            btnExcluirItem.Location = new Point(995, 751);
            btnExcluirItem.Name = "btnExcluirItem";
            btnExcluirItem.Size = new Size(131, 43);
            btnExcluirItem.TabIndex = 20;
            btnExcluirItem.Text = "Excluir &Item";
            btnExcluirItem.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(995, 805);
            button3.Name = "button3";
            button3.Size = new Size(187, 43);
            button3.TabIndex = 19;
            button3.Text = "Finalizar &Pedido";
            button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(28, 627);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 9;
            label5.Text = "Status do Pedido";
            // 
            // dgvItemPedido
            // 
            dgvItemPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemPedido.Columns.AddRange(new DataGridViewColumn[] { clnIdItemPedido, clnValorUnitItemPedido, clnQuantidadeItemPedido, clnValorItem, clnCodProdutoItemPedido, clnSaborDois });
            dgvItemPedido.Location = new Point(15, 654);
            dgvItemPedido.Name = "dgvItemPedido";
            dgvItemPedido.RowHeadersVisible = false;
            dgvItemPedido.Size = new Size(973, 189);
            dgvItemPedido.TabIndex = 18;
            // 
            // btnAbrirPedido
            // 
            btnAbrirPedido.Location = new Point(1038, 154);
            btnAbrirPedido.Name = "btnAbrirPedido";
            btnAbrirPedido.Size = new Size(139, 44);
            btnAbrirPedido.TabIndex = 17;
            btnAbrirPedido.Text = "&Abrir Pedido";
            btnAbrirPedido.UseVisualStyleBackColor = true;
            btnAbrirPedido.Click += btnAbrirPedido_Click;
            // 
            // gbProduto
            // 
            gbProduto.Controls.Add(txtDescricaoSaborDois);
            gbProduto.Controls.Add(txtCodSaborDois);
            gbProduto.Controls.Add(radioButtonMeia);
            gbProduto.Controls.Add(radioButtonPizza);
            gbProduto.Controls.Add(cmbTamanhoPizza);
            gbProduto.Controls.Add(btnInserirProduto);
            gbProduto.Controls.Add(label8);
            gbProduto.Controls.Add(Quantidade);
            gbProduto.Controls.Add(label7);
            gbProduto.Controls.Add(txtQuantidade);
            gbProduto.Controls.Add(txtValorUnit);
            gbProduto.Controls.Add(label17);
            gbProduto.Controls.Add(label6);
            gbProduto.Controls.Add(txtRotulo);
            gbProduto.Controls.Add(label16);
            gbProduto.Controls.Add(label15);
            gbProduto.Controls.Add(txtCodProduto);
            gbProduto.Enabled = false;
            gbProduto.Location = new Point(17, 442);
            gbProduto.Name = "gbProduto";
            gbProduto.Size = new Size(1160, 169);
            gbProduto.TabIndex = 11;
            gbProduto.TabStop = false;
            gbProduto.Text = "Produto";
            // 
            // txtDescricaoSaborDois
            // 
            txtDescricaoSaborDois.Enabled = false;
            txtDescricaoSaborDois.Location = new Point(624, 131);
            txtDescricaoSaborDois.Name = "txtDescricaoSaborDois";
            txtDescricaoSaborDois.Size = new Size(390, 29);
            txtDescricaoSaborDois.TabIndex = 22;
            // 
            // txtCodSaborDois
            // 
            txtCodSaborDois.Enabled = false;
            txtCodSaborDois.Location = new Point(491, 131);
            txtCodSaborDois.Name = "txtCodSaborDois";
            txtCodSaborDois.Size = new Size(92, 29);
            txtCodSaborDois.TabIndex = 22;
            txtCodSaborDois.TextChanged += txtCodSaborDois_TextChanged;
            // 
            // radioButtonMeia
            // 
            radioButtonMeia.AutoSize = true;
            radioButtonMeia.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonMeia.Location = new Point(237, 131);
            radioButtonMeia.Name = "radioButtonMeia";
            radioButtonMeia.Size = new Size(105, 24);
            radioButtonMeia.TabIndex = 21;
            radioButtonMeia.Text = "Pizza  Meia";
            radioButtonMeia.UseVisualStyleBackColor = true;
            radioButtonMeia.CheckedChanged += radioButtonMeia_CheckedChanged;
            // 
            // radioButtonPizza
            // 
            radioButtonPizza.AutoSize = true;
            radioButtonPizza.Checked = true;
            radioButtonPizza.CheckState = CheckState.Checked;
            radioButtonPizza.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonPizza.Location = new Point(17, 29);
            radioButtonPizza.Name = "radioButtonPizza";
            radioButtonPizza.Size = new Size(63, 24);
            radioButtonPizza.TabIndex = 20;
            radioButtonPizza.Text = "Pizza";
            radioButtonPizza.UseVisualStyleBackColor = true;
            radioButtonPizza.CheckedChanged += radioButtonPizza_CheckedChanged;
            // 
            // cmbTamanhoPizza
            // 
            cmbTamanhoPizza.FormattingEnabled = true;
            cmbTamanhoPizza.Location = new Point(14, 131);
            cmbTamanhoPizza.Name = "cmbTamanhoPizza";
            cmbTamanhoPizza.Size = new Size(172, 29);
            cmbTamanhoPizza.TabIndex = 19;
            cmbTamanhoPizza.SelectedIndexChanged += cmbTamanhoPizza_SelectedIndexChanged;
            // 
            // btnInserirProduto
            // 
            btnInserirProduto.Location = new Point(1023, 62);
            btnInserirProduto.Name = "btnInserirProduto";
            btnInserirProduto.Size = new Size(114, 61);
            btnInserirProduto.TabIndex = 16;
            btnInserirProduto.Text = "&Inserir";
            btnInserirProduto.UseVisualStyleBackColor = true;
            btnInserirProduto.Click += btnInserirProduto_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(14, 108);
            label8.Name = "label8";
            label8.Size = new Size(104, 15);
            label8.TabIndex = 14;
            label8.Text = "Tamanho da pizza";
            // 
            // Quantidade
            // 
            Quantidade.AutoSize = true;
            Quantidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Quantidade.Location = new Point(798, 17);
            Quantidade.Name = "Quantidade";
            Quantidade.Size = new Size(71, 15);
            Quantidade.TabIndex = 13;
            Quantidade.Text = "Quantidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(610, 25);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 13;
            label7.Text = "Valor unitário";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(724, 45);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(233, 29);
            txtQuantidade.TabIndex = 12;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(597, 45);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(121, 29);
            txtValorUnit.TabIndex = 12;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.Location = new Point(716, 108);
            label17.Name = "label17";
            label17.Size = new Size(119, 15);
            label17.TabIndex = 11;
            label17.Text = "Rótulo do sabor dois";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(351, 25);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 11;
            label6.Text = "Rótulo";
            // 
            // txtRotulo
            // 
            txtRotulo.Location = new Point(348, 45);
            txtRotulo.Name = "txtRotulo";
            txtRotulo.Size = new Size(246, 29);
            txtRotulo.TabIndex = 10;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(459, 104);
            label16.Name = "label16";
            label16.Size = new Size(135, 20);
            label16.TabIndex = 9;
            label16.Text = "Código Sabor dois";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label15.Location = new Point(167, 17);
            label15.Name = "label15";
            label15.Size = new Size(110, 15);
            label15.TabIndex = 9;
            label15.Text = "Código do produto";
            // 
            // txtCodProduto
            // 
            txtCodProduto.Location = new Point(96, 45);
            txtCodProduto.Name = "txtCodProduto";
            txtCodProduto.Size = new Size(246, 29);
            txtCodProduto.TabIndex = 0;
            txtCodProduto.TextChanged += txtCodProduto_TextChanged;
            // 
            // gbCliente
            // 
            gbCliente.Controls.Add(label14);
            gbCliente.Controls.Add(label13);
            gbCliente.Controls.Add(txtClienteCPF);
            gbCliente.Controls.Add(txtClienteId);
            gbCliente.Location = new Point(31, 119);
            gbCliente.Name = "gbCliente";
            gbCliente.Size = new Size(1000, 109);
            gbCliente.TabIndex = 10;
            gbCliente.TabStop = false;
            gbCliente.Text = "Dados do Cliente";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label14.Location = new Point(28, 54);
            label14.Name = "label14";
            label14.Size = new Size(23, 19);
            label14.TabIndex = 2;
            label14.Text = "ID";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label13.Location = new Point(258, 50);
            label13.Name = "label13";
            label13.Size = new Size(50, 19);
            label13.TabIndex = 2;
            label13.Text = "Nome";
            // 
            // txtClienteCPF
            // 
            txtClienteCPF.Location = new Point(314, 44);
            txtClienteCPF.Name = "txtClienteCPF";
            txtClienteCPF.Size = new Size(638, 29);
            txtClienteCPF.TabIndex = 1;
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(62, 45);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(138, 29);
            txtClienteId.TabIndex = 0;
            txtClienteId.TextChanged += txtClienteId_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(804, 35);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 9;
            label3.Text = "Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 82);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 8;
            label2.Text = "Vendedor";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(138, 79);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(739, 29);
            txtVendedor.TabIndex = 7;
            txtVendedor.TextChanged += txtVendedor_TextChanged;
            // 
            // txtNumeroPedido
            // 
            txtNumeroPedido.Font = new Font("Segoe UI", 24F);
            txtNumeroPedido.ForeColor = Color.FromArgb(0, 192, 0);
            txtNumeroPedido.Location = new Point(1047, 53);
            txtNumeroPedido.Name = "txtNumeroPedido";
            txtNumeroPedido.ReadOnly = true;
            txtNumeroPedido.RightToLeft = RightToLeft.Yes;
            txtNumeroPedido.Size = new Size(169, 50);
            txtNumeroPedido.TabIndex = 6;
            txtNumeroPedido.Text = "0";
            // 
            // gbBuscaProduto
            // 
            gbBuscaProduto.Controls.Add(txtBuscaProduto);
            gbBuscaProduto.Controls.Add(dgvProdutos);
            gbBuscaProduto.Enabled = false;
            gbBuscaProduto.Location = new Point(15, 234);
            gbBuscaProduto.Name = "gbBuscaProduto";
            gbBuscaProduto.Size = new Size(1162, 209);
            gbBuscaProduto.TabIndex = 24;
            gbBuscaProduto.TabStop = false;
            gbBuscaProduto.Text = "Busca de Produto";
            // 
            // txtBuscaProduto
            // 
            txtBuscaProduto.Location = new Point(6, 26);
            txtBuscaProduto.Name = "txtBuscaProduto";
            txtBuscaProduto.PlaceholderText = "Digite aqui para buscar os produtos";
            txtBuscaProduto.Size = new Size(1010, 29);
            txtBuscaProduto.TabIndex = 24;
            txtBuscaProduto.TextChanged += txtBuscaProduto_TextChanged;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnDescricaoproduto, clnValorProduto, clnCodBarrasProduto, clnImagem, clnCategoria });
            dgvProdutos.Location = new Point(6, 61);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.Size = new Size(1150, 135);
            dgvProdutos.TabIndex = 23;
            // 
            // clnIdItemPedido
            // 
            clnIdItemPedido.Frozen = true;
            clnIdItemPedido.HeaderText = "ID";
            clnIdItemPedido.Name = "clnIdItemPedido";
            clnIdItemPedido.ReadOnly = true;
            clnIdItemPedido.Width = 120;
            // 
            // clnValorUnitItemPedido
            // 
            clnValorUnitItemPedido.Frozen = true;
            clnValorUnitItemPedido.HeaderText = "Valor_unit";
            clnValorUnitItemPedido.Name = "clnValorUnitItemPedido";
            clnValorUnitItemPedido.ReadOnly = true;
            clnValorUnitItemPedido.Width = 160;
            // 
            // clnQuantidadeItemPedido
            // 
            clnQuantidadeItemPedido.Frozen = true;
            clnQuantidadeItemPedido.HeaderText = "Quantidade";
            clnQuantidadeItemPedido.Name = "clnQuantidadeItemPedido";
            clnQuantidadeItemPedido.ReadOnly = true;
            clnQuantidadeItemPedido.Width = 130;
            // 
            // clnValorItem
            // 
            clnValorItem.Frozen = true;
            clnValorItem.HeaderText = "NºPedido";
            clnValorItem.Name = "clnValorItem";
            clnValorItem.ReadOnly = true;
            clnValorItem.Width = 150;
            // 
            // clnCodProdutoItemPedido
            // 
            clnCodProdutoItemPedido.Frozen = true;
            clnCodProdutoItemPedido.HeaderText = "Código do Produto";
            clnCodProdutoItemPedido.Name = "clnCodProdutoItemPedido";
            clnCodProdutoItemPedido.Width = 190;
            // 
            // clnSaborDois
            // 
            clnSaborDois.Frozen = true;
            clnSaborDois.HeaderText = "Produto Sabor dois";
            clnSaborDois.Name = "clnSaborDois";
            clnSaborDois.ReadOnly = true;
            clnSaborDois.Width = 220;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 40;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome do Produto";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 180;
            // 
            // clnDescricaoproduto
            // 
            clnDescricaoproduto.Frozen = true;
            clnDescricaoproduto.HeaderText = "Descrição do Produto";
            clnDescricaoproduto.Name = "clnDescricaoproduto";
            clnDescricaoproduto.ReadOnly = true;
            clnDescricaoproduto.Width = 293;
            // 
            // clnValorProduto
            // 
            clnValorProduto.Frozen = true;
            clnValorProduto.HeaderText = "Valor Unit";
            clnValorProduto.Name = "clnValorProduto";
            clnValorProduto.ReadOnly = true;
            clnValorProduto.Width = 115;
            // 
            // clnCodBarrasProduto
            // 
            clnCodBarrasProduto.Frozen = true;
            clnCodBarrasProduto.HeaderText = "Código de Barras do Produto";
            clnCodBarrasProduto.Name = "clnCodBarrasProduto";
            clnCodBarrasProduto.ReadOnly = true;
            clnCodBarrasProduto.Width = 265;
            // 
            // clnImagem
            // 
            clnImagem.Frozen = true;
            clnImagem.HeaderText = "Imagem";
            clnImagem.Name = "clnImagem";
            clnImagem.ReadOnly = true;
            clnImagem.Width = 153;
            // 
            // clnCategoria
            // 
            clnCategoria.Frozen = true;
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1284, 886);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.HotTrack;
            Margin = new Padding(4);
            Name = "FrmPedido";
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemPedido).EndInit();
            gbProduto.ResumeLayout(false);
            gbProduto.PerformLayout();
            gbCliente.ResumeLayout(false);
            gbCliente.PerformLayout();
            gbBuscaProduto.ResumeLayout(false);
            gbBuscaProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtDataPed;
        private Label label4;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtNumeroPedido;
        private GroupBox gbCliente;
        private Label label3;
        private Label label2;
        private TextBox txtVendedor;
        private GroupBox gbProduto;
        private TextBox txtValorUnit;
        private Label label6;
        private TextBox txtRotulo;
        private Label label5;
        private TextBox txtCodProduto;
        private TextBox txtClienteCPF;
        private TextBox txtClienteId;
        private Label label7;
        private Button btnAbrirPedido;
        private Button btnInserirProduto;
        private Label label8;
        private DataGridView dgvItemPedido;
        private Button btnExcluirItem;
        private Button button3;
        private Label label9;
        private ComboBox cmbDesconto;
        private TextBox txtSubTotal;
        private TextBox txtDesconto;
        private TextBox txtTotal;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label14;
        private Label label13;
        private ComboBox cmbStatus;
        private Label label15;
        private ComboBox cmbTamanhoPizza;
        private Label Quantidade;
        private TextBox txtQuantidade;
        private DataGridView dgvProdutos;
        private TextBox txtCodSaborDois;
        private CheckBox radioButtonMeia;
        private Label label16;
        private GroupBox gbBuscaProduto;
        private TextBox txtBuscaProduto;
        private CheckBox radioButtonPizza;
        private TextBox txtDescricaoSaborDois;
        private Label label17;
        private DataGridViewTextBoxColumn clnIdItemPedido;
        private DataGridViewTextBoxColumn clnValorUnitItemPedido;
        private DataGridViewTextBoxColumn clnQuantidadeItemPedido;
        private DataGridViewTextBoxColumn clnValorItem;
        private DataGridViewTextBoxColumn clnCodProdutoItemPedido;
        private DataGridViewTextBoxColumn clnSaborDois;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnDescricaoproduto;
        private DataGridViewTextBoxColumn clnValorProduto;
        private DataGridViewTextBoxColumn clnCodBarrasProduto;
        private DataGridViewTextBoxColumn clnImagem;
        private DataGridViewTextBoxColumn clnCategoria;
    }
}