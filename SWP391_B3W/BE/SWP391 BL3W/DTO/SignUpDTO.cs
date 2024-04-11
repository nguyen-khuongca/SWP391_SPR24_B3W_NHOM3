namespace SWP391_BL3W.DTO
{
    public class SignUpDTO
    {
        public string Username { get; set; } = null!;
        public string? HashPassword { get; set; }
        public string Email { get; set; } = null!;
    }
}
