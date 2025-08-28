using System.ComponentModel.DataAnnotations;

namespace DV._2023.T1F5N8.ITEHA.D3.Models
{
    public class AdminUser
    {
        [Required(ErrorMessage = "Username is required")]
        [Display(Name = "Username")]
        public string Username { get; set; } = "";

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = "";
    }
}
