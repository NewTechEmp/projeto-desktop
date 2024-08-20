namespace TudoAcabaEmPizza
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            pedidoToolStripMenuItem = new ToolStripMenuItem();
            tipoDePagamentoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            tipoDeBordaToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            cadastroEConsultasToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            cadastreSeToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            tipoToolStripMenuItem = new ToolStripMenuItem();
            caixaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.ForestGreen;
            menuStrip1.Font = new Font("Segoe UI", 12F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { pedidoToolStripMenuItem, produtoToolStripMenuItem, usuarioToolStripMenuItem, cadastreSeToolStripMenuItem, caixaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1029, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pedidoToolStripMenuItem
            // 
            pedidoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tipoDePagamentoToolStripMenuItem, novoToolStripMenuItem });
            pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            pedidoToolStripMenuItem.Size = new Size(69, 25);
            pedidoToolStripMenuItem.Text = "&Pedido";
            // 
            // tipoDePagamentoToolStripMenuItem
            // 
            tipoDePagamentoToolStripMenuItem.Name = "tipoDePagamentoToolStripMenuItem";
            tipoDePagamentoToolStripMenuItem.Size = new Size(213, 26);
            tipoDePagamentoToolStripMenuItem.Text = "&Tipo de Pagamento";
            tipoDePagamentoToolStripMenuItem.Click += tipoDePagamentoToolStripMenuItem_Click;
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(213, 26);
            novoToolStripMenuItem.Text = "&Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tipoDeBordaToolStripMenuItem, categoriaToolStripMenuItem, cadastroEConsultasToolStripMenuItem });
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(78, 25);
            produtoToolStripMenuItem.Text = "&Produto";
            // 
            // tipoDeBordaToolStripMenuItem
            // 
            tipoDeBordaToolStripMenuItem.Name = "tipoDeBordaToolStripMenuItem";
            tipoDeBordaToolStripMenuItem.Size = new Size(226, 26);
            tipoDeBordaToolStripMenuItem.Text = "&Tipo de Borda";
            tipoDeBordaToolStripMenuItem.Click += tipoDeBordaToolStripMenuItem_Click;
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(226, 26);
            categoriaToolStripMenuItem.Text = "&Categoria";
            categoriaToolStripMenuItem.Click += categoriaToolStripMenuItem_Click;
            // 
            // cadastroEConsultasToolStripMenuItem
            // 
            cadastroEConsultasToolStripMenuItem.Name = "cadastroEConsultasToolStripMenuItem";
            cadastroEConsultasToolStripMenuItem.Size = new Size(226, 26);
            cadastroEConsultasToolStripMenuItem.Text = "&Cadastro e Consultas";
            cadastroEConsultasToolStripMenuItem.Click += cadastroEConsultasToolStripMenuItem_Click;
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(76, 25);
            usuarioToolStripMenuItem.Text = "&Usuario";
            // 
            // cadastreSeToolStripMenuItem
            // 
            cadastreSeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, clienteToolStripMenuItem, tipoToolStripMenuItem });
            cadastreSeToolStripMenuItem.Name = "cadastreSeToolStripMenuItem";
            cadastreSeToolStripMenuItem.Size = new Size(106, 25);
            cadastreSeToolStripMenuItem.Text = "&Cadastre-Se";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(199, 26);
            loginToolStripMenuItem.Text = "&Login";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(199, 26);
            clienteToolStripMenuItem.Text = "&Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // tipoToolStripMenuItem
            // 
            tipoToolStripMenuItem.Name = "tipoToolStripMenuItem";
            tipoToolStripMenuItem.Size = new Size(199, 26);
            tipoToolStripMenuItem.Text = "&Tipo de Endereço";
            tipoToolStripMenuItem.Click += tipoToolStripMenuItem_Click;
            // 
            // caixaToolStripMenuItem
            // 
            caixaToolStripMenuItem.ForeColor = Color.Black;
            caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            caixaToolStripMenuItem.Size = new Size(59, 25);
            caixaToolStripMenuItem.Text = "&Caixa";
            caixaToolStripMenuItem.Click += caixaToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1029, 450);
            Controls.Add(menuStrip1);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmPrincipal";
            Text = "Form1";
            WindowState = FormWindowState.Minimized;
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pedidoToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem cadastreSeToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem caixaToolStripMenuItem;
        private ToolStripMenuItem tipoDeBordaToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem cadastroEConsultasToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem tipoDePagamentoToolStripMenuItem;
        private ToolStripMenuItem tipoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
    }
}
