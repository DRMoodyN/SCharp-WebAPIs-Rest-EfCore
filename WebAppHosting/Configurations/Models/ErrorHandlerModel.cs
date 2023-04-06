namespace WebAppHosting.Configurations.Models
{
    public class ErrorHandlerModel
    {
        public int Status { get; set; }
        public string Message { get; set; } = null!;

        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
