using System;

namespace Company.ClassLibrary1;

public class AppDbContext : AppDbContext
{
    public DbSet <Producto> Productos {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
        var connectionString = "Server=localhost;Database=tiendaPepito;User=root;Password=tupas;";"
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
}