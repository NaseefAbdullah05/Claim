using Gainsco.Connect.Web.UI.SmokeTests.Framework.Data.EfConfiguration;
using Gainsco.Connect.Web.UI.SmokeTests.Framework.Data.Entities;
using System.Data.Entity;

namespace Gainsco.Connect.Web.UI.SmokeTests.Framework.Data
{
    public class GainscoDbContext : DbContext
    {
        private string _fileSchema = System.Configuration.ConfigurationManager.AppSettings["As400FileSchema"];

        public GainscoDbContext() : base("As400")
        { }

        public virtual DbSet<DriverRegistration> DriverRegistrations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DriverRegistrationConfiguration(_fileSchema));

            base.OnModelCreating(modelBuilder);
        }
    }
}