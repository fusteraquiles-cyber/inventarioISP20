namespace Desktop.Views
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }
        #region codigo boton de saludo
        private void Botoncitochiquititito_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AGUANTE TALLERE");
        }
        #endregion

        private void SubmenuArticulos_Click(object sender, EventArgs e)
        {
            ArticulosView articulosView = new ArticulosView();
            articulosView.MdiParent = this;
            articulosView.Show();
        }

        private void SubmenuCategorias_Click(object sender, EventArgs e)
        {
            CategoriasView categoriasView = new CategoriasView();   
            categoriasView.Show();    
        }
    }
}
