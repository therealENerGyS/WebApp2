using System.ComponentModel.DataAnnotations;
using WebApp2.Models.Entities;

namespace WebApp2.ViewModels
{
    public class ContactFormViewModel
    {
        [Display(Name = "Your Name*")]
        [Required(ErrorMessage = "You need to enter a name.")]
        [RegularExpression(@"^[a-zA-ZÅÄÖåäö\s'-]+$", ErrorMessage = "Only letters A-Ö, (Dash) -, (Apostrophe) ', and spaces allowed.")]
        public string Name { get; set; } = null!;

        [Display(Name = "E-mail*")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You must enter an e-mail address.")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Please input a valid email: \"email@domain.com\"")]
        public string Email { get; set; } = null!;

        [Display(Name = "Phone Number (Optional)")]
        public string? PhoneNumber { get; set; }

        [Display(Name = "Company (Optional)")]
        public string? CompanyName { get; set; }

        [Display(Name = "Write something*")]
        public string Comment { get; set; } = null!;

        [Display(Name = "Save my name and email on this browser for the next time i comment.")]
        public bool RememberMe { get; set; } = false;
    }
}
