using MassTransit;
using AuthService.Data;
using Microsoft.EntityFrameworkCore;
using Shared.Messages;

namespace ConsumerApi.Consumers
{
    public class UpdatePasswordConsumer : IConsumer<UpdatePasswordMessage>
    {
        private readonly DataContext _context;

        public UpdatePasswordConsumer(DataContext context)
        {
            _context = context;
        }

        public async Task Consume(ConsumeContext<UpdatePasswordMessage> context)
        {
            var message = context.Message;

            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserUuid == message.UserUuid);
            if (user != null)
            {
                user.Password = message.NewPassword;
                await _context.SaveChangesAsync();
            }
        }
    }
}