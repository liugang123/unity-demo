using com.example.domain.repository;
using com.example.domain.service;
using Unity;

namespace com.example.unity
{
    public class UnityConfig
    {
        private readonly IUnityContainer _container;
        private static readonly UnityConfig unityConfig = new UnityConfig();

        private UnityConfig()
        {
            _container = new UnityContainer();
            this.RegisterType();
        }

        public static UnityConfig Instance
        {
            get { return unityConfig; }
        }

        private void RegisterType()
        {
            // IRepository注册IoC容器 
            _container.RegisterType<IUserRepository, UserRepository>();
            _container.RegisterType<ISendEmailRepository, SendEmailRepository>();

            // IService注册IoC容器
            _container.RegisterType<IUserService, UserService>();
            _container.RegisterType<ISendEmailService, SendEmailService>();
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
