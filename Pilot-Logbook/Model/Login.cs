using System.ComponentModel.DataAnnotations;

namespace FlightLog.Models
{
    public class LoginModel: IEntity
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Id {get; set;}
    }
}


