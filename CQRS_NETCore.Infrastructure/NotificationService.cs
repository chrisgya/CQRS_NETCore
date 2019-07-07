using CQRS_NETCore.Application.Interfaces;
using CQRS_NETCore.Application.Notifications.Models;
using System.Threading.Tasks;

namespace CQRS_NETCore.Infrastructure
{
    public class NotificationService : INotificationService
    {
        public Task SendAsync(Message message)
        {
            return Task.CompletedTask;
        }
    }
}
