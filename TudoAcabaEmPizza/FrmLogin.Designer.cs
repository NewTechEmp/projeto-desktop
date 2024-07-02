namespace TudoAcabaEmPizza
{
    partial class FrmLogin
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
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            gbLogin = new GroupBox();
            button1 = new Button();
            btnCancelar = new Button();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(68, 26);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(68, 44);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(254, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(68, 95);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(254, 23);
            txtSenha.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(68, 77);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // gbLogin
            // 
            gbLogin.Controls.Add(btnCancelar);
            gbLogin.Controls.Add(button1);
            gbLogin.Controls.Add(txtSenha);
            gbLogin.Controls.Add(label1);
            gbLogin.Controls.Add(label2);
            gbLogin.Controls.Add(txtEmail);
            gbLogin.ForeColor = Color.ForestGreen;
            gbLogin.Location = new Point(83, 48);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(377, 180);
            gbLogin.TabIndex = 4;
            gbLogin.TabStop = false;
            gbLogin.Text = "Login";
            // 
            // button1
            // 
            button1.ForeColor = Color.ForestGreen;
            button1.Location = new Point(247, 137);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.ForestGreen;
            btnCancelar.Location = new Point(68, 137);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 277);
            Controls.Add(gbLogin);
            Name = "FrmLogin";
            Text = "FrmLogin";
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label label2;
        private GroupBox gbLogin;
        private Button button1;
        private Button btnCancelar;
    }
}