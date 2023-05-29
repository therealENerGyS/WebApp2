using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using WebApp2.Models.Entities;

namespace WebApp2.ViewModels
{
    public class RegisterViewModel
    {
        [Display(Name = "First Name")]
        [RegularExpression(@"^[a-zA-ZÅÄÖåäö'-]+$", ErrorMessage = "Only letters A-Ö, Dash (-) and (') allowed.")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last Name")]
        [RegularExpression(@"^[a-zA-ZÅÄÖåäö'-]+$", ErrorMessage = "Only letters A-Ö, Dash (-) and (') allowed.")]
        public string LastName { get; set; } = null!;

        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Email format invalid")]
        public string Email { get; set; } = null!;

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one number, and one special character.")]
        public string Password { get; set; } = null!;

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "The password does not match")]
        public string ConfirmPassword { get; set; } = null!;

        [Display(Name = "I have read and accepts the Terms of Service.")]
        [Required(ErrorMessage = "You must agree to the Terms of Service.")]
        public bool Terms { get; set; }

        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }

        [Display(Name = "Company Name")]
        public string? CompanyName { get; set; }

        [Display(Name = "Street Name")]
        public string? StreetName { get; set; }

        [Display(Name = "Postal Code")]
        public string? PostalCode { get; set; }

        [Display(Name = "City")]
        public string? City { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image")]
        public IFormFile? Image { get; set; }

        [Display(Name = "Comment")]
        public string? Comment { get; set; }

        public static implicit operator IdentityUser(RegisterViewModel registerViewModel)
        {
            return new IdentityUser
            {
                UserName = registerViewModel.Email,
                Email = registerViewModel.Email,
                PhoneNumber = registerViewModel.PhoneNumber,
            };
        }

        public static implicit operator UserProfileEntity(RegisterViewModel registerViewModel)
        {
            return new UserProfileEntity
            {
                FirstName = registerViewModel.FirstName,
                LastName = registerViewModel.LastName,
                StreetName = registerViewModel.StreetName,
                PostalCode = registerViewModel.PostalCode,
                City = registerViewModel.City,
                Comment = registerViewModel.Comment

            };
        }
    }
}