namespace TudoAcabaEmPizza
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tiposDeBordaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoBorda frmTipoBorda = new();
            frmTipoBorda.MdiParent = this;
            frmTipoBorda.Show();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //FrmLogin login = new();            
            //login.StartPosition = FormStartPosition.CenterScreen;
            //login.ShowDialog();
            //tslUsuario.Text = $"{Program.Usuario.Nome}  -  {Program.Usuario.Nivel.Nome}";
        }

        private void tipoDeBordaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoBorda frmTipoBorda = new();
            frmTipoBorda.MdiParent = this;
            frmTipoBorda.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new();
            frmCategoria.MdiParent = this;
            frmCategoria.Show();

        }
    }
}
