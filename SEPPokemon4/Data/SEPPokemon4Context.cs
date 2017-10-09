using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SEPPokemon4.Models
{
    public class SEPPokemon4Context : DbContext
    {
        public SEPPokemon4Context (DbContextOptions<SEPPokemon4Context> options)
            : base(options)
        {
        }

        public DbSet<SEPPokemon4.Models.Pokemon> Pokemon { get; set; }
    }
}
