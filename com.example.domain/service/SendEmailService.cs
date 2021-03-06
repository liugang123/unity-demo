using com.example.domain.repository;
using System;

namespace com.example.domain.service
{
    public class SendEmailService : ISendEmailService
    {
        private ISendEmailRepository sendEmailRepository;

        public SendEmailService(ISendEmailRepository sendEmailRepository)
        {
            this.sendEmailRepository = sendEmailRepository;
        }

        public void SendEmail()
        {
            Console.WriteLine("SendEmailService Invoke SendEmail Method");
            sendEmailRepository.SendEmail();
        }
    }
}
