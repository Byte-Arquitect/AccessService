using MassTransit;
using AuthService.Data;
using AuthService.Models;
using Shared.Messages;

namespace ConsumerApi.Consumers
{
    public class RegisterUserConsumer : IConsumer<RegisterUserMessage>
    {
        private readonly DataContext _context;

        public RegisterUserConsumer(DataContext context)
        {
            _context = context;
        }

        public async Task Consume(ConsumeContext<RegisterUserMessage> context)
        {
            var message = context.Message;

            var user = new User
            {
                Email = message.Email,
                Password = message.Password, 
                UserUuid = message.UserUuid
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}