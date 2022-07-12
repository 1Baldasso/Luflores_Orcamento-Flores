using System.Windows.Forms;
using System;
using System.Linq;

namespace AppDotNet
{
    public partial class FrmAdicionarValor : Form
    {
        string mychar = "00000";
        string mtxt;
        int mypos = 5;
        Flor f;
        public FrmAdicionarValor(Flor f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void MtbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled=true;
                if (mypos <= 5 && mypos > 0)
                {
                    mtxt += e.KeyChar;
                    mypos--;
                    mychar = mychar.Remove(mypos, mtxt.Length);
                    mychar = mychar.Insert(mypos, mtxt);
                    mtbValor.Text = mychar;
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            mtxt = "";
            mychar = "00000";
            mypos = 5;
            mtbValor.Text = mychar;
            mtbValor.Focus();
        }

        private void BtnCriar_Click(object sender, EventArgs e)
        {
            string fornecedor;
            double valor;
            if (cbxFornecedor.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione uma Fornecedor.");
                return;
            }
            fornecedor = cbxFornecedor.SelectedItem.ToString();
            if(mtbValor.Text.Substring(3) == "000,00")
            {
                MessageBox.Show("Valor da flor não pode ser vazio.");
                return;
            }
            valor = double.Parse(mtbValor.Text.Substring(3));
            Utils.AddValorFlor(valor, f, fornecedor);

            this.Close();
        }

        private void FrmAdicionarValor_Load(object sender, EventArgs e)
        {
            foreach (var f in Utils.GetFornecedores())
            {
                cbxFornecedor.Items.Add(f.Nome.ToString());
            }
        }
    }
}
