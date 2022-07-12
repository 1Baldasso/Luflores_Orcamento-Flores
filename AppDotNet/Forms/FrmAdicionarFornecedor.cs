using AppDotNet.Dados;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppDotNet.Forms
{
    public partial class FrmAdicionarFornecedor : Form
    {
        private int LR = 0;
        List<string> telefones=new List<string>();
        public FrmAdicionarFornecedor()
        {
            InitializeComponent();
        }

        private void BtnAdicionarTel_Click(object sender, EventArgs e)
        {
            LR++;
            string telefone = MtbTelefone.Text.ToString();
            Label lbl = new Label();
            lbl.Text = telefone;
            lbl.Location = new System.Drawing.Point(5,25*LR-20);
            telefones.Add(telefone);
            PnlTelefones.Controls.Add(lbl);
            MtbTelefone.Text = "";
            MtbTelefone.Focus();
        }


        private void MtbTelefone_MouseClick(object sender, MouseEventArgs e)
        {
            MtbTelefone.SelectionStart = 1;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (TxbNomeFlor.Text.Equals(""))
            {
                MessageBox.Show("Nome do Fornecedor não pode ser vazio.");
                return;
            }
            Utils.AddFornecedor(new Fornecedor(TxbNomeFlor.Text.ToString(),telefones));
        }
    }
}
