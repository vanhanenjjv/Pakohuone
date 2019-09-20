using Microsoft.EntityFrameworkCore;

namespace Pakohuone.Data
{
    public class PakohuoneContext : DbContext
    {
        public PakohuoneContext(DbContextOptions<PakohuoneContext> dbContextOptions)
            : base(dbContextOptions)
        {
        }
    }
}
