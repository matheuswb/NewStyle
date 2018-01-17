using Microsoft.EntityFrameworkCore;
using NewStyle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewStyle
{
    public class Contexto : DbContext
    {

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

    }
}
