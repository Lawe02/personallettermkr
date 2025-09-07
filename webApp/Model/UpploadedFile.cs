using Microsoft.AspNetCore.Identity;

namespace webApp.Model
{
    public class UpploadedFile
    {
        public int Id { get; set; } 
        public required string FileName { get; set; } = null!;
        public required string ContentType { get; set; }
        public required byte[] Data { get; set; } 
        public String UserId { get; set; }
        public required ApplicationUser User { get; set; }
    }
}
