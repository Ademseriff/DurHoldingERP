using DurHoldingErp.Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Service.Services.Abstractions
{
    public interface IMailService
    {
        Task SendMail(MailDto mailDto);
    }
}
