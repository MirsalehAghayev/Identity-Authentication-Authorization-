using System.ComponentModel.DataAnnotations;

namespace fiorello_project.ViewModels.Accountt
{
    public class AccountRegisterViewModel
    {
        [Required, MaxLength(30)]
        public string Fullname { get; set; }

        [Required, MaxLength(70), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, MaxLength(30)]
        public string Username { get; set; }

        [Required, MaxLength(70), DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, MaxLength(70), DataType(DataType.Password), Display(Name = "Confirm Password"), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
