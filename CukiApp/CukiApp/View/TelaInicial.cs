using CukiApp.View;

namespace CukiApp
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            Estoque novoForm = new Estoque();
            novoForm.Show();
        }
        private void buttonAddReceita_Click(object sender, EventArgs e)
        {
            Receita novoForm = new Receita();
            novoForm.Show();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            Item novoForm = new Item();
            novoForm.Show();
        }
    }
}
