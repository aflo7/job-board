using Microsoft.EntityFrameworkCore;
using BulkyBookWeb.Models;

namespace BulkyBookWeb.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Category> Categories { get; set; }
    
    public DbSet<Job> Job { get; set; }
    
    public DbSet<Companies> Companies { get; set; }

    public DbSet<JobListings> JobListings { get; set; }


}