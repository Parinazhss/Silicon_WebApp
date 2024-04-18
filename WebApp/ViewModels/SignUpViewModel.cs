using System.ComponentModel.DataAnnotations;
using WebApp.Filters;

namespace WebApp.ViewModels;

public class SignUpViewModel
{

    [Required]
    [Display(Name = "First Name", Prompt = "Enter your first name")]
 
    public string FirstName { get; set; } = null!;

    [Required]
    [Display(Name = "Last Name", Prompt = "Enter your last name")]
    public string LastName { get; set; } = null!;

    [Required]
    [Display(Name = "Email Address", Prompt = "Enter your email address")]
    [DataType(DataType.EmailAddress)]
    [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address.")]
    public string Email { get; set; } = null!;


    [Required]
    [Display(Name = "Password", Prompt = "Enter your password")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Required]
    [Display(Name = "Confirm password", Prompt = "Confirm your password")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Fields does not match")]
    public string ComfirmPassword { get; set; } = null!;



    [CheckboxRequired]
    [Display(Name = "I agree to the Terms & Conditions.", Prompt ="Terms and Conditions")]
    public bool TermsAndConditions { get; set; } = false;
}
