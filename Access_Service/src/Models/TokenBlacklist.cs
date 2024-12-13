public class TokenBlacklist
{
    public int Id { get; set; }
    public string Jti { get; set; } = string.Empty;
    public DateTime Expiration { get; set; }
}