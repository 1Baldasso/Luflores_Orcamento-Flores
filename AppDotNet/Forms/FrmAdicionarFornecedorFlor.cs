using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDotNet.Forms
{
    public partial class FrmAdicionarFornecedorFlor : Form
    {
        Flor f;
        public FrmAdicionarFornecedorFlor(Flor f)
        {
            this.f = f;
            InitializeComponent();
        }

        private void FrmAdicionarFornecedorFlor_Load(object sender, EventArgs e)
        {
            LblNomeFlor.Text = f.Nome;
            LblUnidade.Text = f.Unidade.GetDescription();
        }
    }
}
