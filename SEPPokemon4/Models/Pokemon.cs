﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEPPokemon4.Models
{
    public class Pokemon
    {
        public int PokemonId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Subtitle { get; set; }
        public string AbilityOne { get; set; }
        public string AbilityTwo { get; set; }
        public string AbilityHidden { get; set; }
        public decimal Height { get; set; }
        public decimal GenderMale { get; set; }
        public decimal GenderFemale { get; set; }
        public decimal Weight { get; set; }
        public int EvolutionNo { get; set; }
        public int EvolutionPosNo { get; set; }
        public int EvoultionPathsNo { get; set; }
        public int EvolutionPathsTotal { get; set; }
    }
}
