using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDotNet
{
    public class Flores
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int Id { get; set; }
        [Required] public string Nome { get; set; }
        [Required] public EUnidade Unidade { get; set; }
        [Required] public double Valor { get; set; }
        public string Fornecedor { get; set; }

        public Flores() { }
        public Flores(string nome, double valor, EUnidade unidade, string fornecedor)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.Unidade = unidade;
            this.Fornecedor = fornecedor;
        }
        private Flores(double v, EUnidade e)
        {
            this.Valor = v;
            this.Unidade = e;
        }
        public bool isComplete()
        {
            foreach (var prop in this.GetType().GetProperties())
            {
                if (prop.Name != "Id")
                {
                    var val = prop.GetValue(this, null);
                    if (val == null || val.ToString() == "0")
                        return false;
                }
            }
            return true;
        }

        public (string nome, double valor) getValorUnitario()
        {
            return (this.Nome, this.Valor / (int)Unidade);
        }
        public static string getFornecedorBarato(List<Flores> flores, string nome)
        {
            var flor = flores.FindAll(q => q.Nome == nome);
            Flores maisbarata = new Flores(500, EUnidade.Unidade);
            double valorF, valorB;
            foreach (var f in flor)
            {
                (_, valorF) = f.getValorUnitario();
                (_, valorB) = maisbarata.getValorUnitario();

                if (valorF < valorB)
                {
                    maisbarata = f;
                }
            }
            return maisbarata.Fornecedor;
        }
    }
}
