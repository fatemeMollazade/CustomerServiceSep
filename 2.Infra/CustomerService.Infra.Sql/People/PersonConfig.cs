using CustomerService.Core.Domain.People.Entities;
using CustomerService.Core.Domain.People.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Infra.Sql.People
{
    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(30);
            builder.Property(x => x.LastName).HasMaxLength(70);
            builder.Property(x => x.FatherName).HasConversion(x => x.Value, y => FatherName.FromString(y)).HasMaxLength(30);
            builder.Property(x => x.BirthDate).HasConversion(x => x.Date, y => BirthDate.FromDate(y));            
            builder.Property(x => x.Mobile).HasConversion(x => x.Number, y => Mobile.FromString(y)).IsRequired().HasMaxLength(11);
            builder.OwnsOne(x => x.Address).Property(x => x.AddressLine).HasColumnName("Address");
            builder.OwnsOne(x => x.Address).Property(x => x.ZipCode).HasColumnName("ZipCode");
            builder.OwnsOne(x => x.Address).Property(x => x.CityId).HasColumnName("CityId");
        }
    }
}
