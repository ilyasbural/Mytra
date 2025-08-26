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
            Service.AddScoped<ICandidateContactService, CandidateContactService>();
            Service.AddScoped<ICandidateDetailService, CandidateDetailService>();
            Service.AddScoped<ICandidateEducationService, CandidateEducationService>();
            Service.AddScoped<ICandidateExperienceService, CandidateExperienceService>();
            Service.AddScoped<ICandidateLanguageService, CandidateLanguageService>();
            Service.AddScoped<ICandidatePhotoService, CandidatePhotoService>();
            Service.AddScoped<ICandidateReferanceService, CandidateReferanceService>();
            Service.AddScoped<ICandidateService, CandidateService>();
            Service.AddScoped<ICandidateSettingsService, CandidateSettingsService>();
            Service.AddScoped<ICandidateSkillsService, CandidateSkillsService>();
            Service.AddScoped<ICollegeService, CollegeService>();
            Service.AddScoped<IInstitutionService, InstitutionService>();
            Service.AddScoped<IJobPostingApplyService, JobPostingApplyService>();
            Service.AddScoped<IJobPostingDetailService, JobPostingDetailService>();
            Service.AddScoped<IJobPostingService, JobPostingService>();
            Service.AddScoped<IJobPostingVisitService, JobPostingVisitService>();
            Service.AddScoped<ILanguageService, LanguageService>();

			return Service;
        }
    }
}