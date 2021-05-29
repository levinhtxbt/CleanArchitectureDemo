using System.Threading.Tasks;
using CleanArchitectureDemo.Application.Notifications.Model;

namespace CleanArchitectureDemo.Application.Common.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(NotificationMessageDto message);
    }
}
