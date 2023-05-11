using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieTicketManagement.Controllers
{
    public class EmailController : ApiController
    {
        private readonly EmailService _emailService;



        public EmailController()
        {
            _emailService = new EmailService();
        }

        [Route("api/email/send")]

        [HttpPost]
        public IHttpActionResult SendEmail(EmailRequest request)
        {
            bool result = _emailService.SendEmail(request.Recipient, request.Subject, request.Body);



            if (result)
            {
                return Ok("Email sent successfully.");
            }
            else
            {
                return BadRequest("Failed to send email.");
            }
        }
    }



    public class EmailRequest
    {
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}

