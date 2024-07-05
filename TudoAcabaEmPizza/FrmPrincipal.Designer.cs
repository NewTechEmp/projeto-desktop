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
            produtoToolStripMenuItem = new ToolStripMenuItem();
            tipoDeBordaToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            cadastreSeToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            caixaToolStripMenuItem = new ToolStripMenuItem();
            cadastroEConsultasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkViolet;
            menuStrip1.Items.AddRange(new ToolStripItem[] { pedidoToolStripMenuItem, produtoToolStripMenuItem, usuarioToolStripMenuItem, cadastreSeToolStripMenuItem, caixaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1029, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pedidoToolStripMenuItem
            // 
            pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            pedidoToolStripMenuItem.Size = new Size(56, 20);
            pedidoToolStripMenuItem.Text = "&Pedido";
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tipoDeBordaToolStripMenuItem, categoriaToolStripMenuItem, cadastroEConsultasToolStripMenuItem });
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(62, 20);
            produtoToolStripMenuItem.Text = "&Produto";
            // 
            // tipoDeBordaToolStripMenuItem
            // 
            tipoDeBordaToolStripMenuItem.Name = "tipoDeBordaToolStripMenuItem";
            tipoDeBordaToolStripMenuItem.Size = new Size(185, 22);
            tipoDeBordaToolStripMenuItem.Text = "&Tipo de Borda";
            tipoDeBordaToolStripMenuItem.Click += tipoDeBordaToolStripMenuItem_Click;
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(185, 22);
            categoriaToolStripMenuItem.Text = "&Categoria";
            categoriaToolStripMenuItem.Click += categoriaToolStripMenuItem_Click;
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(59, 20);
            usuarioToolStripMenuItem.Text = "&Usuario";
            // 
            // cadastreSeToolStripMenuItem
            // 
            cadastreSeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem });
            cadastreSeToolStripMenuItem.Name = "cadastreSeToolStripMenuItem";
            cadastreSeToolStripMenuItem.Size = new Size(82, 20);
            cadastreSeToolStripMenuItem.Text = "&Cadastre-Se";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(104, 22);
            loginToolStripMenuItem.Text = "&Login";
            // 
            // caixaToolStripMenuItem
            // 
            caixaToolStripMenuItem.ForeColor = Color.Black;
            caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            caixaToolStripMenuItem.Size = new Size(48, 20);
            caixaToolStripMenuItem.Text = "&Caixa";
            caixaToolStripMenuItem.Click += caixaToolStripMenuItem_Click;
            // 
            // cadastroEConsultasToolStripMenuItem
            // 
            cadastroEConsultasToolStripMenuItem.Name = "cadastroEConsultasToolStripMenuItem";
            cadastroEConsultasToolStripMenuItem.Size = new Size(185, 22);
            cadastroEConsultasToolStripMenuItem.Text = "&Cadastro e Consultas";
            cadastroEConsultasToolStripMenuItem.Click += cadastroEConsultasToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1029, 450);
            Controls.Add(menuStrip1);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Desktop;
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmPrincipal";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
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
    }
}
