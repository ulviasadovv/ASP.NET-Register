using Microsoft.AspNetCore.Identity;

namespace ASP.NET_FrontToBackTask.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName {  get; set; }
        public bool IsActive {  get; set; }
    }
}
