using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeyrekTur.WebUI.EmailServices
{
    public interface IEmailSender
    {
        //smp
        //api =>sendgrid
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}
