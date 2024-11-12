using System.ComponentModel.DataAnnotations;

using Freelancer.Validation;

namespace Freelancer.Models.ViewModels;

public class ContactViewModel
{
    [Display(Name = "Full name")]
    [Required(ErrorMessage = "You must enter your name")]
    public string? Name { get; set; }

    [Display(Name = "Email adress")]
    [EmailAddress(ErrorMessage = "You must enter a valid email adress")]
    [Required(ErrorMessage = "You must enter your email adress")]
    public string? Email { get; set; }

    [Display(Name = "Phone number")]
    public string? Phone { get; set; }

    [Display(Name = "Message")]
    [Required(ErrorMessage = "You must enter your message")]
    public string? Message { get; set; }

    [Display(Name = "Yes, I give my permission to store and process my data")]
    [Required(ErrorMessage = "You must give consent to us storing your details before you can send us a message")]
    [MustBeTrue(ErrorMessage = "You must give consent to us storing your details before you can send us a message")]
    public bool Consent { get; set; }
}