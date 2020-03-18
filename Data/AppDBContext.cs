using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Q1.Model;

namespace Q1.Data
{
    class AppDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "Users.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }
    }
}
