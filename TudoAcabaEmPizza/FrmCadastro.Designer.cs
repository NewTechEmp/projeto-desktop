namespace TudoAcabaEmPizza
{
    partial class FrmCadastro
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
            btnInserir = new Button();
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            gbCadastro = new GroupBox();
            button1 = new Button();
            btnEditar = new Button();
            label8 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtCpf = new TextBox();
            gbCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // btnInserir
            // 
            btnInserir.BackColor = SystemColors.HotTrack;
            btnInserir.ForeColor = SystemColors.ControlLightLight;
            btnInserir.Location = new Point(489, 229);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 32);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(355, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 36);
            label1.TabIndex = 1;
            label1.Text = "Cadastre-se";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(60, 65);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(224, 23);
            txtNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(60, 47);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // gbCadastro
            // 
            gbCadastro.Controls.Add(button1);
            gbCadastro.Controls.Add(btnEditar);
            gbCadastro.Controls.Add(label8);
            gbCadastro.Controls.Add(textBox2);
            gbCadastro.Controls.Add(label7);
            gbCadastro.Controls.Add(textBox1);
            gbCadastro.Controls.Add(label5);
            gbCadastro.Controls.Add(txtEmail);
            gbCadastro.Controls.Add(label3);
            gbCadastro.Controls.Add(txtCpf);
            gbCadastro.Controls.Add(txtNome);
            gbCadastro.Controls.Add(label2);
            gbCadastro.Controls.Add(btnInserir);
            gbCadastro.ForeColor = SystemColors.HotTrack;
            gbCadastro.Location = new Point(137, 82);
            gbCadastro.Name = "gbCadastro";
            gbCadastro.Size = new Size(643, 315);
            gbCadastro.TabIndex = 3;
            gbCadastro.TabStop = false;
            gbCadastro.Text = "Informações para cadastro";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(60, 229);
            button1.Name = "button1";
            button1.Size = new Size(79, 32);
            button1.TabIndex = 16;
            button1.Text = "&Excluir";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.HotTrack;
            btnEditar.ForeColor = SystemColors.ControlLightLight;
            btnEditar.Location = new Point(273, 229);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 32);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 151);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 14;
            label8.Text = "2º Telefone";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(60, 169);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Opcional";
            textBox2.Size = new Size(224, 23);
            textBox2.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(340, 100);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 12;
            label7.Text = "Telefone";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(340, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 23);
            textBox1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 100);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(60, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 23);
            txtEmail.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(340, 47);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 4;
            label3.Text = "CPF";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(340, 65);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(224, 23);
            txtCpf.TabIndex = 3;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 511);
            Controls.Add(gbCadastro);
            Controls.Add(label1);
            Name = "FrmCadastro";
            Text = "FrmCadastro";
            gbCadastro.ResumeLayout(false);
            gbCadastro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInserir;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private GroupBox gbCadastro;
        private TextBox txtCpf;
        private Label label3;
        private Label label7;
        private TextBox textBox1;
        private Label label5;
        private TextBox txtEmail;
        private Button button1;
        private Button btnEditar;
        private Label label8;
        private TextBox textBox2;
    }
}