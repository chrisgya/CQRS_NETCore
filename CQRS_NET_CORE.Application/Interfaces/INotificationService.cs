using CQRS_NETCore.Application.Notifications.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_NETCore.Application.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(Message message);
    }
}
