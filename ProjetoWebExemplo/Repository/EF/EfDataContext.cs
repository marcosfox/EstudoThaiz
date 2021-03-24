namespace Repository.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Domain.Entities;

    public partial class EfDataContext : DbContext
    {
        public EfDataContext()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Aluno> Aluno { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Aluno
            modelBuilder.Entity<Aluno>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Aluno>()
                .Property(e => e.telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Aluno>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<Aluno>()
                .Property(e => e.email)
                .IsUnicode(false);
            #endregion Aluno
        }
    }
}
