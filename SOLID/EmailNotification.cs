using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class EmailNotification
    {
        private IEmailSender _emailSender;

        public EmailNotification(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void Send(string emailAddress, string message)
        {
            _emailSender.Send(emailAddress, message);
        }
    }   
                    
    public interface IEmailSender
    {
        void Send(string emailAddress, string message);
    }
       
    public class SmtpClient : IEmailSender
    {
        public void Send(string emailAddress, string message)
        { }
    }
}
