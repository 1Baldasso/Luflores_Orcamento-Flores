using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AppDotNet.Forms;

namespace AppDotNet
{
    public class Utils
    {
        private static bool changed = true;
        private static int lastRow=0;

        public static void setChanged(bool b)
        {
            changed = b;
        }
        public static void CreateControls(ref Panel pnl,Flor flor)
        {
            Label lbl = new Label();
            Label lbl2 = new Label();
            Button btn = new Button();
            RadioButton rdo = new RadioButton();
            Control[] controls = new Control[] {lbl, lbl2,btn,rdo};
            rdo.Location = new System.Drawing.Point(5,25*lastRow-20);
            rdo.AutoSize = true;
            lbl.Location = new System.Drawing.Point(30,25*lastRow-20);
            lbl.AutoSize = true;
            lbl.Text = flor.Nome;
            lbl2.Location = new System.Drawing.Point(pnl.Width-250,25*lastRow-20);
            lbl2.AutoSize = true;
            lbl2.Text = flor.Unidade.GetDescription();
            btn.Location = new System.Drawing.Point(pnl.Width-100,25*lastRow-23);
            btn.Text = "Detalhes";
            btn.Name = flor.Id.ToString();
            btn.Click += Btn_Click;
            pnl.Controls.AddRange(controls);
        }

        private static void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            new FrmDetalhesFlor(int.Parse(btn.Name)).ShowDialog();
        }

        public static void AdicionarDbFlores(Flor flor)
        {
            FloresContext db = new FloresContext();
            db.Flores.Add(flor);
            db.SaveChanges();
            changed = true;
        }
        public static void CheckChangedDB(ref Panel p)
        {
            FloresContext db = new FloresContext();
            if (changed)
            {
                lastRow = 0;
                List<Flor> flores;
                flores = db.Flores.ToList();
                p.Controls.Clear();
                foreach (var f in flores)
                {
                    lastRow++;
                    Utils.CreateControls(ref p, f);
                }
                changed = false;
            }
        }
    }
    public enum Unidade
    {

        [Description("Unidade")] Unidade = 1,
        [Description("Maço Pequeno (5)")] MaçoP = 5,
        [Description("Rolo (20)")] Rolo = 20,
        [Description("Rolo Importado (25)")] RoloImportado = 25,
        [Description("Pacote Pequeno (10)")] PacoteP = 10,
        [Description("Pacote Médio (15)")] PacoteM = 15,
        [Description("Pacote Grande (30)")] PacoteG = 30,
        [Description("Dúzia (12)")] Dúzia = 12,
        [Description("Caixa Pequena (250)")] CaixaP = 250,
        [Description("Caixa Grande (360)")] CaixaG = 360,
    }
    public static class Extensions
    {
        //Imported from https://stackoverflow.com/questions/479410/enum-tostring-with-user-friendly-strings
        public static string GetDescription<T>(this T enumerationValue)
        where T : struct
        {
            Type type = enumerationValue.GetType();
            if (!type.IsEnum)
            {
                throw new ArgumentException("EnumerationValue must be of Enum type", "enumerationValue");
            }

            //Tries to find a DescriptionAttribute for a potential friendly name
            //for the enum
            MemberInfo[] memberInfo = type.GetMember(enumerationValue.ToString());
            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    //Pull out the description value
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            //If we have no description attribute, just return the ToString of the enum
            return enumerationValue.ToString();
        }

        // Studyied above function and designed this one over the studies

        public static string GetEnumByDescription<T>(this string DescriptionValue)
        where T : struct
        {
            MemberInfo[] mi = typeof(T).GetMembers();
            if (mi != null && mi.Length > 0)
            {
                foreach (var member in mi)
                {
                    object[] attrs = member.GetCustomAttributes(typeof(DescriptionAttribute), false);
                    if (attrs != null && attrs.Length > 0)
                    {
                        if (DescriptionValue == ((DescriptionAttribute)attrs[0]).Description)
                        {
                            return member.Name;
                        }
                    }
                }
            }
            throw new ArgumentException();
        }
    }
}


