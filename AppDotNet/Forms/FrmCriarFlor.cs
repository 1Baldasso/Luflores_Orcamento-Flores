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
    public partial class FrmCriarFlor : Form
    {
        public FrmCriarFlor()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (TxbNomeFlor.Text.ToString() == "")
            {
                MessageBox.Show("Nome não pode ser vazio.");
                return;
            }
            if (cbxUnidade.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma unidade.");
                return;
            }
            Utils.AdicionarDbFlores(
                new Flor(TxbNomeFlor.Text.ToString(),
                (Unidade)Enum.Parse(typeof(Unidade),
                cbxUnidade.SelectedItem.ToString()
                .GetEnumByDescription<Unidade>())));
            this.Close();
        }

        private void FrmCriarFlor_Load(object sender, EventArgs e)
        {
            Unidade[] unidade = (Unidade[])Enum.GetValues(typeof(Unidade));
            var ordered = unidade.OrderByDescending(x => x.ToString());
            foreach (var u in ordered)
            {
                cbxUnidade.Items.Add(u.GetDescription());
            }
        }

        
    }
}
