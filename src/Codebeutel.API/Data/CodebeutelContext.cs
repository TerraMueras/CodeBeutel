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

    public DbSet<Dispenser> Dispensers { get; set; }
    public DbSet<NewDispenser> NewDispensers { get; set; }
    public DbSet<NewDispenserApproval> NewDispenserApprovals { get; set; }
    public DbSet<Report> Reports { get; set; }
    public DbSet<DogFriendlyPlace> DogFriendlyPlaces { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<SuggestedDispenser> SuggestedDispensers { get; set; }
    public DbSet<SuggestedDispenserApproval> SuggestedDispenserApprovals { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(connectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dispenser>().ToTable("Dispenser").HasMany(d => d.Reports);
        modelBuilder.Entity<NewDispenser>().ToTable("NewDispenser").HasMany(d => d.Approvals);
        modelBuilder.Entity<NewDispenserApproval>().ToTable("NewDispenserApproval");
        modelBuilder.Entity<Report>().ToTable("Report");
        modelBuilder.Entity<DogFriendlyPlace>().ToTable("DogFriendlyPlace");
        modelBuilder.Entity<Category>().ToTable("Category");
        modelBuilder.Entity<SuggestedDispenser>().ToTable("SuggestedDispenser").HasMany(d => d.Approvals);
        modelBuilder.Entity<SuggestedDispenserApproval>().ToTable("SuggestedDispenserApproval");
    }
}

