namespace Models
{
    public class UserRegister
    {
        [Required(ErrorMessage = "El Nombre es requerido")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "El Apellido es requerido")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "El Usuario es requerido")]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = "El Password es requerido")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "El Email es requerido")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "El Telefono es requerido")]
        public string PhoneNumber { get; set; } = null!;
        public ICollection<string>? Role { get; set; } = null!;
    }
}