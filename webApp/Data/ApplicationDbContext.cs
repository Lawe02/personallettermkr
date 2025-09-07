using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using webApp.Model;

namespace webApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        DbSet<UpploadedFile> UpploadedResumes{ get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UpploadedFile>()
                .HasOne(x => x.User)
                .WithMany(u => u.UploadedResumes)
                .HasForeignKey(f => f.UserId); 
        }
    }
}
