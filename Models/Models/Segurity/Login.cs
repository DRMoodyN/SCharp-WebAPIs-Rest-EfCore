namespace Models
{
    public class Login
    {
        [Required(ErrorMessage = "El Usuario es requerido")]
        [MaxLength(20, ErrorMessage = "El Usuairo no puede tener mas de 20 caracteres")]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = "La contraseña es requerida")]
        [MaxLength(20, ErrorMessage = "La contraseña no puede tener mas de 15 caracteres")]
        public string Password { get; set; } = null!;
    }
}
