using Microsoft.EntityFrameworkCore;
using RecipeCookbook.Infrastructure.Entities;

namespace RecipeCookbook.Infrastructure.Migrations;

public  class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }



    public DbSet<User> User { get; set; }

}
