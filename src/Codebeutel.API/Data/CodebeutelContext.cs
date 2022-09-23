using Codebeutel.API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Codebeutel.API.Data;

public class CodebeutelContext : DbContext
{
    private string connectionString { get; set; }

    public CodebeutelContext(IConfiguration configuration)
    {
        connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    public DbSet<WeatherForecast> WeatherForecasts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(connectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WeatherForecast>().ToTable("WeatherForecast");
    }
}
