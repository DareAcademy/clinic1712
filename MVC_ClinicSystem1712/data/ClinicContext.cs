using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;

namespace MVC_ClinicSystem1712.data
{
    public class ClinicContext: IdentityDbContext<ApplicationUser>//DbContext
    {
        IConfiguration config;
        public ClinicContext(IConfiguration _config)
        {
            config = _config;
        }

        public DbSet<Country> countries { get; set; }

        public DbSet<Patient> patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(config.GetConnectionString("clinicConn"));
            //optionsBuilder.UseSqlServer("data source=localhost;integrated security=true;initial catalog=Clinic_MVC_1712");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
