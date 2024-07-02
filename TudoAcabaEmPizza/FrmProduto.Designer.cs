namespace TudoAcabaEmPizza
{
    partial class FrmProduto
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
            gbProdutos = new GroupBox();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnInserir = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            mtbCodBarras = new MaskedTextBox();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtDescricao = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            dgvProdutos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            CodBarras = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            UniVenda = new DataGridViewTextBoxColumn();
            CategoriaId = new DataGridViewTextBoxColumn();
            EstoqueMin = new DataGridViewTextBoxColumn();
            Desconto = new DataGridViewTextBoxColumn();
            label9 = new Label();
            gbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // gbProdutos
            // 
            gbProdutos.Controls.Add(btnConsultar);
            gbProdutos.Controls.Add(btnEditar);
            gbProdutos.Controls.Add(btnInserir);
            gbProdutos.Controls.Add(textBox2);
            gbProdutos.Controls.Add(textBox3);
            gbProdutos.Controls.Add(label1);
            gbProdutos.Controls.Add(label8);
            gbProdutos.Controls.Add(label2);
            gbProdutos.Controls.Add(txtId);
            gbProdutos.Controls.Add(label7);
            gbProdutos.Controls.Add(comboBox1);
            gbProdutos.Controls.Add(comboBox2);
            gbProdutos.Controls.Add(mtbCodBarras);
            gbProdutos.Controls.Add(label6);
            gbProdutos.Controls.Add(label3);
            gbProdutos.Controls.Add(label5);
            gbProdutos.Controls.Add(txtDescricao);
            gbProdutos.Controls.Add(textBox1);
            gbProdutos.Controls.Add(label4);
            gbProdutos.Location = new Point(270, 52);
            gbProdutos.Name = "gbProdutos";
            gbProdutos.Size = new Size(520, 375);
            gbProdutos.TabIndex = 16;
            gbProdutos.TabStop = false;
            gbProdutos.Text = "Dados de inserção";
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.ForestGreen;
            btnConsultar.ForeColor = SystemColors.ControlLightLight;
            btnConsultar.Location = new Point(402, 326);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(79, 30);
            btnConsultar.TabIndex = 17;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.ForestGreen;
            btnEditar.ForeColor = SystemColors.ControlLightLight;
            btnEditar.Location = new Point(237, 326);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(79, 30);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.ForestGreen;
            btnInserir.ForeColor = SystemColors.ControlLightLight;
            btnInserir.Location = new Point(53, 326);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(79, 30);
            btnInserir.TabIndex = 15;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(216, 241);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(216, 278);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 23);
            textBox3.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 29);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(101, 281);
            label8.Name = "label8";
            label8.Size = new Size(109, 15);
            label8.TabIndex = 13;
            label8.Text = "Classe de Desconto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 64);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 0;
            label2.Text = "Código de Barras";
            // 
            // txtId
            // 
            txtId.Location = new Point(216, 26);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(55, 23);
            txtId.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(116, 244);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 11;
            label7.Text = "Estoque mínimo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(216, 171);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 23);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(216, 206);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(164, 23);
            comboBox2.TabIndex = 10;
            // 
            // mtbCodBarras
            // 
            mtbCodBarras.Location = new Point(216, 61);
            mtbCodBarras.Name = "mtbCodBarras";
            mtbCodBarras.Size = new Size(164, 23);
            mtbCodBarras.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(152, 209);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 9;
            label6.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 102);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 174);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 8;
            label5.Text = "Unidade de Venda";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(216, 99);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(164, 23);
            txtDescricao.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 139);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 6;
            label4.Text = "Valor Unitário";
            // 
            // dgvProdutos
            // 
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { Id, CodBarras, Descricao, Valor, UniVenda, CategoriaId, EstoqueMin, Desconto });
            dgvProdutos.Location = new Point(106, 451);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.Size = new Size(825, 150);
            dgvProdutos.TabIndex = 18;
            // 
            // Id
            // 
            Id.Frozen = true;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 60;
            // 
            // CodBarras
            // 
            CodBarras.HeaderText = "Código de Barras";
            CodBarras.Name = "CodBarras";
            CodBarras.ReadOnly = true;
            CodBarras.Width = 122;
            // 
            // Descricao
            // 
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Width = 150;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            // 
            // UniVenda
            // 
            UniVenda.HeaderText = "Unidada de Venda";
            UniVenda.Name = "UniVenda";
            UniVenda.ReadOnly = true;
            UniVenda.Width = 110;
            // 
            // CategoriaId
            // 
            CategoriaId.HeaderText = "Categoria ID";
            CategoriaId.Name = "CategoriaId";
            CategoriaId.ReadOnly = true;
            // 
            // EstoqueMin
            // 
            EstoqueMin.HeaderText = "Estoque Mínimo";
            EstoqueMin.Name = "EstoqueMin";
            EstoqueMin.ReadOnly = true;
            EstoqueMin.Width = 110;
            // 
            // Desconto
            // 
            Desconto.HeaderText = "Desconto";
            Desconto.Name = "Desconto";
            Desconto.ReadOnly = true;
            Desconto.Width = 70;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.ForestGreen;
            label9.Location = new Point(464, 13);
            label9.Name = "label9";
            label9.Size = new Size(156, 36);
            label9.TabIndex = 19;
            label9.Text = "Produto";
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1047, 613);
            Controls.Add(label9);
            Controls.Add(dgvProdutos);
            Controls.Add(gbProdutos);
            Name = "FrmProduto";
            Text = "FrmProduto";
            gbProdutos.ResumeLayout(false);
            gbProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbProdutos;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnInserir;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label8;
        private Label label2;
        private TextBox txtId;
        private Label label7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private MaskedTextBox mtbCodBarras;
        private Label label6;
        private Label label3;
        private Label label5;
        private TextBox txtDescricao;
        private TextBox textBox1;
        private Label label4;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CodBarras;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn UniVenda;
        private DataGridViewTextBoxColumn CategoriaId;
        private DataGridViewTextBoxColumn EstoqueMin;
        private DataGridViewTextBoxColumn Desconto;
        private Label label9;
    }
}