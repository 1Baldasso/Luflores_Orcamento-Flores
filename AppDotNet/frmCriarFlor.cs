using System.Windows.Forms;
using System;
using System.Linq;

namespace AppDotNet
{
    public partial class FrmCriarFlor : Form
    {
        string mychar = "00000";
        string mtxt;
        int mypos = 5;
        public FrmCriarFlor()
        {
            InitializeComponent();
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


        private void FrmCreateFlower_Load(object sender, System.EventArgs e)
        {
            mtbValor.Text = mychar;
            var values = Enum.GetValues(typeof(EUnidade));
            foreach (var v in values)
            {
                cbxUnidade.Items.Add(Extensions.GetDescription<EUnidade>((EUnidade)v));
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
            string nome, fornecedor;
            EUnidade unidade;
            double valor;
            if (txbNomeFlor.Text.ToString() == "")
            {
                MessageBox.Show("Nome da flor não pode ser vazio.");
                return;
            }
            nome = txbNomeFlor.Text;
            if (cbxUnidade.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione uma Unidade.");
                return;
            }
            unidade = (EUnidade)Enum.Parse(typeof(EUnidade), cbxUnidade.SelectedItem.ToString().GetEnumByDescription<EUnidade>());
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
            Utils.AdicionarDbFlores(new Flores(nome, valor, unidade, fornecedor));
        }
    }
}
