using com.example.domain.repository;
using System;

namespace com.example.domain.service
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;

        private ISendEmailService sendEmailService;

        /// <summary>
        /// 构造注入
        /// </summary>
        /// <param name="userRepository"></param>
        public UserService(IUserRepository userRepository, ISendEmailService sendEmailService)
        {
            this.userRepository = userRepository;
            this.sendEmailService = sendEmailService;
        }

        public void Add()
        {
            Console.WriteLine("UserService Invoke Add Method");
            userRepository.Add();
            sendEmailService.SendEmail();
        }
    }
}
