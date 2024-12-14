namespace Shared.Messages; 

public class RegisterUserMessage
{
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string UserUuid { get; set; } = null!;
}