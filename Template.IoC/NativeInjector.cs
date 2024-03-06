using Microsoft.Extensions.DependencyInjection;
using Template.Application.Interfaces;
using Template.Application.Services;
using Template.Data.Context;


namespace Template.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {

            services.AddScoped<IUserService, UserService>();
        }
    }
}