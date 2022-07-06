using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDotNet.Dados
{
    public class ValorFlor
    {
        [Key, Column(Order = 0)] public int FornecedorId { get; set; }
        [Key, Column(Order = 1)] public int FlorId { get; set; }
        [Required] public double Valor { get; set; }

        public ValorFlor(Fornecedor fo,Flor fl, double val)
        {
            this.FlorId = fl.Id;
            this.FornecedorId = fo.Id;
            this.Valor = val;
        }
    }
}
