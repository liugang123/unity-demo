using System;

namespace com.example.domain.repository
{
    public class SendEmailRepository : ISendEmailRepository
    {
        public void SendEmail()
        {
            Console.WriteLine("SendEmailRepository Invoke SendEmail Method");
        }
    }
}
