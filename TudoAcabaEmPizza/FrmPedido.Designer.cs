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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            label1 = new Label();
            txtCodBarras = new TextBox();
            label2 = new Label();
            btnInserir = new Button();
            btnExcluir = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            txtQuant = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cmbItemAdicional = new ComboBox();
            txtSubTotal = new TextBox();
            txtTotal = new TextBox();
            comboBox1 = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            dgvPedido = new DataGridView();
            btnFinalizarPed = new Button();
            label13 = new Label();
            pictureBox2 = new PictureBox();
            lblFuncionario = new Label();
            lblCargoFuncionario = new Label();
            lsbProdutos = new ListBox();
            groupBox1 = new GroupBox();
            comboBox4 = new ComboBox();
            comboBox2 = new ComboBox();
            pictureBox3 = new PictureBox();
            dtpDataPedido = new DateTimePicker();
            btnEditar = new Button();
            btnCancelar = new Button();
            cmbITamanho = new ComboBox();
            label14 = new Label();
            textBox1 = new TextBox();
            label15 = new Label();
            textBox2 = new TextBox();
            clnFuncionario = new DataGridViewTextBoxColumn();
            clnNomeCliente = new DataGridViewTextBoxColumn();
            clnSubTotal = new DataGridViewTextBoxColumn();
            clnTotal = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnTanho = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(285, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(434, 46);
            label1.TabIndex = 0;
            label1.Text = "Tudo Acaba em Pizza!";
            label1.Click += label1_Click;
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(563, 247);
            txtCodBarras.Margin = new Padding(4);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(250, 29);
            txtCodBarras.TabIndex = 1;
            txtCodBarras.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(272, 327);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 2;
            label2.Text = "Produto";
            label2.Click += label2_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(867, 349);
            btnInserir.Margin = new Padding(2, 3, 2, 3);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(106, 29);
            btnInserir.TabIndex = 3;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += button1_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(985, 348);
            btnExcluir.Margin = new Padding(2, 3, 2, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(106, 30);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "&Excluir ";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(270, 222);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 2;
            label3.Text = "Data pedido";
            label3.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.ForestGreen;
            pictureBox1.Location = new Point(12, 31);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtQuant
            // 
            txtQuant.Location = new Point(563, 435);
            txtQuant.Margin = new Padding(4);
            txtQuant.Name = "txtQuant";
            txtQuant.Size = new Size(250, 29);
            txtQuant.TabIndex = 1;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(270, 410);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 6;
            label5.Text = "Tamanho";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.ForestGreen;
            label6.Location = new Point(563, 410);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 7;
            label6.Text = "Quantidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.ForestGreen;
            label7.Location = new Point(867, 410);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 21);
            label7.TabIndex = 8;
            label7.Text = "Desconto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.ForestGreen;
            label8.Location = new Point(563, 222);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(139, 21);
            label8.TabIndex = 9;
            label8.Text = "Código de Barras";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.ForestGreen;
            label9.Location = new Point(867, 222);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(122, 21);
            label9.TabIndex = 10;
            label9.Text = "Item Adicional";
            // 
            // cmbItemAdicional
            // 
            cmbItemAdicional.FormattingEnabled = true;
            cmbItemAdicional.Location = new Point(867, 250);
            cmbItemAdicional.Margin = new Padding(2, 3, 2, 3);
            cmbItemAdicional.Name = "cmbItemAdicional";
            cmbItemAdicional.Size = new Size(224, 29);
            cmbItemAdicional.TabIndex = 11;
            cmbItemAdicional.SelectedIndexChanged += cmbItemAdicional_SelectedIndexChanged;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(270, 504);
            txtSubTotal.Margin = new Padding(4);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(252, 29);
            txtSubTotal.TabIndex = 12;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(563, 504);
            txtTotal.Margin = new Padding(4);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(252, 29);
            txtTotal.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(867, 504);
            comboBox1.Margin = new Padding(2, 3, 2, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 29);
            comboBox1.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.ForestGreen;
            label10.Location = new Point(270, 479);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(83, 21);
            label10.TabIndex = 15;
            label10.Text = "Sub-Total";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.ForestGreen;
            label11.Location = new Point(563, 479);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(48, 21);
            label11.TabIndex = 16;
            label11.Text = "Total";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.ForestGreen;
            label12.Location = new Point(867, 480);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(185, 21);
            label12.TabIndex = 17;
            label12.Text = "Método de Pagamento";
            // 
            // dgvPedido
            // 
            dgvPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedido.Columns.AddRange(new DataGridViewColumn[] { clnFuncionario, clnNomeCliente, clnSubTotal, clnTotal, clnDesconto, clnTanho });
            dgvPedido.Location = new Point(270, 561);
            dgvPedido.Margin = new Padding(2, 3, 2, 3);
            dgvPedido.Name = "dgvPedido";
            dgvPedido.RowHeadersVisible = false;
            dgvPedido.Size = new Size(821, 210);
            dgvPedido.TabIndex = 18;
            // 
            // btnFinalizarPed
            // 
            btnFinalizarPed.BackColor = Color.ForestGreen;
            btnFinalizarPed.ForeColor = SystemColors.HighlightText;
            btnFinalizarPed.Location = new Point(22, 706);
            btnFinalizarPed.Margin = new Padding(2, 3, 2, 3);
            btnFinalizarPed.Name = "btnFinalizarPed";
            btnFinalizarPed.Size = new Size(166, 38);
            btnFinalizarPed.TabIndex = 19;
            btnFinalizarPed.Text = "&Finalizar Pedido";
            btnFinalizarPed.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(48, 194);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(131, 15);
            label13.TabIndex = 20;
            label13.Text = "Você foi Atendido Por:";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(12, 214);
            pictureBox2.Margin = new Padding(2, 3, 2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // lblFuncionario
            // 
            lblFuncionario.AutoSize = true;
            lblFuncionario.Location = new Point(119, 213);
            lblFuncionario.Margin = new Padding(2, 0, 2, 0);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(57, 21);
            lblFuncionario.TabIndex = 24;
            lblFuncionario.Text = "Nome";
            lblFuncionario.Click += lblFuncionario_Click;
            // 
            // lblCargoFuncionario
            // 
            lblCargoFuncionario.AutoSize = true;
            lblCargoFuncionario.Location = new Point(119, 245);
            lblCargoFuncionario.Margin = new Padding(2, 0, 2, 0);
            lblCargoFuncionario.Name = "lblCargoFuncionario";
            lblCargoFuncionario.Size = new Size(55, 21);
            lblCargoFuncionario.TabIndex = 24;
            lblCargoFuncionario.Text = "Cargo";
            // 
            // lsbProdutos
            // 
            lsbProdutos.BackColor = SystemColors.HighlightText;
            lsbProdutos.ForeColor = Color.ForestGreen;
            lsbProdutos.FormattingEnabled = true;
            lsbProdutos.ItemHeight = 21;
            lsbProdutos.Items.AddRange(new object[] { "1 - Pizza de Mussarela", "2 - Pizza Calabresa", "3 - Pizza Moda Donatello", "4 - Pizza Sensação", "5 - Pizza Ouro Branco", "6 - Coca Cola 3 litros", "7 - Queijo Extra", "8 - Bacon Extra", "9 - Cheddar", "10 - Calabresa Extra" });
            lsbProdutos.Location = new Point(12, 315);
            lsbProdutos.Margin = new Padding(2, 3, 2, 3);
            lsbProdutos.Name = "lsbProdutos";
            lsbProdutos.Size = new Size(189, 277);
            lsbProdutos.TabIndex = 25;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(dtpDataPedido);
            groupBox1.Controls.Add(dgvPedido);
            groupBox1.Controls.Add(lsbProdutos);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblCargoFuncionario);
            groupBox1.Controls.Add(lblFuncionario);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(txtQuant);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnFinalizarPed);
            groupBox1.Controls.Add(txtCodBarras);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSubTotal);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbITamanho);
            groupBox1.Controls.Add(cmbItemAdicional);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.ForeColor = Color.ForestGreen;
            groupBox1.Location = new Point(39, 22);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(1220, 798);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pedido";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(351, 324);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(464, 29);
            comboBox4.TabIndex = 28;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(868, 435);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(223, 29);
            comboBox2.TabIndex = 28;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(22, 42);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(166, 136);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // dtpDataPedido
            // 
            dtpDataPedido.CalendarForeColor = SystemColors.InactiveCaptionText;
            dtpDataPedido.CalendarTitleForeColor = SystemColors.InfoText;
            dtpDataPedido.Enabled = false;
            dtpDataPedido.Format = DateTimePickerFormat.Short;
            dtpDataPedido.Location = new Point(270, 247);
            dtpDataPedido.Margin = new Padding(2, 3, 2, 3);
            dtpDataPedido.Name = "dtpDataPedido";
            dtpDataPedido.Size = new Size(252, 29);
            dtpDataPedido.TabIndex = 26;
            dtpDataPedido.Value = new DateTime(2024, 7, 4, 11, 16, 16, 0);
            dtpDataPedido.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.ForestGreen;
            btnEditar.ForeColor = SystemColors.HighlightText;
            btnEditar.Location = new Point(22, 598);
            btnEditar.Margin = new Padding(2, 3, 2, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(166, 30);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.ForestGreen;
            btnCancelar.ForeColor = SystemColors.HighlightText;
            btnCancelar.Location = new Point(22, 653);
            btnCancelar.Margin = new Padding(2, 3, 2, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(166, 29);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // cmbITamanho
            // 
            cmbITamanho.FormattingEnabled = true;
            cmbITamanho.Location = new Point(270, 435);
            cmbITamanho.Margin = new Padding(2, 3, 2, 3);
            cmbITamanho.Name = "cmbITamanho";
            cmbITamanho.Size = new Size(224, 29);
            cmbITamanho.TabIndex = 11;
            cmbITamanho.SelectedIndexChanged += cmbItemAdicional_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.ForestGreen;
            label14.Location = new Point(218, 140);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(85, 21);
            label14.TabIndex = 2;
            label14.Text = "Cliente ID";
            label14.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(287, 184);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(804, 29);
            textBox1.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.ForestGreen;
            label15.Location = new Point(218, 184);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(61, 21);
            label15.TabIndex = 2;
            label15.Text = "Nome:";
            label15.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(311, 137);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(47, 29);
            textBox2.TabIndex = 1;
            // 
            // clnFuncionario
            // 
            clnFuncionario.Frozen = true;
            clnFuncionario.HeaderText = "Funcionário";
            clnFuncionario.Name = "clnFuncionario";
            clnFuncionario.ReadOnly = true;
            clnFuncionario.Width = 178;
            // 
            // clnNomeCliente
            // 
            clnNomeCliente.Frozen = true;
            clnNomeCliente.HeaderText = "Nome do Cliente";
            clnNomeCliente.Name = "clnNomeCliente";
            clnNomeCliente.ReadOnly = true;
            clnNomeCliente.Width = 180;
            // 
            // clnSubTotal
            // 
            clnSubTotal.Frozen = true;
            clnSubTotal.HeaderText = "SubTotal";
            clnSubTotal.Name = "clnSubTotal";
            clnSubTotal.ReadOnly = true;
            // 
            // clnTotal
            // 
            clnTotal.Frozen = true;
            clnTotal.HeaderText = "Total";
            clnTotal.Name = "clnTotal";
            clnTotal.ReadOnly = true;
            // 
            // clnDesconto
            // 
            clnDesconto.Frozen = true;
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            clnDesconto.Width = 120;
            // 
            // clnTanho
            // 
            clnTanho.Frozen = true;
            clnTanho.HeaderText = "Tamanho Pizza";
            clnTanho.Name = "clnTanho";
            clnTanho.ReadOnly = true;
            clnTanho.Width = 140;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1924, 845);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.HotTrack;
            Margin = new Padding(4);
            Name = "FrmPedido";
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtDataPed;
        private TextBox txtCodBarras;
        private Label label2;
        private Button btnInserir;
        private Button btnExcluir;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox txtQuant;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cmbItemAdicional;
        private TextBox txtSubTotal;
        private TextBox txtTotal;
        private ComboBox comboBox1;
        private Label label10;
        private Label label11;
        private Label label12;
        private DataGridView dgvPedido;
        private Button btnFinalizarPed;
        private Label label13;
        private PictureBox pictureBox2;
        private Label lblFuncionario;
        private Label lblCargoFuncionario;
        private ListBox lsbProdutos;
        private GroupBox groupBox1;
        private DateTimePicker dtpDataPedido;
        private Button btnEditar;
        private Button btnCancelar;
        private ComboBox cmbITamanho;
        private PictureBox pictureBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox4;
        private Label label14;
        private TextBox textBox1;
        private Label label15;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn clnFuncionario;
        private DataGridViewTextBoxColumn clnNomeCliente;
        private DataGridViewTextBoxColumn clnSubTotal;
        private DataGridViewTextBoxColumn clnTotal;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnTanho;
    }
}