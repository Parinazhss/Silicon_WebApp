using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels;

public class AccountDetailsViewModel
{
    public AccountBasicInfo? Basic {  get; set; }
    public AccountAddressInfo? Address { get; set; }
}
 public class AccountBasicInfo
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

    [Display(Name = "Phone (optional)", Prompt = "Enter your Phone")]
    public string? PhoneNumber { get; set; }

    [Display(Name = "Bio (optional)", Prompt = "Enter your Bio...")]
    public string? Bio { get; set; } = null!;
}

public class AccountAddressInfo
{
    [Required]
    [Display(Name = "Addressline_1", Prompt = "Enter your first Address")]
    public string Addressline_1 { get; set; } = null!;


    [Display(Name = "Addreessline_2", Prompt = "Enter your  second Address")]
    public string? Addressline_2 { get; set; }


    [Required]
    [Display(Name = "Postal Code", Prompt = "Enter your postal code")]
    public string PostalCode { get; set; } = null!;

    [Required]
    [Display(Name = "City", Prompt = "Enter your city")]
    public string City { get; set; } = null!;

}