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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox3 = new GroupBox();
            textBox6 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox8 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            clnCod = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorItem = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            label9 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            groupBox1.Controls.Add(textBox11);
            groupBox1.Controls.Add(textBox10);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
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
            // textBox2
            // 
            textBox2.Location = new Point(122, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(469, 29);
            textBox2.TabIndex = 7;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(871, 35);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 9;
            label3.Text = "Número";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Location = new Point(15, 200);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(846, 109);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados do Cliente";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(16, 45);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 29);
            textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(272, 45);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(465, 29);
            textBox4.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Location = new Point(15, 327);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1011, 152);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Produto";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(6, 89);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(153, 29);
            textBox6.TabIndex = 0;
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
            // textBox5
            // 
            textBox5.Location = new Point(178, 89);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(246, 29);
            textBox5.TabIndex = 10;
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
            // textBox7
            // 
            textBox7.Location = new Point(442, 89);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(121, 29);
            textBox7.TabIndex = 12;
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
            // textBox8
            // 
            textBox8.Location = new Point(585, 89);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(121, 29);
            textBox8.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(871, 84);
            button1.Name = "button1";
            button1.Size = new Size(134, 34);
            button1.TabIndex = 16;
            button1.Text = "&Inserir";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(887, 245);
            button2.Name = "button2";
            button2.Size = new Size(139, 44);
            button2.TabIndex = 17;
            button2.Text = "&Abrir Pedido";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clnCod, clnDesconto, clnDescricao, clnValorItem, clnValorUnit, clnQuantidade });
            dataGridView1.Location = new Point(14, 515);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(830, 278);
            dataGridView1.TabIndex = 18;
            // 
            // clnCod
            // 
            clnCod.Frozen = true;
            clnCod.HeaderText = "Cod Barras";
            clnCod.Name = "clnCod";
            clnCod.ReadOnly = true;
            clnCod.Width = 120;
            // 
            // clnDesconto
            // 
            clnDesconto.Frozen = true;
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 160;
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
            // button3
            // 
            button3.Location = new Point(850, 750);
            button3.Name = "button3";
            button3.Size = new Size(215, 43);
            button3.TabIndex = 19;
            button3.Text = "Finalizar &Pedido";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(850, 701);
            button4.Name = "button4";
            button4.Size = new Size(131, 43);
            button4.TabIndex = 20;
            button4.Text = "Excluir &Item";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(725, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 29);
            comboBox1.TabIndex = 17;
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
            // textBox9
            // 
            textBox9.Location = new Point(850, 666);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(190, 29);
            textBox9.TabIndex = 21;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(850, 595);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(190, 29);
            textBox10.TabIndex = 21;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(850, 529);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(190, 29);
            textBox11.TabIndex = 21;
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox textBox2;
        private GroupBox groupBox3;
        private TextBox textBox7;
        private Label label6;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label7;
        private Button button2;
        private Button button1;
        private TextBox textBox8;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clnCod;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorItem;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private Button button4;
        private Button button3;
        private Label label9;
        private ComboBox comboBox1;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private Label label12;
        private Label label11;
        private Label label10;
    }
}