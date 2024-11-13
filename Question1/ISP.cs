using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1;

public interface ISMSNotification
{
    void Notify(string number, string message);
}

public interface IEmailNotificaion
{
    void Notify(string email,  string message);
}

public class SMSNotificaion : ISMSNotification
{
    public void Notify(string number, string message)
    {
        Console.WriteLine($"{number} notified with message: {message}");
    }
}

public class EmailNotification : IEmailNotificaion
{
    public void Notify(string email, string message)
    {
        Console.WriteLine($"{email} notified with message {message}");
    }
}