using Microsoft.AspNetCore.Identity;

namespace webApp.Model
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<UpploadedFile> UploadedResumes { get; set; }
    }
}
