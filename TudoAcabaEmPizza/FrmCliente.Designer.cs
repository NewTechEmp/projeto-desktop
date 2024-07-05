namespace TudoAcabaEmPizza
{
    partial class FrmCliente
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
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ID = new Label();
            btnInserir = new Button();
            btnConsultar = new Button();
            btnEditar = new Button();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            txtCPF = new TextBox();
            txtDataNasc = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(275, 23);
            label1.Name = "label1";
            label1.Size = new Size(197, 31);
            label1.TabIndex = 0;
            label1.Text = "Dados Cliente";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(20, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(768, 527);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(6, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(756, 498);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(ID);
            tabPage1.Controls.Add(btnInserir);
            tabPage1.Controls.Add(btnConsultar);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(txtSenha);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtCPF);
            tabPage1.Controls.Add(txtDataNasc);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(748, 470);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(748, 470);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(129, 231);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 16;
            label7.Text = "Senha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(129, 188);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 17;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(129, 143);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 18;
            label5.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 106);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 19;
            label4.Text = "Data Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 59);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 20;
            label3.Text = "Nome";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(149, 13);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 21;
            ID.Text = "ID";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(499, 275);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 13;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(337, 275);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 14;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(173, 275);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(173, 223);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(390, 23);
            txtSenha.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(173, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(390, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(173, 135);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(390, 23);
            txtCPF.TabIndex = 9;
            // 
            // txtDataNasc
            // 
            txtDataNasc.Location = new Point(173, 98);
            txtDataNasc.Name = "txtDataNasc";
            txtDataNasc.Size = new Size(390, 23);
            txtDataNasc.TabIndex = 10;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(173, 51);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(390, 23);
            txtNome.TabIndex = 11;
            // 
            // txtId
            // 
            txtId.Location = new Point(173, 13);
            txtId.Name = "txtId";
            txtId.Size = new Size(68, 23);
            txtId.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(6, 304);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(735, 156);
            dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.HeaderText = "Data Nascimento";
            Column3.Name = "Column3";
            Column3.Width = 108;
            // 
            // Column4
            // 
            Column4.HeaderText = "CPF";
            Column4.Name = "Column4";
            Column4.Width = 111;
            // 
            // Column5
            // 
            Column5.HeaderText = "Email";
            Column5.Name = "Column5";
            Column5.Width = 213;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 677);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label ID;
        private Button btnInserir;
        private Button btnConsultar;
        private Button btnEditar;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private TextBox txtCPF;
        private TextBox txtDataNasc;
        private TextBox txtNome;
        private TextBox txtId;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TabPage tabPage2;
    }
}