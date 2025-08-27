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

            Service.AddScoped<ICandidateAuthentication, CandidateAuthenticationRepositoryEF>();
            Service.AddScoped<ICandidateCertificate, CandidateCertificateRepositoryEF>();
            Service.AddScoped<ICandidateContact, CandidateContactRepositoryEF>();
            Service.AddScoped<ICandidateDetail, CandidateDetailRepositoryEF>();
            Service.AddScoped<ICandidateEducation, CandidateEducationRepositoryEF>();
            Service.AddScoped<ICandidateExperience, CandidateExperienceRepositoryEF>();
            Service.AddScoped<ICandidateLanguage, CandidateLanguageRepositoryEF>();
            Service.AddScoped<ICandidatePhoto, CandidatePhotoRepositoryEF>();
            Service.AddScoped<ICandidateReferance, CandidateReferanceRepositoryEF>();
            Service.AddScoped<ICandidate, CandidateRepositoryEF>();
            Service.AddScoped<ICandidateSettings, CandidateSettingsRepositoryEF>();
            Service.AddScoped<ICandidateSkills, CandidateSkillsRepositoryEF>();
            Service.AddScoped<ICollege, CollegeRepositoryEF>();
            Service.AddScoped<IInstitution, InstitutionRepositoryEF>();
            Service.AddScoped<IJobPostingApply, JobPostingApplyRepositoryEF>();
            Service.AddScoped<IJobPostingDetail, JobPostingDetailRepositoryEF>();
            Service.AddScoped<IJobPosting, JobPostingRepositoryEF>();
            Service.AddScoped<IJobPostingVisit, JobPostingVisitRepositoryEF>();
            Service.AddScoped<ILanguage, LanguageRepositoryEF>();
            Service.AddScoped<IManagerAuthentication, ManagerAuthenticationRepositoryEF>();
            Service.AddScoped<IManagerDetail, ManagerDetailRepositoryEF>();
            Service.AddScoped<IManager, ManagerRepositoryEF>();
            Service.AddScoped<IManagerSettings, ManagerSettingsRepositoryEF>();
            Service.AddScoped<ISkills, SkillsRepositoryEF>();
            Service.AddScoped<IUserAuthentication, UserAuthenticationRepositoryEF>();
            Service.AddScoped<IUserDetail, UserDetailRepositoryEF>();
            Service.AddScoped<IUser, UserRepositoryEF>();
            Service.AddScoped<IUserSettings, UserSettingsRepositoryEF>();
			Service.AddScoped<IUnitOfWork, UnitOfWork>();

			Service.AddScoped<IAuthenticationService, AuthenticationService>();
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
			Service.AddScoped<IManagerAuthenticationService, ManagerAuthenticationService>();
			Service.AddScoped<IManagerDetailService, ManagerDetailService>();
			Service.AddScoped<IManagerService, ManagerService>();
			Service.AddScoped<IManagerSettingsService, ManagerSettingsService>();
			Service.AddScoped<ISkillsService, SkillsService>();
			Service.AddScoped<IUserAuthenticationService, UserAuthenticationService>();
			Service.AddScoped<IUserDetailService, UserDetailService>();
			Service.AddScoped<IUserService, UserService>();
			Service.AddScoped<IUserSettingsService, UserSettingsService>();

			return Service;
        }
    }
}