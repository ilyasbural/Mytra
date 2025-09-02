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

            Service.AddSingleton<IValidator<CandidateAuthentication>, CandidateAuthenticationValidator>();
            Service.AddSingleton<IValidator<CandidateCertificate>, CandidateCertificateValidator>();
            Service.AddSingleton<IValidator<CandidateContact>, CandidateContactValidator>();
            Service.AddSingleton<IValidator<CandidateDetail>, CandidateDetailValidator>();
            Service.AddSingleton<IValidator<CandidateEducation>, CandidateEducationValidator>();
            Service.AddSingleton<IValidator<CandidateExperience>, CandidateExperienceValidator>();
            Service.AddSingleton<IValidator<CandidateLanguage>, CandidateLanguageValidator>();
            Service.AddSingleton<IValidator<CandidatePhoto>, CandidatePhotoValidator>();
            Service.AddSingleton<IValidator<CandidateReferance>, CandidateReferanceValidator>();
            Service.AddSingleton<IValidator<CandidateSettings>, CandidateSettingsValidator>();
            Service.AddSingleton<IValidator<CandidateSkills>, CandidateSkillsValidator>();
            Service.AddSingleton<IValidator<Candidate>, CandidateValidator>();
            Service.AddSingleton<IValidator<College>, CollegeValidator>();
            Service.AddSingleton<IValidator<Institution>, InstitutionValidator>();
            Service.AddSingleton<IValidator<JobPostingApply>, JobPostingApplyValidator>();
            Service.AddSingleton<IValidator<JobPostingDetail>, JobPostingDetailValidator>();
            Service.AddSingleton<IValidator<JobPosting>, JobPostingValidator>();
            Service.AddSingleton<IValidator<JobPostingVisit>, JobPostingVisitValidator>();
            Service.AddSingleton<IValidator<Language>, LanguageValidator>();
            Service.AddSingleton<IValidator<ManagerAuthentication>, ManagerAuthenticationValidator>();
            Service.AddSingleton<IValidator<ManagerDetail>, ManagerDetailValidator>();
            Service.AddSingleton<IValidator<ManagerSettings>, ManagerSettingsValidator>();
            Service.AddSingleton<IValidator<Manager>, ManagerValidator>();
            Service.AddSingleton<IValidator<Skills>, SkillsValidator>();
            Service.AddSingleton<IValidator<UserAuthentication>, UserAuthenticationValidator>();
            Service.AddSingleton<IValidator<UserDetail>, UserDetailValidator>();
            Service.AddSingleton<IValidator<UserSettings>, UserSettingsValidator>();
            Service.AddSingleton<IValidator<User>, UserValidator>();

            Service.AddScoped<ICandidateLoginService, CandidateLoginService>();
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
            Service.AddScoped<IUserLoginService, UserLoginService>();
            Service.AddScoped<IUserAuthenticationService, UserAuthenticationService>();
            Service.AddScoped<IUserDetailService, UserDetailService>();
            Service.AddScoped<IUserService, UserService>();
            Service.AddScoped<IUserSettingsService, UserSettingsService>();

            return Service;
        }
    }
}