using com.example.domain.service;
using com.example.unity;
using System;

namespace com.example.host
{
    class Program
    {
        static void Main(string[] args)
        {
            // 获取IoC容器对象
            IUserService userService = UnityConfig.Instance.Resolve<IUserService>();
            // 执行业务方法
            userService.Add();

            Console.ReadLine();
        }
    }
}
