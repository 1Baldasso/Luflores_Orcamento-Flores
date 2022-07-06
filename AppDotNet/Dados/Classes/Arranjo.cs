using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDotNet.Dados
{
    public class Arranjo
    {
        [Key, Column(Order = 0)] public Evento Evento;
        [Key, Column(Order = 1), DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int Id { get; set; }
        [Required] public string Nome { get; set; }
        [Required] public double Valor { get; set; }
        [Required] public List<Flor> Flores { get; set; }
    }
}
