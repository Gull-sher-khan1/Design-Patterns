using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public interface IEmailService
    {
        public void SendEmail(string body);
    }

    public class EmailService : IEmailService
    {
        public void SendEmail(string body)
        {
            Console.WriteLine(body);
        }
    }

    public class Notification
    {
        private EmailService _service;

        public Notification(EmailService service)
        {
            _service = service;
        }

        public void SendNotification(string body)
        {
            _service.SendEmail(body);
        }
    }
}
