using System;
using AppDotNet.Forms;
using System.Windows.Forms;

namespace AppDotNet
{
    public partial class FrmFlores : Form
    {
        FloresContext db = new FloresContext();
        public FrmFlores()
        {
            InitializeComponent();
        }

        private void BtnCreateFlower_Click(object sender, EventArgs e)
        {
            new FrmCriarFlor().ShowDialog();
        }

        private void FrmFlores_Activated(object sender, EventArgs e)
        {
            Utils.CheckChangedDB(ref pnlFlowers);
        }

        private void FrmFlores_Resize(object sender, EventArgs e)
        {
            Utils.setChanged(true);
            Utils.CheckChangedDB(ref pnlFlowers);
        }

        private void btnAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            new FrmAdicionarFornecedor().ShowDialog();
        }
    }
}
