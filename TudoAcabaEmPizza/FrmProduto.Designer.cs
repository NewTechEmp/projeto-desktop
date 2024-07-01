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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            gbProduto = new GroupBox();
            gbProduto.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 17);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 56);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Código de Barras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 95);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 3;
            label3.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 137);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 2;
            label4.Text = "Valor unitário";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 298);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 7;
            label5.Text = "Classe de Desconto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 259);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 6;
            label6.Text = "Estoque minimo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(101, 217);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 5;
            label7.Text = "Categoria";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 177);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 4;
            label8.Text = "Unidade de Venda";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 14);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(51, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(165, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 23);
            textBox2.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(165, 53);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(183, 23);
            maskedTextBox1.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(165, 137);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(183, 23);
            textBox3.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(165, 174);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 23);
            comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(165, 214);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(183, 23);
            comboBox2.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(165, 256);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(183, 23);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(165, 295);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(183, 23);
            textBox5.TabIndex = 15;
            // 
            // gbProduto
            // 
            gbProduto.Controls.Add(maskedTextBox1);
            gbProduto.Controls.Add(textBox5);
            gbProduto.Controls.Add(label1);
            gbProduto.Controls.Add(textBox4);
            gbProduto.Controls.Add(label2);
            gbProduto.Controls.Add(comboBox2);
            gbProduto.Controls.Add(label4);
            gbProduto.Controls.Add(comboBox1);
            gbProduto.Controls.Add(label3);
            gbProduto.Controls.Add(textBox3);
            gbProduto.Controls.Add(label8);
            gbProduto.Controls.Add(label7);
            gbProduto.Controls.Add(textBox2);
            gbProduto.Controls.Add(label6);
            gbProduto.Controls.Add(textBox1);
            gbProduto.Controls.Add(label5);
            gbProduto.Location = new Point(182, 50);
            gbProduto.Name = "gbProduto";
            gbProduto.Size = new Size(409, 323);
            gbProduto.TabIndex = 16;
            gbProduto.TabStop = false;
            gbProduto.Text = "Dados de inserção";
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(gbProduto);
            Name = "FrmProduto";
            Text = "FrmProduto";
            gbProduto.ResumeLayout(false);
            gbProduto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private GroupBox gbProduto;
    }
}