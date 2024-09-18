using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Data.Mapeamento
{
    public class ProfessorMapeamento : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("Professor");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome).HasColumnType("varchar(40)");
            builder.Property(t => t.Disciplina).HasColumnType("varchar(20)");
            builder.Property(t => t.DataNascimento).HasColumnType("DateOnly");
            builder.Property(t => t.Sala).HasColumnType("varchar(15)");

        }
    }
}
//CREATE TABLE Professor(
//Id INT IDENTITY(1,1) NOT NULL,
//Nome VARCHAR(40),
//Disciplina VARCHAR(20),
//DataNascimento DATE,
//Sala VARCHAR(15),
//PRIMARY KEY(Id)
//)