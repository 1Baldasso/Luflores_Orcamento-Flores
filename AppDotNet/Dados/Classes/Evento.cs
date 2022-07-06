using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDotNet.Dados
{
    public class Evento
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int Id { get; set; }
        [Required] public string Nome { get; set; }
        [Required] public string LocalEvento { get; set; }
        [Required] public DateTime Data { get; set; }
        public List<Arranjo> Arranjos { get; set; }
    }
}
