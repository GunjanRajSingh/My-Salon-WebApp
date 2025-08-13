using System.ComponentModel.DataAnnotations;

namespace SalonWebsite.Models
{
    public class ContactForm
    {
        [Required]
        public string Name { get; set; }
        
        [Required, EmailAddress]
        public string Email { get; set; }
        
        [Required]
        public string Message { get; set; }
    }
}
