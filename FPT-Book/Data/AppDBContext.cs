/*using FPT_Book.Models;
using Microsoft.EntityFrameworkCore;

namespace FPT_Book.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author_Book>().HasKey(am => new
            {
                am.AuthorId,
                am.BookId
            });
            modelBuilder.Entity<Author_Book>()
                        .HasOne(m => m.Book)
                        .WithMany(am => am.Authors_Books)
                        .HasForeignKey(am => am.BookId);
            modelBuilder.Entity<Author_Book>()
                        .HasOne(m => m.Author)
                        .WithMany(am => am.Authors_Books)
                        .HasForeignKey(am => am.AuthorId);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author_Book> Authors_Books { get; set; }
        public DbSet<Bookstore> Bookstores { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}
*/

using FPT_Book.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FPT_Book.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author_Book>(ConfigureAuthor_Book);
        }

        private static void ConfigureAuthor_Book(EntityTypeBuilder<Author_Book> entity)
        {
            entity.HasKey(am => new { am.AuthorId, am.BookId });

            entity.HasOne(m => m.Book)
                .WithMany(am => am.Authors_Books)
                .HasForeignKey(am => am.BookId);

            entity.HasOne(m => m.Author)
                .WithMany(am => am.Authors_Books)
                .HasForeignKey(am => am.AuthorId);
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author_Book> Authors_Books { get; set; }
        public DbSet<Bookstore> Bookstores { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
