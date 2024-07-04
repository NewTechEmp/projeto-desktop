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
            txtProduto = new TextBox();
            label2 = new Label();
            btnInserir = new Button();
            btnExcluir = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            txtQuant = new TextBox();
            txtDesconto = new TextBox();
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
            dataGridView1 = new DataGridView();
            btnFinalizarPed = new Button();
            label13 = new Label();
            pictureBox2 = new PictureBox();
            lblFuncionario = new Label();
            lblCargoFuncionario = new Label();
            lblData = new Label();
            lsbProdutos = new ListBox();
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            btnEditar = new Button();
            btnCancelar = new Button();
            cmbITamanho = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            txtCodBarras.Location = new Point(578, 112);
            txtCodBarras.Margin = new Padding(4);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(250, 29);
            txtCodBarras.TabIndex = 1;
            txtCodBarras.TextChanged += textBox2_TextChanged;
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(285, 214);
            txtProduto.Margin = new Padding(4);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(543, 29);
            txtProduto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(285, 189);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 2;
            label2.Text = "Produto";
            label2.Click += label2_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(882, 214);
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
            btnExcluir.Location = new Point(1000, 213);
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
            label3.Location = new Point(285, 87);
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
            txtQuant.Location = new Point(578, 300);
            txtQuant.Margin = new Padding(4);
            txtQuant.Name = "txtQuant";
            txtQuant.Size = new Size(250, 29);
            txtQuant.TabIndex = 1;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(882, 300);
            txtDesconto.Margin = new Padding(4);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(224, 29);
            txtDesconto.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 402);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(285, 275);
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
            label6.Location = new Point(578, 275);
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
            label7.Location = new Point(882, 275);
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
            label8.Location = new Point(578, 87);
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
            label9.Location = new Point(882, 87);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(122, 21);
            label9.TabIndex = 10;
            label9.Text = "Item Adicional";
            // 
            // cmbItemAdicional
            // 
            cmbItemAdicional.FormattingEnabled = true;
            cmbItemAdicional.Location = new Point(882, 115);
            cmbItemAdicional.Margin = new Padding(2, 3, 2, 3);
            cmbItemAdicional.Name = "cmbItemAdicional";
            cmbItemAdicional.Size = new Size(224, 29);
            cmbItemAdicional.TabIndex = 11;
            cmbItemAdicional.SelectedIndexChanged += cmbItemAdicional_SelectedIndexChanged;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(285, 369);
            txtSubTotal.Margin = new Padding(4);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(252, 29);
            txtSubTotal.TabIndex = 12;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(578, 369);
            txtTotal.Margin = new Padding(4);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(252, 29);
            txtTotal.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(882, 369);
            comboBox1.Margin = new Padding(2, 3, 2, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 29);
            comboBox1.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.ForestGreen;
            label10.Location = new Point(285, 344);
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
            label11.Location = new Point(578, 344);
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
            label12.Location = new Point(882, 345);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(185, 21);
            label12.TabIndex = 17;
            label12.Text = "Método de Pagamento";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(285, 426);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(821, 210);
            dataGridView1.TabIndex = 18;
            // 
            // btnFinalizarPed
            // 
            btnFinalizarPed.BackColor = Color.ForestGreen;
            btnFinalizarPed.ForeColor = SystemColors.HighlightText;
            btnFinalizarPed.Location = new Point(22, 669);
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
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(119, 275);
            lblData.Margin = new Padding(2, 0, 2, 0);
            lblData.Name = "lblData";
            lblData.Size = new Size(46, 21);
            lblData.TabIndex = 24;
            lblData.Text = "Data";
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
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(lsbProdutos);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblData);
            groupBox1.Controls.Add(lblCargoFuncionario);
            groupBox1.Controls.Add(lblFuncionario);
            groupBox1.Controls.Add(txtQuant);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(txtDesconto);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtProduto);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnFinalizarPed);
            groupBox1.Controls.Add(txtCodBarras);
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
            groupBox1.Size = new Size(1112, 713);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pedido";
            groupBox1.Enter += groupBox1_Enter;
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
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = SystemColors.InactiveCaptionText;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.InfoText;
            dateTimePicker1.Location = new Point(285, 112);
            dateTimePicker1.Margin = new Padding(2, 3, 2, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(252, 29);
            dateTimePicker1.TabIndex = 26;
            dateTimePicker1.Value = new DateTime(2024, 7, 2, 9, 39, 34, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
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
            btnCancelar.Location = new Point(22, 634);
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
            cmbITamanho.Location = new Point(285, 300);
            cmbITamanho.Margin = new Padding(2, 3, 2, 3);
            cmbITamanho.Name = "cmbITamanho";
            cmbITamanho.Size = new Size(224, 29);
            cmbITamanho.TabIndex = 11;
            cmbITamanho.SelectedIndexChanged += cmbItemAdicional_SelectedIndexChanged;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox txtProduto;
        private Label label2;
        private Button btnInserir;
        private Button btnExcluir;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox txtQuant;
        private TextBox txtDesconto;
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
        private DataGridView dataGridView1;
        private Button btnFinalizarPed;
        private Label label13;
        private PictureBox pictureBox2;
        private Label lblFuncionario;
        private Label lblCargoFuncionario;
        private Label lblData;
        private ListBox lsbProdutos;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Button btnEditar;
        private Button btnCancelar;
        private ComboBox cmbITamanho;
        private PictureBox pictureBox3;
    }
}