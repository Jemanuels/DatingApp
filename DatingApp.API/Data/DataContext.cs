using Datingapp.api.Models;
using Microsoft.EntityFrameworkCore;

namespace Datingapp.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Value> Values{get; set;}
    }
}