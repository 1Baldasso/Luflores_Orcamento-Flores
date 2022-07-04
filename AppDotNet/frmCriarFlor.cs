using System.Windows.Forms;
using System;
using System.Linq;

namespace AppDotNet
{
    public partial class frmCriarFlor : Form
    {
        string mychar = "00000";
        string mtxt;
        int mypos = 5;
        public frmCriarFlor()
        {
            InitializeComponent();
        }

        private void mtbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled=true;
                if (mypos <= 5 && mypos > 0)
                {
                    mtxt = mtxt + e.KeyChar;
                    mypos--;
                    mychar = mychar.Remove(mypos, mtxt.Length);
                    mychar = mychar.Insert(mypos, mtxt);
                    mtbValor.Text = mychar;
                }
            }
        }


        private void frmCreateFlower_Load(object sender, System.EventArgs e)
        {
            mtbValor.Text = mychar;
            var values = Enum.GetValues(typeof(EUnidade));
            foreach (var v in values)
            {
                cbxUnidade.Items.Add(Extensions.GetDescription<EUnidade>((EUnidade)v));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mtxt = "";
            mychar = "00000";
            mypos = 5;
            mtbValor.Text = mychar;
            mtbValor.Focus();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string nome;
            EUnidade unidade;
            if (txbNomeFlor.Text.ToString() == "")
                MessageBox.Show("Nome da flor não pode ser vazio");
            else
                nome = txbNomeFlor.Text;
            if (cbxUnidade.SelectedValue.ToString() == "")
                MessageBox.Show("Por favor selecione uma unidade");
            else
                unidade = (EUnidade)Enum.Parse(typeof(EUnidade), cbxUnidade.SelectedItem.ToString());
        }
    }
}
