using System;
using AppDotNet.Dados;
using System.Data.Entity;
using System.Linq;

namespace AppDotNet
{
    public class FloresContext : DbContext
    {
        public FloresContext()
            : base("name=FloresEventosDB")
        {
        }
        public virtual DbSet<Evento> Eventos { get; set; }
        public virtual DbSet<Arranjo> Arranjos { get; set; }
        public virtual DbSet<Flor> Flores { get; set; }
        public virtual DbSet<ValorFlor> ValorFlor { get; set; }
        public virtual DbSet<Fornecedor> Fornecedores { get; set; }
    }
}