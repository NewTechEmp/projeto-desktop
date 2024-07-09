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
            tabControl1 = new TabControl();
            tbpDadosCliente = new TabPage();
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
            cmbTipoTelefone = new ComboBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            mskNumero = new MaskedTextBox();
            mskDdd = new MaskedTextBox();
            mskDdi = new MaskedTextBox();
            label17 = new Label();
            label21 = new Label();
            textId = new TextBox();
            label22 = new Label();
            btnObterTelefone = new Button();
            btnEditarTelefone = new Button();
            btnInserirTelefone = new Button();
            grbCliente.SuspendLayout();
            tabControl1.SuspendLayout();
            tbpDadosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            grbCliente.Controls.Add(tabControl1);
            grbCliente.Location = new Point(20, 57);
            grbCliente.Name = "grbCliente";
            grbCliente.Size = new Size(768, 575);
            grbCliente.TabIndex = 1;
            grbCliente.TabStop = false;
            grbCliente.Text = "Dados de Inserção";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpDadosCliente);
            tabControl1.Controls.Add(tbpEnderecosCliente);
            tabControl1.Controls.Add(tbpTelefonesCliente);
            tabControl1.Location = new Point(6, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(756, 498);
            tabControl1.TabIndex = 0;
            // 
            // tbpDadosCliente
            // 
            tbpDadosCliente.Controls.Add(label7);
            tbpDadosCliente.Controls.Add(label6);
            tbpDadosCliente.Controls.Add(label5);
            tbpDadosCliente.Controls.Add(label4);
            tbpDadosCliente.Controls.Add(label3);
            tbpDadosCliente.Controls.Add(ID);
            tbpDadosCliente.Controls.Add(btnInserir);
            tbpDadosCliente.Controls.Add(btnConsultar);
            tbpDadosCliente.Controls.Add(btnEditar);
            tbpDadosCliente.Controls.Add(txtSenha);
            tbpDadosCliente.Controls.Add(txtEmail);
            tbpDadosCliente.Controls.Add(txtCPF);
            tbpDadosCliente.Controls.Add(txtDataNasc);
            tbpDadosCliente.Controls.Add(txtNome);
            tbpDadosCliente.Controls.Add(txtId);
            tbpDadosCliente.Controls.Add(dataGridView1);
            tbpDadosCliente.Location = new Point(4, 24);
            tbpDadosCliente.Name = "tbpDadosCliente";
            tbpDadosCliente.Padding = new Padding(3);
            tbpDadosCliente.Size = new Size(748, 470);
            tbpDadosCliente.TabIndex = 0;
            tbpDadosCliente.Text = "Dados Cliente";
            tbpDadosCliente.UseVisualStyleBackColor = true;
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
            btnInserir.Click += btnInserir_Click;
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
            tbpEnderecosCliente.Size = new Size(748, 470);
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
            btnConsultarEndereco.Location = new Point(463, 393);
            btnConsultarEndereco.Name = "btnConsultarEndereco";
            btnConsultarEndereco.Size = new Size(75, 32);
            btnConsultarEndereco.TabIndex = 30;
            btnConsultarEndereco.Text = "&Consultar";
            btnConsultarEndereco.UseVisualStyleBackColor = true;
            // 
            // btnEditarEndereco
            // 
            btnEditarEndereco.Location = new Point(351, 393);
            btnEditarEndereco.Name = "btnEditarEndereco";
            btnEditarEndereco.Size = new Size(75, 32);
            btnEditarEndereco.TabIndex = 31;
            btnEditarEndereco.Text = "&Editar";
            btnEditarEndereco.UseVisualStyleBackColor = true;
            // 
            // btnSalvarEndereco
            // 
            btnSalvarEndereco.Location = new Point(248, 393);
            btnSalvarEndereco.Name = "btnSalvarEndereco";
            btnSalvarEndereco.Size = new Size(75, 32);
            btnSalvarEndereco.TabIndex = 32;
            btnSalvarEndereco.Text = "&Salvar";
            btnSalvarEndereco.UseVisualStyleBackColor = true;
            btnSalvarEndereco.Click += buSalvar_Click;
            // 
            // mskUf
            // 
            mskUf.Location = new Point(281, 347);
            mskUf.Mask = "aa";
            mskUf.Name = "mskUf";
            mskUf.Size = new Size(211, 23);
            mskUf.TabIndex = 29;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.HotTrack;
            label15.Location = new Point(254, 347);
            label15.Name = "label15";
            label15.Size = new Size(21, 15);
            label15.TabIndex = 28;
            label15.Text = "UF";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.HotTrack;
            label14.Location = new Point(231, 315);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 27;
            label14.Text = "Cidade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.HotTrack;
            label13.Location = new Point(237, 286);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 26;
            label13.Text = "Bairro";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(281, 315);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(214, 23);
            txtCidade.TabIndex = 24;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(281, 286);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(214, 23);
            txtBairro.TabIndex = 23;
            // 
            // cmbTipoEndereco
            // 
            cmbTipoEndereco.FormattingEnabled = true;
            cmbTipoEndereco.Location = new Point(281, 173);
            cmbTipoEndereco.Name = "cmbTipoEndereco";
            cmbTipoEndereco.Size = new Size(214, 23);
            cmbTipoEndereco.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(217, 145);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 12;
            label12.Text = "ID Cliente";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.HotTrack;
            label11.Location = new Point(191, 257);
            label11.Name = "label11";
            label11.Size = new Size(84, 15);
            label11.TabIndex = 11;
            label11.Text = "Complemento";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(224, 231);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 10;
            label10.Text = "Número";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(193, 173);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 9;
            label9.Text = "Tipo Endereço";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(206, 202);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 8;
            label8.Text = "Logradouro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(247, 116);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 7;
            label2.Text = "CEP";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(281, 228);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(214, 23);
            txtNumero.TabIndex = 6;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(281, 257);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(214, 23);
            txtComplemento.TabIndex = 5;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(281, 199);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(214, 23);
            txtLogradouro.TabIndex = 3;
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(281, 142);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(214, 23);
            txtClienteId.TabIndex = 2;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(281, 113);
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
            tbpTelefonesCliente.Controls.Add(mskNumero);
            tbpTelefonesCliente.Controls.Add(mskDdd);
            tbpTelefonesCliente.Controls.Add(mskDdi);
            tbpTelefonesCliente.Controls.Add(label17);
            tbpTelefonesCliente.Location = new Point(4, 24);
            tbpTelefonesCliente.Name = "tbpTelefonesCliente";
            tbpTelefonesCliente.Padding = new Padding(3);
            tbpTelefonesCliente.Size = new Size(748, 470);
            tbpTelefonesCliente.TabIndex = 2;
            tbpTelefonesCliente.Text = "Telefones Cliente";
            tbpTelefonesCliente.UseVisualStyleBackColor = true;
            // 
            // cmbTipoTelefone
            // 
            cmbTipoTelefone.FormattingEnabled = true;
            cmbTipoTelefone.Location = new Point(284, 249);
            cmbTipoTelefone.Name = "cmbTipoTelefone";
            cmbTipoTelefone.Size = new Size(211, 23);
            cmbTipoTelefone.TabIndex = 27;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = SystemColors.HotTrack;
            label20.Location = new Point(224, 223);
            label20.Name = "label20";
            label20.Size = new Size(57, 15);
            label20.TabIndex = 26;
            label20.Text = "NÙMERO";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = SystemColors.HotTrack;
            label19.Location = new Point(250, 199);
            label19.Name = "label19";
            label19.Size = new Size(31, 15);
            label19.TabIndex = 25;
            label19.Text = "DDD";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = SystemColors.HotTrack;
            label18.Location = new Point(250, 165);
            label18.Name = "label18";
            label18.Size = new Size(26, 15);
            label18.TabIndex = 24;
            label18.Text = "DDI";
            // 
            // mskNumero
            // 
            mskNumero.Location = new Point(284, 220);
            mskNumero.Mask = "000000000";
            mskNumero.Name = "mskNumero";
            mskNumero.Size = new Size(211, 23);
            mskNumero.TabIndex = 23;
            // 
            // mskDdd
            // 
            mskDdd.Location = new Point(284, 191);
            mskDdd.Mask = "00";
            mskDdd.Name = "mskDdd";
            mskDdd.Size = new Size(211, 23);
            mskDdd.TabIndex = 22;
            // 
            // mskDdi
            // 
            mskDdi.Location = new Point(284, 162);
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
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = SystemColors.HotTrack;
            label21.Location = new Point(188, 252);
            label21.Name = "label21";
            label21.Size = new Size(93, 15);
            label21.TabIndex = 28;
            label21.Text = "Tipo de Telefone";
            // 
            // textId
            // 
            textId.Location = new Point(284, 278);
            textId.Name = "textId";
            textId.Size = new Size(211, 23);
            textId.TabIndex = 29;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = SystemColors.HotTrack;
            label22.Location = new Point(218, 278);
            label22.Name = "label22";
            label22.Size = new Size(58, 15);
            label22.TabIndex = 30;
            label22.Text = "ID Cliente";
            // 
            // btnObterTelefone
            // 
            btnObterTelefone.Location = new Point(456, 324);
            btnObterTelefone.Name = "btnObterTelefone";
            btnObterTelefone.Size = new Size(75, 32);
            btnObterTelefone.TabIndex = 31;
            btnObterTelefone.Text = "&Consultar";
            btnObterTelefone.UseVisualStyleBackColor = true;
            // 
            // btnEditarTelefone
            // 
            btnEditarTelefone.Location = new Point(344, 324);
            btnEditarTelefone.Name = "btnEditarTelefone";
            btnEditarTelefone.Size = new Size(75, 32);
            btnEditarTelefone.TabIndex = 32;
            btnEditarTelefone.Text = "&Editar";
            btnEditarTelefone.UseVisualStyleBackColor = true;
            // 
            // btnInserirTelefone
            // 
            btnInserirTelefone.Location = new Point(241, 324);
            btnInserirTelefone.Name = "btnInserirTelefone";
            btnInserirTelefone.Size = new Size(75, 32);
            btnInserirTelefone.TabIndex = 33;
            btnInserirTelefone.Text = "&Inserir";
            btnInserirTelefone.UseVisualStyleBackColor = true;
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
            tabControl1.ResumeLayout(false);
            tbpDadosCliente.ResumeLayout(false);
            tbpDadosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private MaskedTextBox mskNumero;
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
    }
}