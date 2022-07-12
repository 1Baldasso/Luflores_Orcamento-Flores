using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDotNet.Dados;

namespace AppDotNet.Forms
{
    public partial class FrmDetalhesFlor : Form
    {
        private readonly int _id;
        private readonly Flor f;
        FloresContext db = new FloresContext();
        public FrmDetalhesFlor(int id)
        {
            _id = id;
            f = db.Flores.Find(_id);
            InitializeComponent();
        }

        private void FrmDetalhesFlor_Load(object sender, EventArgs e)
        {
            LblNomeFlor.Text = f.Nome;
            LblUnidade.Text = f.Unidade.GetDescription();
            //CreateControls(f);
            
        }
        private void CreateControls(Flor f)
        {
            Label lbl = new Label();
            Label lbl2 = new Label();
            
            foreach(var fo in f.Fornecedor)
            {
                lbl.Text = fo.Nome;
            }
        }

        private void btnAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            new FrmAdicionarFornecedorFlor(f).ShowDialog();
        }

        private void BtnEditarValores_Click(object sender, EventArgs e)
        {
            new FrmAdicionarValor(f).ShowDialog();
        }
    }
}
