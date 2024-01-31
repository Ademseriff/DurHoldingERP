using DurHoldingErp.Entity.DTOs;
using DurHoldingErp.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Service.Services.Concretes
{
    public class MailService : IMailService
    {
        public async Task  SendMail(MailDto mailDto)
        {
            try
            {
                
                string FromMail = "durholding@gmail.com";
                string FromPassword = "uvxu kfke dozf jisa";

                MailMessage message = new MailMessage();
                message.From = new MailAddress(FromMail);
                message.Subject = mailDto.Subject;

                message.To.Add(new MailAddress(mailDto.Reciver));
                message.Body = mailDto.Body;
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(FromMail, FromPassword),
                    EnableSsl = true
                };
                await smtpClient.SendMailAsync(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"E-posta gönderme hatası: {ex.Message}");
            }
          
        }


    }
}
