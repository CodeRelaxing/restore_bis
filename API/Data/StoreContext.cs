using System;
using API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class StoreContext(DbContextOptions options) : IdentityDbContext<User>(options)
{
    public required DbSet<Product> Products { get; set; }
    public required DbSet<Basket> Baskets { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>()
            .HasData(
                new IdentityRole{Id = "ffe5aee0-ca9b-42da-9111-a52d7daa3e7d" , ConcurrencyStamp = "Member", Name = "Member", NormalizedName = "MEMBER"},
                new IdentityRole{Id = "8d95a16a-3f3a-4d3b-85b9-349a4cbc2474", ConcurrencyStamp = "Admin", Name = "Admin", NormalizedName = "ADMIN"}
            );
    }
}
