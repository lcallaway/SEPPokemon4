﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SEPPokemon4.Models;
using System;

namespace SEPPokemon4.Migrations
{
    [DbContext(typeof(SEPPokemon4Context))]
    [Migration("20171009030130_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SEPPokemon4.Models.Pokemon", b =>
                {
                    b.Property<int>("PokemonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AbilityHidden");

                    b.Property<string>("AbilityOne");

                    b.Property<string>("AbilityTwo");

                    b.Property<string>("Description");

                    b.Property<int>("EvolutionNo");

                    b.Property<int>("EvolutionPathsTotal");

                    b.Property<int>("EvolutionPosNo");

                    b.Property<int>("EvoultionPathsNo");

                    b.Property<decimal>("GenderFemale");

                    b.Property<decimal>("GenderMale");

                    b.Property<decimal>("Height");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<string>("Subtitle");

                    b.Property<string>("Type");

                    b.Property<decimal>("Weight");

                    b.HasKey("PokemonId");

                    b.ToTable("Pokemon");
                });
#pragma warning restore 612, 618
        }
    }
}
