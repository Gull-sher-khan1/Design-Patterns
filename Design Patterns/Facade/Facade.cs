using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class EmailNotifier
    {
        public string Notify(Message m)
        {
            return $"To: {m.Reciever}, From: {m.Sender}\n" +
                $"Title: {m.Title} \n Body: {m.Body}";
        }
    }

    public class SmsNotifier
    {
        public string Notify(Message message)
        {
            return $"Send To:{message.Reciever}\n {message.Body}";
        }
    }

    public class AppNotifier
    {
        public string Notify(Message m)
        {
            return $"From: {m.Sender}\n {m.Body}";
        }
    }
    public class Message
    {
        public string Sender { get; set; }
        public string Reciever { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }

        public Message(string sender, string reciever, string body, string title)
        {
            Sender = sender;
            Reciever = reciever;
            Body = body;
            Title = title;
        }
    }

    public class NotifierFacade
    {
        public Message Msg { get; set; }

        public NotifierFacade(Message msg)
        {
            Msg = msg;
        }

        public void NotifyBy(string notifier) 
        {
            if (notifier == "email")
            {
                Console.WriteLine(new EmailNotifier().Notify(Msg)); ;
            }
            else if(notifier == "sms") 
            {
                Console.WriteLine(new SmsNotifier().Notify(Msg)); ;
            }
            else
            {
                Console.WriteLine(new AppNotifier().Notify(Msg)); ;
            }
        }
    }
}
