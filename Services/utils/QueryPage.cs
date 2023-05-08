namespace Services.utils
{
    public class QueryPage
    {
        [Required(ErrorMessage = "El numero de pag es requerido")]
        public int pageSize { get; set; }

        [Required(ErrorMessage = "El numero de fila es requerido")]
        public int pageNumber { get; set; }
    }
}
