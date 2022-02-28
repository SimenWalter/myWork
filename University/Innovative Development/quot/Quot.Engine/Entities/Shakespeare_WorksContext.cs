using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Quot.Engine.Db;

#nullable disable

namespace Quot.Engine.Entities
{
    public partial class Shakespeare_WorksContext : DbContext, IDbContext
    {
        public Shakespeare_WorksContext()
        {
        }

        public Shakespeare_WorksContext(DbContextOptions<Shakespeare_WorksContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Calculation> Calculations { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Collection> Collections { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Paragraph> Paragraphs { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<WordForm> WordForms { get; set; }
        public virtual DbSet<Work> Works { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:quot-dev-db.database.windows.net,1433;Initial Catalog=quot-dev-sp;Persist Security Info=False;User ID=hstout;Password=N0rr3ys13;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuthorDisplayName).HasMaxLength(255);

                entity.Property(e => e.AuthorId)
                    .HasMaxLength(255)
                    .HasColumnName("AuthorID");

                entity.Property(e => e.AuthorSortName).HasMaxLength(255);
            });

            modelBuilder.Entity<Calculation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CalculationId)
                    .HasMaxLength(50)
                    .HasColumnName("CalculationID");

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<Chapter>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Chapter1).HasColumnName("Chapter");

                entity.Property(e => e.ChapterId).HasColumnName("ChapterID");

                entity.Property(e => e.WorkId)
                    .HasMaxLength(50)
                    .HasColumnName("WorkID");
            });

            modelBuilder.Entity<Character>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Abbrev).HasMaxLength(50);

                entity.Property(e => e.CharId)
                    .HasMaxLength(50)
                    .HasColumnName("CharID");

                entity.Property(e => e.CharName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);
            });

            modelBuilder.Entity<Collection>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CollectionId)
                    .HasMaxLength(255)
                    .HasColumnName("CollectionID");

                entity.Property(e => e.CollectionName).HasMaxLength(255);

                entity.Property(e => e.Owner).HasMaxLength(255);
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GenreName).HasMaxLength(50);

                entity.Property(e => e.GenreType).HasMaxLength(1);
            });

            modelBuilder.Entity<Paragraph>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CharId)
                    .HasMaxLength(50)
                    .HasColumnName("CharID");

                entity.Property(e => e.ParagraphId).HasColumnName("ParagraphID");

                entity.Property(e => e.ParagraphType).HasMaxLength(1);

                entity.Property(e => e.WorkId)
                    .HasMaxLength(50)
                    .HasColumnName("WorkID");
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Section1).HasColumnName("Section");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");
            });

            modelBuilder.Entity<WordForm>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PhoneticText).HasMaxLength(50);

                entity.Property(e => e.PlainText).HasMaxLength(50);

                entity.Property(e => e.StemText).HasMaxLength(50);

                entity.Property(e => e.WordFormId).HasColumnName("WordFormID");
            });

            modelBuilder.Entity<Work>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GenreType).HasMaxLength(1);

                entity.Property(e => e.LongTitle).HasMaxLength(255);

                entity.Property(e => e.Source).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.WorkId)
                    .HasMaxLength(50)
                    .HasColumnName("WorkID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
