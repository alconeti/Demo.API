using Demo.Common.Enttities;
using Microsoft.EntityFrameworkCore;

namespace Demo.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            // Comentario
        }

        public DbSet<DemoDTO> Demos { get; set; }
    }

}
