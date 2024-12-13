namespace Shared.Messages; 

public class UpdateMessage
{
    public string UserUuid { get; set; }
    public string NewPassword { get; set; }
}