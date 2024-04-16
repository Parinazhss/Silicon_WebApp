using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels;

public class SubscribeViewModel
{
    [Required]
    [EmailAddress]
    [Display(Name = "Email", Prompt ="Your email")]
    public string Email { get; set; } = null!;

    public bool DailyNewsletter { get; set; }

    public bool AdvertisingUpdates { get; set; }

    public bool WeekinReviews { get; set; }

    public bool EventUpdate { get; set; }

    public bool StartupsWeekly { get; set; }

    public bool Podcaste { get; set; }

}
