namespace TudoAcabaEmPizza
{
    partial class FrmCaixa
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            btnAbrir = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            btnEncerrar = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(844, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 275);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(462, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(462, 105);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Caixa";
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(142, 523);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(384, 34);
            btnAbrir.TabIndex = 3;
            btnAbrir.Text = "Abrir Pedido";
            btnAbrir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(462, 201);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 5;
            label2.Text = "Quantidade";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(462, 219);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(462, 308);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 7;
            label3.Text = "Valor Unitário";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(462, 326);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 23);
            textBox3.TabIndex = 6;
            // 
            // btnEncerrar
            // 
            btnEncerrar.Location = new Point(741, 523);
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.Size = new Size(384, 34);
            btnEncerrar.TabIndex = 8;
            btnEncerrar.Text = "Encerrar Pedido";
            btnEncerrar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 404);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 10;
            label4.Text = "Valor Total";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(462, 422);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(300, 23);
            textBox4.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(386, 404);
            dataGridView1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(556, 9);
            label5.Name = "label5";
            label5.Size = new Size(101, 36);
            label5.TabIndex = 12;
            label5.Text = "Caixa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(849, 404);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 14;
            label6.Text = "Subtotal";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(849, 422);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(300, 23);
            textBox5.TabIndex = 13;
            // 
            // FrmCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 600);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(btnEncerrar);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(btnAbrir);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.HotTrack;
            Name = "FrmCaixa";
            Text = "FrmCaixa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private Button btnAbrir;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button btnEncerrar;
        private Label label4;
        private TextBox textBox4;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
    }
}