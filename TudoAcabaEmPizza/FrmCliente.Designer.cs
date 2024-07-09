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
            grbCliente = new GroupBox();
            dgvEnderecos = new DataGridView();
            clnCep = new DataGridViewTextBoxColumn();
            clnLogradouro = new DataGridViewTextBoxColumn();
            clnNumeroCasa = new DataGridViewTextBoxColumn();
            clnComplemento = new DataGridViewTextBoxColumn();
            clnBairro = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clnUf = new DataGridViewTextBoxColumn();
            clnTipoEnd = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tbpDadosCliente = new TabPage();
            dtpDatanasc = new DateTimePicker();
            mskCpf = new MaskedTextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ID = new Label();
            btnInserir = new Button();
            btnConsultarCliente = new Button();
            btnEditarCliente = new Button();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            tbpEnderecosCliente = new TabPage();
            label16 = new Label();
            btnConsultarEndereco = new Button();
            btnEditarEndereco = new Button();
            btnSalvarEndereco = new Button();
            mskUf = new MaskedTextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            cmbTipoEndereco = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label2 = new Label();
            txtNumero = new TextBox();
            txtComplemento = new TextBox();
            txtLogradouro = new TextBox();
            txtClienteId = new TextBox();
            txtCep = new TextBox();
            tbpTelefonesCliente = new TabPage();
            btnObterTelefone = new Button();
            btnEditarTelefone = new Button();
            btnInserirTelefone = new Button();
            label22 = new Label();
            textId = new TextBox();
            label21 = new Label();
            cmbTipoTelefone = new ComboBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            mskNumeroTelefone = new MaskedTextBox();
            mskDdd = new MaskedTextBox();
            mskDdi = new MaskedTextBox();
            label17 = new Label();
            grbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).BeginInit();
            tabControl1.SuspendLayout();
            tbpDadosCliente.SuspendLayout();
            tbpEnderecosCliente.SuspendLayout();
            tbpTelefonesCliente.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(287, 23);
            label1.Name = "label1";
            label1.Size = new Size(197, 31);
            label1.TabIndex = 0;
            label1.Text = "Dados Cliente";
            // 
            // grbCliente
            // 
            grbCliente.Controls.Add(dgvEnderecos);
            grbCliente.Controls.Add(tabControl1);
            grbCliente.Location = new Point(20, 57);
            grbCliente.Name = "grbCliente";
            grbCliente.Size = new Size(768, 575);
            grbCliente.TabIndex = 1;
            grbCliente.TabStop = false;
            grbCliente.Text = "Dados de Inserção";
            // 
            // dgvEnderecos
            // 
            dgvEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnderecos.Columns.AddRange(new DataGridViewColumn[] { clnCep, clnLogradouro, clnNumeroCasa, clnComplemento, clnBairro, clnCidade, clnUf, clnTipoEnd });
            dgvEnderecos.Location = new Point(10, 382);
            dgvEnderecos.Name = "dgvEnderecos";
            dgvEnderecos.RowHeadersVisible = false;
            dgvEnderecos.Size = new Size(752, 179);
            dgvEnderecos.TabIndex = 35;
            // 
            // clnCep
            // 
            clnCep.Frozen = true;
            clnCep.HeaderText = "CEP";
            clnCep.Name = "clnCep";
            clnCep.ReadOnly = true;
            clnCep.Width = 70;
            // 
            // clnLogradouro
            // 
            clnLogradouro.Frozen = true;
            clnLogradouro.HeaderText = "Logradouro";
            clnLogradouro.Name = "clnLogradouro";
            clnLogradouro.ReadOnly = true;
            clnLogradouro.Width = 160;
            // 
            // clnNumeroCasa
            // 
            clnNumeroCasa.Frozen = true;
            clnNumeroCasa.HeaderText = "N°";
            clnNumeroCasa.Name = "clnNumeroCasa";
            clnNumeroCasa.ReadOnly = true;
            clnNumeroCasa.Width = 35;
            // 
            // clnComplemento
            // 
            clnComplemento.Frozen = true;
            clnComplemento.HeaderText = "Complemento";
            clnComplemento.Name = "clnComplemento";
            clnComplemento.ReadOnly = true;
            // 
            // clnBairro
            // 
            clnBairro.Frozen = true;
            clnBairro.HeaderText = "Bairro";
            clnBairro.Name = "clnBairro";
            clnBairro.ReadOnly = true;
            clnBairro.Width = 111;
            // 
            // clnCidade
            // 
            clnCidade.Frozen = true;
            clnCidade.HeaderText = "Cidade";
            clnCidade.Name = "clnCidade";
            clnCidade.ReadOnly = true;
            clnCidade.Width = 90;
            // 
            // clnUf
            // 
            clnUf.Frozen = true;
            clnUf.HeaderText = "UF";
            clnUf.Name = "clnUf";
            clnUf.ReadOnly = true;
            clnUf.Width = 35;
            // 
            // clnTipoEnd
            // 
            clnTipoEnd.Frozen = true;
            clnTipoEnd.HeaderText = "Tipo End";
            clnTipoEnd.Name = "clnTipoEnd";
            clnTipoEnd.ReadOnly = true;
            clnTipoEnd.Width = 150;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpDadosCliente);
            tabControl1.Controls.Add(tbpEnderecosCliente);
            tabControl1.Controls.Add(tbpTelefonesCliente);
            tabControl1.Location = new Point(6, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(756, 354);
            tabControl1.TabIndex = 0;
            // 
            // tbpDadosCliente
            // 
            tbpDadosCliente.Controls.Add(dtpDatanasc);
            tbpDadosCliente.Controls.Add(mskCpf);
            tbpDadosCliente.Controls.Add(label7);
            tbpDadosCliente.Controls.Add(label6);
            tbpDadosCliente.Controls.Add(label5);
            tbpDadosCliente.Controls.Add(label4);
            tbpDadosCliente.Controls.Add(label3);
            tbpDadosCliente.Controls.Add(ID);
            tbpDadosCliente.Controls.Add(btnInserir);
            tbpDadosCliente.Controls.Add(btnConsultarCliente);
            tbpDadosCliente.Controls.Add(btnEditarCliente);
            tbpDadosCliente.Controls.Add(txtSenha);
            tbpDadosCliente.Controls.Add(txtEmail);
            tbpDadosCliente.Controls.Add(txtNome);
            tbpDadosCliente.Controls.Add(txtId);
            tbpDadosCliente.Location = new Point(4, 24);
            tbpDadosCliente.Name = "tbpDadosCliente";
            tbpDadosCliente.Padding = new Padding(3);
            tbpDadosCliente.Size = new Size(748, 326);
            tbpDadosCliente.TabIndex = 0;
            tbpDadosCliente.Text = "Dados Cliente";
            tbpDadosCliente.UseVisualStyleBackColor = true;
            // 
            // dtpDatanasc
            // 
            dtpDatanasc.Format = DateTimePickerFormat.Short;
            dtpDatanasc.Location = new Point(173, 100);
            dtpDatanasc.Name = "dtpDatanasc";
            dtpDatanasc.Size = new Size(105, 23);
            dtpDatanasc.TabIndex = 24;
            // 
            // mskCpf
            // 
            mskCpf.Location = new Point(173, 135);
            mskCpf.Mask = "000.000.000-00";
            mskCpf.Name = "mskCpf";
            mskCpf.Size = new Size(390, 23);
            mskCpf.TabIndex = 23;
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
            btnInserir.Location = new Point(329, 275);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 13;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnConsultarCliente
            // 
            btnConsultarCliente.Location = new Point(472, 275);
            btnConsultarCliente.Name = "btnConsultarCliente";
            btnConsultarCliente.Size = new Size(75, 23);
            btnConsultarCliente.TabIndex = 14;
            btnConsultarCliente.Text = "&Consultar";
            btnConsultarCliente.UseVisualStyleBackColor = true;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.Location = new Point(173, 275);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(75, 23);
            btnEditarCliente.TabIndex = 15;
            btnEditarCliente.Text = "&Editar";
            btnEditarCliente.UseVisualStyleBackColor = true;
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
            // txtNome
            // 
            txtNome.Location = new Point(173, 56);
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
            // tbpEnderecosCliente
            // 
            tbpEnderecosCliente.Controls.Add(label16);
            tbpEnderecosCliente.Controls.Add(btnConsultarEndereco);
            tbpEnderecosCliente.Controls.Add(btnEditarEndereco);
            tbpEnderecosCliente.Controls.Add(btnSalvarEndereco);
            tbpEnderecosCliente.Controls.Add(mskUf);
            tbpEnderecosCliente.Controls.Add(label15);
            tbpEnderecosCliente.Controls.Add(label14);
            tbpEnderecosCliente.Controls.Add(label13);
            tbpEnderecosCliente.Controls.Add(txtCidade);
            tbpEnderecosCliente.Controls.Add(txtBairro);
            tbpEnderecosCliente.Controls.Add(cmbTipoEndereco);
            tbpEnderecosCliente.Controls.Add(label12);
            tbpEnderecosCliente.Controls.Add(label11);
            tbpEnderecosCliente.Controls.Add(label10);
            tbpEnderecosCliente.Controls.Add(label9);
            tbpEnderecosCliente.Controls.Add(label8);
            tbpEnderecosCliente.Controls.Add(label2);
            tbpEnderecosCliente.Controls.Add(txtNumero);
            tbpEnderecosCliente.Controls.Add(txtComplemento);
            tbpEnderecosCliente.Controls.Add(txtLogradouro);
            tbpEnderecosCliente.Controls.Add(txtClienteId);
            tbpEnderecosCliente.Controls.Add(txtCep);
            tbpEnderecosCliente.Location = new Point(4, 24);
            tbpEnderecosCliente.Name = "tbpEnderecosCliente";
            tbpEnderecosCliente.Padding = new Padding(3);
            tbpEnderecosCliente.Size = new Size(748, 326);
            tbpEnderecosCliente.TabIndex = 1;
            tbpEnderecosCliente.Text = "Endereços Cliente";
            tbpEnderecosCliente.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.HotTrack;
            label16.Location = new Point(75, 40);
            label16.Name = "label16";
            label16.Size = new Size(628, 40);
            label16.TabIndex = 33;
            label16.Text = "cadastro de endereços do cliente";
            // 
            // btnConsultarEndereco
            // 
            btnConsultarEndereco.Location = new Point(528, 277);
            btnConsultarEndereco.Name = "btnConsultarEndereco";
            btnConsultarEndereco.Size = new Size(75, 32);
            btnConsultarEndereco.TabIndex = 30;
            btnConsultarEndereco.Text = "&Consultar";
            btnConsultarEndereco.UseVisualStyleBackColor = true;
            // 
            // btnEditarEndereco
            // 
            btnEditarEndereco.Location = new Point(416, 277);
            btnEditarEndereco.Name = "btnEditarEndereco";
            btnEditarEndereco.Size = new Size(75, 32);
            btnEditarEndereco.TabIndex = 31;
            btnEditarEndereco.Text = "&Editar";
            btnEditarEndereco.UseVisualStyleBackColor = true;
            // 
            // btnSalvarEndereco
            // 
            btnSalvarEndereco.Location = new Point(313, 277);
            btnSalvarEndereco.Name = "btnSalvarEndereco";
            btnSalvarEndereco.Size = new Size(75, 32);
            btnSalvarEndereco.TabIndex = 32;
            btnSalvarEndereco.Text = "&Salvar";
            btnSalvarEndereco.UseVisualStyleBackColor = true;
            btnSalvarEndereco.Click += buSalvar_Click;
            // 
            // mskUf
            // 
            mskUf.Location = new Point(684, 223);
            mskUf.Mask = "aa";
            mskUf.Name = "mskUf";
            mskUf.Size = new Size(33, 23);
            mskUf.TabIndex = 29;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.HotTrack;
            label15.Location = new Point(657, 226);
            label15.Name = "label15";
            label15.Size = new Size(21, 15);
            label15.TabIndex = 28;
            label15.Text = "UF";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.HotTrack;
            label14.Location = new Point(5, 283);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 27;
            label14.Text = "Cidade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.HotTrack;
            label13.Location = new Point(307, 232);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 26;
            label13.Text = "Bairro";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(55, 283);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(202, 23);
            txtCidade.TabIndex = 24;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(351, 226);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(278, 23);
            txtBairro.TabIndex = 23;
            // 
            // cmbTipoEndereco
            // 
            cmbTipoEndereco.FormattingEnabled = true;
            cmbTipoEndereco.Location = new Point(442, 168);
            cmbTipoEndereco.Name = "cmbTipoEndereco";
            cmbTipoEndereco.Size = new Size(225, 23);
            cmbTipoEndereco.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(22, 119);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 12;
            label12.Text = "ID Cliente";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.HotTrack;
            label11.Location = new Point(4, 226);
            label11.Name = "label11";
            label11.Size = new Size(84, 15);
            label11.TabIndex = 11;
            label11.Text = "Complemento";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(507, 119);
            label10.Name = "label10";
            label10.Size = new Size(21, 15);
            label10.TabIndex = 10;
            label10.Text = "N°";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(351, 171);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 9;
            label9.Text = "Tipo Endereço";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(11, 171);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 8;
            label8.Text = "Logradouro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(206, 119);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 7;
            label2.Text = "CEP";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(547, 116);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(120, 23);
            txtNumero.TabIndex = 6;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(94, 226);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(207, 23);
            txtComplemento.TabIndex = 5;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(86, 168);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(214, 23);
            txtLogradouro.TabIndex = 3;
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(86, 116);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(105, 23);
            txtClienteId.TabIndex = 2;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(240, 116);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(214, 23);
            txtCep.TabIndex = 1;
            // 
            // tbpTelefonesCliente
            // 
            tbpTelefonesCliente.Controls.Add(btnObterTelefone);
            tbpTelefonesCliente.Controls.Add(btnEditarTelefone);
            tbpTelefonesCliente.Controls.Add(btnInserirTelefone);
            tbpTelefonesCliente.Controls.Add(label22);
            tbpTelefonesCliente.Controls.Add(textId);
            tbpTelefonesCliente.Controls.Add(label21);
            tbpTelefonesCliente.Controls.Add(cmbTipoTelefone);
            tbpTelefonesCliente.Controls.Add(label20);
            tbpTelefonesCliente.Controls.Add(label19);
            tbpTelefonesCliente.Controls.Add(label18);
            tbpTelefonesCliente.Controls.Add(mskNumeroTelefone);
            tbpTelefonesCliente.Controls.Add(mskDdd);
            tbpTelefonesCliente.Controls.Add(mskDdi);
            tbpTelefonesCliente.Controls.Add(label17);
            tbpTelefonesCliente.Location = new Point(4, 24);
            tbpTelefonesCliente.Name = "tbpTelefonesCliente";
            tbpTelefonesCliente.Padding = new Padding(3);
            tbpTelefonesCliente.Size = new Size(748, 326);
            tbpTelefonesCliente.TabIndex = 2;
            tbpTelefonesCliente.Text = "Telefones Cliente";
            tbpTelefonesCliente.UseVisualStyleBackColor = true;
            // 
            // btnObterTelefone
            // 
            btnObterTelefone.Location = new Point(437, 262);
            btnObterTelefone.Name = "btnObterTelefone";
            btnObterTelefone.Size = new Size(75, 32);
            btnObterTelefone.TabIndex = 31;
            btnObterTelefone.Text = "&Consultar";
            btnObterTelefone.UseVisualStyleBackColor = true;
            // 
            // btnEditarTelefone
            // 
            btnEditarTelefone.Location = new Point(325, 262);
            btnEditarTelefone.Name = "btnEditarTelefone";
            btnEditarTelefone.Size = new Size(75, 32);
            btnEditarTelefone.TabIndex = 32;
            btnEditarTelefone.Text = "&Editar";
            btnEditarTelefone.UseVisualStyleBackColor = true;
            // 
            // btnInserirTelefone
            // 
            btnInserirTelefone.Location = new Point(222, 262);
            btnInserirTelefone.Name = "btnInserirTelefone";
            btnInserirTelefone.Size = new Size(75, 32);
            btnInserirTelefone.TabIndex = 33;
            btnInserirTelefone.Text = "&Inserir";
            btnInserirTelefone.UseVisualStyleBackColor = true;
            btnInserirTelefone.Click += btnInserirTelefone_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = SystemColors.HotTrack;
            label22.Location = new Point(191, 97);
            label22.Name = "label22";
            label22.Size = new Size(58, 15);
            label22.TabIndex = 30;
            label22.Text = "ID Cliente";
            // 
            // textId
            // 
            textId.Location = new Point(257, 97);
            textId.Name = "textId";
            textId.Size = new Size(211, 23);
            textId.TabIndex = 29;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = SystemColors.HotTrack;
            label21.Location = new Point(161, 216);
            label21.Name = "label21";
            label21.Size = new Size(93, 15);
            label21.TabIndex = 28;
            label21.Text = "Tipo de Telefone";
            // 
            // cmbTipoTelefone
            // 
            cmbTipoTelefone.FormattingEnabled = true;
            cmbTipoTelefone.Location = new Point(257, 213);
            cmbTipoTelefone.Name = "cmbTipoTelefone";
            cmbTipoTelefone.Size = new Size(211, 23);
            cmbTipoTelefone.TabIndex = 27;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = SystemColors.HotTrack;
            label20.Location = new Point(197, 187);
            label20.Name = "label20";
            label20.Size = new Size(57, 15);
            label20.TabIndex = 26;
            label20.Text = "NÙMERO";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = SystemColors.HotTrack;
            label19.Location = new Point(223, 163);
            label19.Name = "label19";
            label19.Size = new Size(31, 15);
            label19.TabIndex = 25;
            label19.Text = "DDD";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = SystemColors.HotTrack;
            label18.Location = new Point(223, 129);
            label18.Name = "label18";
            label18.Size = new Size(26, 15);
            label18.TabIndex = 24;
            label18.Text = "DDI";
            // 
            // mskNumeroTelefone
            // 
            mskNumeroTelefone.Location = new Point(257, 184);
            mskNumeroTelefone.Mask = "000000000";
            mskNumeroTelefone.Name = "mskNumeroTelefone";
            mskNumeroTelefone.Size = new Size(211, 23);
            mskNumeroTelefone.TabIndex = 23;
            // 
            // mskDdd
            // 
            mskDdd.Location = new Point(257, 155);
            mskDdd.Mask = "00";
            mskDdd.Name = "mskDdd";
            mskDdd.Size = new Size(211, 23);
            mskDdd.TabIndex = 22;
            // 
            // mskDdi
            // 
            mskDdi.Location = new Point(257, 126);
            mskDdi.Mask = "+00";
            mskDdi.Name = "mskDdi";
            mskDdi.Size = new Size(211, 23);
            mskDdi.TabIndex = 21;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.HotTrack;
            label17.Location = new Point(82, 28);
            label17.Name = "label17";
            label17.Size = new Size(618, 40);
            label17.TabIndex = 13;
            label17.Text = "Cadastro de Telefones do Cliente";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 677);
            Controls.Add(grbCliente);
            Controls.Add(label1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            grbCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).EndInit();
            tabControl1.ResumeLayout(false);
            tbpDadosCliente.ResumeLayout(false);
            tbpDadosCliente.PerformLayout();
            tbpEnderecosCliente.ResumeLayout(false);
            tbpEnderecosCliente.PerformLayout();
            tbpTelefonesCliente.ResumeLayout(false);
            tbpTelefonesCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grbCliente;
        private TabControl tabControl1;
        private TabPage tbpDadosCliente;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label ID;
        private Button btnInserir;
        private Button btnConsultarCliente;
        private Button btnEditarCliente;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private TextBox txtNome;
        private TextBox txtId;
        private TabPage tbpEnderecosCliente;
        private TabPage tbpTelefonesCliente;
        private TextBox txtNumero;
        private TextBox txtComplemento;
        private TextBox txtLogradouro;
        private TextBox txtClienteId;
        private TextBox txtCep;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label2;
        private Label label12;
        private Label label14;
        private Label label13;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private ComboBox cmbTipoEndereco;
        private Label label15;
        private MaskedTextBox mskUf;
        private Button btnConsultarEndereco;
        private Button btnEditarEndereco;
        private Button btnSalvarEndereco;
        private Label label16;
        private Label label17;
        private MaskedTextBox mskNumeroTelefone;
        private MaskedTextBox mskDdd;
        private MaskedTextBox mskDdi;
        private Label label20;
        private Label label19;
        private Label label18;
        private ComboBox cmbTipoTelefone;
        private Label label21;
        private Label label22;
        private TextBox textId;
        private Button btnObterTelefone;
        private Button btnEditarTelefone;
        private Button btnInserirTelefone;
        private ComboBox cbmCategoria;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox mskCpf;
        private DateTimePicker dtpDatanasc;
        private DataGridView dgvEnderecos;
        private DataGridViewTextBoxColumn clnCep;
        private DataGridViewTextBoxColumn clnLogradouro;
        private DataGridViewTextBoxColumn clnNumeroCasa;
        private DataGridViewTextBoxColumn clnComplemento;
        private DataGridViewTextBoxColumn clnBairro;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnUf;
        private DataGridViewTextBoxColumn clnTipoEnd;
    }
}