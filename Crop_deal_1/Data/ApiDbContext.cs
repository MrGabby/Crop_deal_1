/*using System.Data.Entity;*/
using Crop_deal_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Crop_deal_1.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {
        } 
         
         public DbSet<User>Users { get; set; }
        public DbSet<Crop>Crops { get; set; }

        public DbSet<Crop_detail> Crop_details { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}
