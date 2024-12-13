namespace Shared.Messages; 

public class RegisterMessage
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string UserUuid { get; set; }
}