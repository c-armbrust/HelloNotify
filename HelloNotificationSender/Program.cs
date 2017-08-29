// Project: HelloNotify
// Tutorial: https://docs.microsoft.com/de-de/azure/notification-hubs/notification-hubs-windows-store-dotnet-get-started-wns-push-notification
// Note: Provide hubName and hubListenSas (The Name and SAS string of a Notification Hub) to make it work

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Notifications
using Microsoft.Azure.NotificationHubs;

namespace HelloNotificationSender
{
    class Program
    {
        private static async void SendNotificationAsync()
        {
            // Provide Name and SAS of Notification Hub
            string hubName = "";
            string hubListenSas = "";
            NotificationHubClient hub = NotificationHubClient
                .CreateClientFromConnectionString(hubListenSas, hubName);
            var toast = @"<toast><visual><binding template=""ToastText01""><text id=""1"">Hello from a .NET App!</text></binding></visual></toast>";
            await hub.SendWindowsNativeNotificationAsync(toast);
        }

        static void Main(string[] args)
        {
            SendNotificationAsync();
            Console.ReadLine();
        }
    }
}
