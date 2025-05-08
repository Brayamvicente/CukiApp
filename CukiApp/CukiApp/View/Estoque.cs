using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CukiApp.View
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }


        private void entMerc_Click(object sender, EventArgs e)
        {
            EntradaMercadoria novoForm = new EntradaMercadoria();
            novoForm.Show();
        }

    }
}
