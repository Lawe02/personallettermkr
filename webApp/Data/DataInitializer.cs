using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace webApp.Data
{
    public class DataInitializer
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public DataInitializer(ApplicationDbContext context, UserManager<IdentityUser> manager)
        {
            _dbContext = context;
            _userManager = manager;
        }

        public void SeedData()
        {
            _dbContext.Database.Migrate();
            AddUserIfNotExists("mariogomez@gmail.com", "Lawe1234#");
        }

        private void AddUserIfNotExists(string userName, string password)
        {
            if (_userManager.FindByEmailAsync(userName).Result != null) return;

            var user = new IdentityUser
            {
                UserName = userName,
                Email = userName,
                EmailConfirmed = true
            };
            _userManager.CreateAsync(user, password).Wait();
        }
    }
}
