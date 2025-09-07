using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using webApp.Model;

namespace webApp.Data
{
    public class DataInitializer
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public DataInitializer(ApplicationDbContext context, UserManager<ApplicationUser> manager)
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

            var normalizedUserName = userName.ToUpper();

            if (_dbContext.Users.Any(u => u.NormalizedUserName == normalizedUserName))
            {
                return; // user already exists
            }

            var user = new ApplicationUser
            {
                UserName = userName,
                Email = userName,
                EmailConfirmed = true
            };
            _userManager.CreateAsync(user, password).Wait();
        }
    }
}
