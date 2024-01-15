using MainSite.News;
using MainSite.User;
using Microsoft.EntityFrameworkCore;

namespace MainSite
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().HasData(new UserEntity
            {
                Id = 1,
                Family = "Иванов",
                Name = "Иван",
                Patronymic = "Иванович",
                Email = "ivanov@example.com",
                Password = "password",
            });
        }
        public DbSet<UserEntity> Users => Set<UserEntity>();

        public DbSet<News_Entity> News => Set<News_Entity>();
    }
}
