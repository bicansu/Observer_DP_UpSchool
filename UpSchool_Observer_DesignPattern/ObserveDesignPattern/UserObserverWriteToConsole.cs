using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using UpSchool_Observer_DesignPattern.DAL;

namespace UpSchool_Observer_DesignPattern.ObserveDesignPattern
{
    public class UserObserverWriteToConsole : IUserObserver
    {
        private IServiceProvider _serviceProvider;

        public UserObserverWriteToConsole(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreeteUser(AppUser appUser)
        {
            var loger = _serviceProvider.GetRequiredService<ILogger<UserObserverWriteToConsole>>();
            loger.LogInformation($"{appUser.Name + "" + appUser.Surname} isimli kullanıcı sisteme kaydoldu");
        }
    }
}
