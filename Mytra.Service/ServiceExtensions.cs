namespace Mytra.Service
{
    using Core;
    using DataAccess;
    using FluentValidation;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceExtensions
    {
        public static IServiceCollection LoadServices(this IServiceCollection Service)
        {
            Service.AddDbContext<DbContext>();
            Service.AddDbContext<MytraContext>();

            Service.AddScoped<ICandidateAuthenticationService, CandidateAuthenticationService>();
            Service.AddScoped<ICandidateCertificateService, CandidateCertificateService>();

			return Service;
        }
    }
}