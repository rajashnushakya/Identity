﻿using asp.netIdentityApp.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace asp.netIdentityApp.Data;

public class aspnetIdentityAppContext : IdentityDbContext<aspnetIdentityAppUser>
{
    public aspnetIdentityAppContext(DbContextOptions<aspnetIdentityAppContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
}
public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<aspnetIdentityAppUser>
{
    public void Configure(EntityTypeBuilder<aspnetIdentityAppUser> builder)
    {
        builder.Property(x => x.FirstName).HasMaxLength(200);
        builder.Property(x => x.LastName).HasMaxLength(200);
    }
}