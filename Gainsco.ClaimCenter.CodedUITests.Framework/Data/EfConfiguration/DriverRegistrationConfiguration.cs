using Gainsco.Connect.Web.UI.SmokeTests.Framework.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Gainsco.Connect.Web.UI.SmokeTests.Framework.Data.EfConfiguration
{
    public class DriverRegistrationConfiguration : EntityTypeConfiguration<DriverRegistration>
    {
        public DriverRegistrationConfiguration(string schema)
        {
            ToTable("MVRMSTR", schema);
            HasKey(a => new { a.Source, a.ReferenceNumber });

            Property(p => p.Source).HasColumnName("MVR_SOURCE").IsUnicode(false).IsFixedLength().HasMaxLength(10);
            Property(p => p.ReferenceNumber).HasColumnName("REQUEST_NUMBER").HasColumnType("DECIMAL").HasPrecision(11, 0);
            Property(p => p.FirstName).HasColumnName("DRIVER_FIRST_NAME").IsUnicode(false).IsFixedLength().HasMaxLength(25);
            Property(p => p.MiddleName).HasColumnName("DRIVER_MIDDLE_NAME").IsUnicode(false).IsFixedLength().HasMaxLength(15);
            Property(p => p.LastName).HasColumnName("DRIVER_LAST_NAME").IsUnicode(false).IsFixedLength().HasMaxLength(25);
            Property(p => p.Address).HasColumnName("DRIVER_ADDRESS").IsUnicode(false).IsFixedLength().HasMaxLength(40);
            Property(p => p.City).HasColumnName("DRIVER_CITY").IsUnicode(false).IsFixedLength().HasMaxLength(30);
            Property(p => p.State).HasColumnName("DRIVER_STATE").IsUnicode(false).IsFixedLength().HasMaxLength(2);
            Property(p => p.Zip).HasColumnName("DRIVER_ZIP").IsUnicode(false).IsFixedLength().HasMaxLength(9);
            Property(p => p.DateOfBirth).HasColumnName("DRIVER_DATE_OF_BIRTH").HasColumnType("DATE").HasPrecision(0);
            Property(p => p.LicenseNumber).HasColumnName("DRIVER_LICENSE_NBR").IsUnicode(false).IsFixedLength().HasMaxLength(19);
            Property(p => p.LicenseState).HasColumnName("DRIVER_LICENSE_STATE").IsUnicode(false).IsFixedLength().HasMaxLength(2);
            Property(p => p.LicenseClass).HasColumnName("DRIVER_CLASS").IsUnicode(false).IsFixedLength().HasMaxLength(12);
        }
    }
}