using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ErmerTaste.Models
{
    public class ApplicationUsers : IdentityUser
    {
        [Display(Name="FullName")]
        public string  FullName { get; set; }
    }
}
