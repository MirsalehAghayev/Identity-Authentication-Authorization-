using System.ComponentModel.DataAnnotations;

namespace fiorello_project.ViewModels.Accountt
{
    public class AccountLoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required, MaxLength(70), DataType(DataType.Password)]
        public string Password { get; set; }

        public string? ReturnUrl { get; set; }
    }
}
