using CoinDispenserWebApI.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoinDispenserWebApI.Data
{
    public class DataContext:DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public DataContext(DbContextOptions<DataContext> options) : base(options) { } 
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Change> Changes { get; set; }
       
    }
}
