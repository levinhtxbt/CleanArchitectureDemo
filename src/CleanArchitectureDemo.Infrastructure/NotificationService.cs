using System.Threading.Tasks;
using CleanArchitectureDemo.Application.Common.Interfaces;
using CleanArchitectureDemo.Application.Notifications.Model;

namespace CleanArchitectureDemo.Infrastructure
{
    public class NotificationService : INotificationService
    {
        public async Task SendAsync(NotificationMessageDto message)
        {


             await Task.CompletedTask;
        }
    }
}
