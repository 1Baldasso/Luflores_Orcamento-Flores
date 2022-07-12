using AppDotNet.Dados;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDotNet
{
    public class Flor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required] public string Nome { get; set; }
        [Required] public Unidade Unidade { get; set; }
        public List<Fornecedor> Fornecedor { get; set; }

        public Flor() { }
        public Flor(string nome, Unidade unidade)
        {
            this.Nome = nome;
            this.Unidade = unidade;
        }
        public void AddFornecedor(Fornecedor fo)
        {
            Fornecedor.Add(fo);
        }
        public bool IsComplete()
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
    }
}
