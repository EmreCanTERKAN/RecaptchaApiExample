using Microsoft.EntityFrameworkCore;
using RecaptchaApiExample.Entities;

namespace RecaptchaApiExample.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<RecaptchaLog> RecaptchaLogs { get; set; }
    public DbSet<User> Users { get; set; }

}
