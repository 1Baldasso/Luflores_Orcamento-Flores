using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDotNet.Dados
{
    public class Fornecedor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required] public string Nome { get; set; }
        public List<string> Telefone { get; set; }
        public Fornecedor (){}
        public Fornecedor(string Nome)
        {
            this.Nome = Nome;
        }
        public Fornecedor(string nome, List<string> telefone)
        {
            this.Nome = nome;
            this.Telefone = telefone;
        }
    }
}
