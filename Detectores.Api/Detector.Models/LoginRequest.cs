namespace Detectores.Api.Models
{
    public class LoginRequest
    {
        public string User { get; set; }
        public string Password { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(User) && !string.IsNullOrWhiteSpace(Password);
        }
    }
}
