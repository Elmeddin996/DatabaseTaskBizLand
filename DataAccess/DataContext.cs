using DatabaseBizLand.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseBizLand.DataAccess
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Service> Services { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}
