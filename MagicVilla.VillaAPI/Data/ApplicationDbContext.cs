using MagicVilla.VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla.VillaAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Villa> Villas { get; set; }  
}
