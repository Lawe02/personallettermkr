using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;

namespace webApp.Data
{
    public class DataInitializer
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager _manager;
    }
}
