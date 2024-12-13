using InsuranceDomain;
using Microsoft.EntityFrameworkCore;

namespace InsuranceAPI.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public DbSet<Vehicle> Vehicles { get; set; }
}  