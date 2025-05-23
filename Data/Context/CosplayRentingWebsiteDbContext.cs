using Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Data.Context;

public partial class CosplayRentingWebsiteDbContext : IdentityDbContext<ApplicationUser>
{
    public CosplayRentingWebsiteDbContext(DbContextOptions<CosplayRentingWebsiteDbContext> options)
        : base(options)
    {

    }

    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<CosOrder> CosOrders { get; set; }
    public DbSet<Costume> Costumes { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Payment> Payments { get; set; }



}

