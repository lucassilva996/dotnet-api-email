using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_api_email.Services
{
    public interface ISendEmail
    {
        Task SendEmailAsync(string email, string subject, string body);
    } 
}