namespace TudoAcabaEmPizza
{
    partial class FrmTipoEndereco
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
            dgvTipoEndereco = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnSigla = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            btnObterPorId = new Button();
            btnEditar = new Button();
            btnInserir = new Button();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtSigla = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTipoEndereco).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTipoEndereco
            // 
            dgvTipoEndereco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoEndereco.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnSigla });
            dgvTipoEndereco.Location = new Point(216, 287);
            dgvTipoEndereco.Name = "dgvTipoEndereco";
            dgvTipoEndereco.RowHeadersVisible = false;
            dgvTipoEndereco.Size = new Size(369, 150);
            dgvTipoEndereco.TabIndex = 7;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 123;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 123;
            // 
            // clnSigla
            // 
            clnSigla.Frozen = true;
            clnSigla.HeaderText = "Sigla";
            clnSigla.Name = "clnSigla";
            clnSigla.ReadOnly = true;
            clnSigla.Width = 123;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnObterPorId);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtSigla);
            groupBox1.Location = new Point(216, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 215);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados para inserir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(6, 124);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "Sigla";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(18, 32);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 2;
            label4.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // btnObterPorId
            // 
            btnObterPorId.Location = new Point(233, 177);
            btnObterPorId.Name = "btnObterPorId";
            btnObterPorId.Size = new Size(75, 32);
            btnObterPorId.TabIndex = 1;
            btnObterPorId.Text = "&Consultar";
            btnObterPorId.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(121, 177);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 32);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(18, 177);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 32);
            btnInserir.TabIndex = 1;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(62, 32);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(81, 23);
            txtId.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(62, 69);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(214, 23);
            txtNome.TabIndex = 0;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(62, 121);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(117, 23);
            txtSigla.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(249, 9);
            label1.Name = "label1";
            label1.Size = new Size(314, 36);
            label1.TabIndex = 5;
            label1.Text = "TIPOS DE ENDEREÇO";
            // 
            // FrmTipoEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTipoEndereco);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmTipoEndereco";
            Text = "TipoEndereço";
            Load += FrmTipoEndereco_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTipoEndereco).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTipoEndereco;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnSigla;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Button btnObterPorId;
        private Button btnEditar;
        private Button btnInserir;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtSigla;
        private Label label1;
    }
}