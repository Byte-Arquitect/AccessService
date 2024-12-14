namespace Shared.Messages; 

public class UpdatePasswordMessage
{
    public string UserUuid { get; set; } = null!;
    public string NewPassword { get; set; } = null!;
}