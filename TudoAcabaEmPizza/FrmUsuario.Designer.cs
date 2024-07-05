namespace TudoAcabaEmPizza
{
    partial class FrmUsuario
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtNome = new TextBox();
            txtNivel = new TextBox();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            btnInserir = new Button();
            btnAlterar = new Button();
            btnConsultar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgvUsuario = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Ativo = new DataGridViewTextBoxColumn();
            NivelId = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label1 = new Label();
            pbUsuario = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtNivel);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(btnAlterar);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dgvUsuario);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pbUsuario);
            groupBox1.Location = new Point(80, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(921, 618);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.ForestGreen;
            label6.Location = new Point(41, 240);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 7;
            label6.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(41, 258);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(193, 23);
            txtNome.TabIndex = 6;
            // 
            // txtNivel
            // 
            txtNivel.Location = new Point(759, 258);
            txtNivel.Name = "txtNivel";
            txtNivel.Size = new Size(105, 23);
            txtNivel.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(534, 258);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(178, 23);
            txtSenha.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(300, 258);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 23);
            txtEmail.TabIndex = 5;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.ForestGreen;
            btnInserir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserir.ForeColor = SystemColors.ControlLightLight;
            btnInserir.Location = new Point(710, 361);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(85, 33);
            btnInserir.TabIndex = 4;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.ForestGreen;
            btnAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.ForeColor = SystemColors.ControlLightLight;
            btnAlterar.Location = new Point(436, 361);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(93, 33);
            btnAlterar.TabIndex = 4;
            btnAlterar.Text = "&Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += button2_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.ForestGreen;
            btnConsultar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = SystemColors.ControlLightLight;
            btnConsultar.Location = new Point(145, 361);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(98, 33);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(759, 240);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 3;
            label5.Text = "Nivel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(534, 240);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(300, 240);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 3;
            label3.Text = "E-mail";
            // 
            // dgvUsuario
            // 
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Email, Ativo, NivelId });
            dgvUsuario.Location = new Point(111, 400);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.RowHeadersVisible = false;
            dgvUsuario.Size = new Size(703, 198);
            dgvUsuario.TabIndex = 2;
            // 
            // Id
            // 
            Id.Frozen = true;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 150;
            // 
            // Email
            // 
            Email.HeaderText = "E-mail";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 150;
            // 
            // Ativo
            // 
            Ativo.HeaderText = "Ativo";
            Ativo.Name = "Ativo";
            Ativo.ReadOnly = true;
            Ativo.Width = 150;
            // 
            // NivelId
            // 
            NivelId.HeaderText = "Nível_ID";
            NivelId.Name = "NivelId";
            NivelId.ReadOnly = true;
            NivelId.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 17.75F);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(396, 96);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 30);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(264, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(434, 46);
            label1.TabIndex = 1;
            label1.Text = "Tudo Acaba em Pizza!";
            // 
            // pbUsuario
            // 
            pbUsuario.Location = new Point(6, 22);
            pbUsuario.Name = "pbUsuario";
            pbUsuario.Size = new Size(151, 143);
            pbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUsuario.TabIndex = 0;
            pbUsuario.TabStop = false;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 679);
            Controls.Add(groupBox1);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pbUsuario;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dgvUsuario;
        private Label label2;
        private Label label1;
        private TextBox txtNivel;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Button btnInserir;
        private Button btnAlterar;
        private Button btnConsultar;
        private TextBox txtNome;
        private Label label6;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Ativo;
        private DataGridViewTextBoxColumn NivelId;
    }
}