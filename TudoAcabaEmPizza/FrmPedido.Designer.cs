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
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            txtSubTotal = new TextBox();
            txtDesconto = new TextBox();
            txtTotal = new TextBox();
            btnExcluirItem = new Button();
            button3 = new Button();
            dgvPedido = new DataGridView();
            clnCod = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnValorItem = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            btnAbrirPedido = new Button();
            groupBox3 = new GroupBox();
            label9 = new Label();
            cmbDesconto = new ComboBox();
            btnInserirProduto = new Button();
            txtQuantidade = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtValorUnit = new TextBox();
            label6 = new Label();
            txtDescricao = new TextBox();
            label5 = new Label();
            txtCodBarras = new TextBox();
            groupBox2 = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            txtClienteNome = new TextBox();
            txtClienteId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtVendedor = new TextBox();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 537);
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
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtSubTotal);
            groupBox1.Controls.Add(txtDesconto);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(btnExcluirItem);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(dgvPedido);
            groupBox1.Controls.Add(btnAbrirPedido);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtVendedor);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.ForeColor = Color.ForestGreen;
            groupBox1.Location = new Point(50, 22);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(1083, 811);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(850, 642);
            label12.Name = "label12";
            label12.Size = new Size(48, 21);
            label12.TabIndex = 18;
            label12.Text = "Total";
            label12.Click += label9_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.Location = new Point(850, 571);
            label11.Name = "label11";
            label11.Size = new Size(82, 21);
            label11.TabIndex = 18;
            label11.Text = "Desconto";
            label11.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(850, 502);
            label10.Name = "label10";
            label10.Size = new Size(83, 21);
            label10.TabIndex = 18;
            label10.Text = "Sub-Total";
            label10.Click += label9_Click;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(850, 529);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(190, 29);
            txtSubTotal.TabIndex = 21;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(850, 595);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(190, 29);
            txtDesconto.TabIndex = 21;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(850, 666);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(190, 29);
            txtTotal.TabIndex = 21;
            // 
            // btnExcluirItem
            // 
            btnExcluirItem.Location = new Point(850, 701);
            btnExcluirItem.Name = "btnExcluirItem";
            btnExcluirItem.Size = new Size(131, 43);
            btnExcluirItem.TabIndex = 20;
            btnExcluirItem.Text = "Excluir &Item";
            btnExcluirItem.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(850, 750);
            button3.Name = "button3";
            button3.Size = new Size(215, 43);
            button3.TabIndex = 19;
            button3.Text = "Finalizar &Pedido";
            button3.UseVisualStyleBackColor = true;
            // 
            // dgvPedido
            // 
            dgvPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedido.Columns.AddRange(new DataGridViewColumn[] { clnCod, clnDescricao, clnDesconto, clnValorItem, clnValorUnit, clnQuantidade });
            dgvPedido.Location = new Point(14, 515);
            dgvPedido.Name = "dgvPedido";
            dgvPedido.RowHeadersVisible = false;
            dgvPedido.Size = new Size(830, 278);
            dgvPedido.TabIndex = 18;
            // 
            // clnCod
            // 
            clnCod.Frozen = true;
            clnCod.HeaderText = "Cod Barras";
            clnCod.Name = "clnCod";
            clnCod.ReadOnly = true;
            clnCod.Width = 120;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 160;
            // 
            // clnDesconto
            // 
            clnDesconto.Frozen = true;
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            // 
            // clnValorItem
            // 
            clnValorItem.Frozen = true;
            clnValorItem.HeaderText = "Valor Item";
            clnValorItem.Name = "clnValorItem";
            clnValorItem.ReadOnly = true;
            clnValorItem.Width = 150;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.Width = 150;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quantidade";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 150;
            // 
            // btnAbrirPedido
            // 
            btnAbrirPedido.Location = new Point(887, 245);
            btnAbrirPedido.Name = "btnAbrirPedido";
            btnAbrirPedido.Size = new Size(139, 44);
            btnAbrirPedido.TabIndex = 17;
            btnAbrirPedido.Text = "&Abrir Pedido";
            btnAbrirPedido.UseVisualStyleBackColor = true;
            btnAbrirPedido.Click += btnAbrirPedido_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(cmbDesconto);
            groupBox3.Controls.Add(btnInserirProduto);
            groupBox3.Controls.Add(txtQuantidade);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtValorUnit);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtDescricao);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtCodBarras);
            groupBox3.Location = new Point(15, 327);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1011, 152);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Produto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(738, 61);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 18;
            label9.Text = "Desconto";
            label9.Click += label9_Click;
            // 
            // cmbDesconto
            // 
            cmbDesconto.FormattingEnabled = true;
            cmbDesconto.Location = new Point(725, 89);
            cmbDesconto.Name = "cmbDesconto";
            cmbDesconto.Size = new Size(121, 29);
            cmbDesconto.TabIndex = 17;
            // 
            // btnInserirProduto
            // 
            btnInserirProduto.Location = new Point(871, 84);
            btnInserirProduto.Name = "btnInserirProduto";
            btnInserirProduto.Size = new Size(134, 34);
            btnInserirProduto.TabIndex = 16;
            btnInserirProduto.Text = "&Inserir";
            btnInserirProduto.UseVisualStyleBackColor = true;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(585, 89);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(121, 29);
            txtQuantidade.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(601, 61);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 14;
            label8.Text = "Quantidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(442, 61);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 13;
            label7.Text = "Valor unitário";
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(442, 89);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(121, 29);
            txtValorUnit.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(178, 61);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 11;
            label6.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(178, 89);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(246, 29);
            txtDescricao.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(28, 61);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 9;
            label5.Text = "Código de barras";
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(6, 89);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(153, 29);
            txtCodBarras.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txtClienteNome);
            groupBox2.Controls.Add(txtClienteId);
            groupBox2.Location = new Point(15, 200);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(846, 109);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados do Cliente";
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
            // txtClienteNome
            // 
            txtClienteNome.Location = new Point(314, 44);
            txtClienteNome.Name = "txtClienteNome";
            txtClienteNome.Size = new Size(459, 29);
            txtClienteNome.TabIndex = 1;
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(62, 45);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(138, 29);
            txtClienteId.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(871, 35);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 9;
            label3.Text = "Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 133);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 8;
            label2.Text = "Vendedor";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(122, 130);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(739, 29);
            txtVendedor.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F);
            textBox1.ForeColor = Color.Green;
            textBox1.Location = new Point(871, 59);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(169, 50);
            textBox1.TabIndex = 6;
            textBox1.Text = "0";
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1144, 845);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.HotTrack;
            Margin = new Padding(4);
            Name = "FrmPedido";
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtDataPed;
        private Label label4;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private TextBox txtVendedor;
        private GroupBox groupBox3;
        private TextBox txtValorUnit;
        private Label label6;
        private TextBox txtDescricao;
        private Label label5;
        private TextBox txtCodBarras;
        private TextBox txtClienteNome;
        private TextBox txtClienteId;
        private Label label7;
        private Button btnAbrirPedido;
        private Button btnInserirProduto;
        private TextBox txtQuantidade;
        private Label label8;
        private DataGridView dgvPedido;
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
        private DataGridViewTextBoxColumn clnCod;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnValorItem;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private Label label14;
        private Label label13;
    }
}