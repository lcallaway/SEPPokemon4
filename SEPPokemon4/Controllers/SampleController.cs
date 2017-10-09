using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SEPPokemon4.Models;

namespace SEPPokemon4.Controllers
{
    public class SampleController : Controller
    {
        private readonly SEPPokemon4Context _context;
        public SampleController(SEPPokemon4Context context)
        {
            _context = context;
        }
        public async Task<IActionResult> Test()
        {
            var Id = 1013; //return first pokemon

            var pokemon = await _context.Pokemon.SingleOrDefaultAsync(m => m.PokemonId == Id);

            return View(pokemon);
            //return View(await _context.Pokemon.ToListAsync());

        }
    }
}