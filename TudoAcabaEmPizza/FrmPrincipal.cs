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
    }
}
