using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDotNet
{
    public partial class frmFlores : Form
    {
        FloresContext db = new FloresContext();
        public frmFlores()
        {
            InitializeComponent();
        }

        private void btnCreateFlower_Click(object sender, EventArgs e)
        {
            new frmCriarFlor().ShowDialog();
        }

        int i = 1;
        private void frmFlores_Activated(object sender, EventArgs e)
        {
            pnlFlowers.Controls.Clear();
            Console.WriteLine("Test");
            List<Flores> flores = new List<Flores>();
            flores = db.Flores.ToList();
            foreach (var f in flores)
            {
                Utils.CreateControls(ref pnlFlowers, f);
            }
        }
    }
}
