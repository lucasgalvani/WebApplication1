﻿using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Mapeamento;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMapeamento());
            modelBuilder.ApplyConfiguration(new ProfessorMapeamento());
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
    }
}
