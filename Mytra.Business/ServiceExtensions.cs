namespace Mytra.Business
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

            Service.AddScoped<IAnnounceRepository, AnnounceRepositoryEF>();
            Service.AddScoped<IAnnounceDetailRepository, AnnounceDetailRepositoryEF>();
            Service.AddScoped<ICategoryRepository, CategoryRepositoryEF>();
            Service.AddScoped<IContentRepository, ContentRepositoryEF>();
            Service.AddScoped<IContentCommentRepository, ContentCommentRepositoryEF>();
            Service.AddScoped<IContentDetailRepository, ContentDetailRepositoryEF>();
            Service.AddScoped<IContentLikeRepository, ContentLikeRepositoryEF>();
            Service.AddScoped<IContentPictureRepository, ContentPictureRepositoryEF>();
            Service.AddScoped<IContentSettingsRepository, ContentSettingsRepositoryEF>();
            Service.AddScoped<IContentTypeRepository, ContentTypeRepositoryEF>();
            Service.AddScoped<IManagementRepository, ManagementRepositoryEF>();
            Service.AddScoped<IManagementDetailRepository, ManagementDetailRepositoryEF>();
            Service.AddScoped<IManagementContactRepository, ManagementContactRepositoryEF>();
            Service.AddScoped<IManagementSettingsRepository, ManagementSettingsRepositoryEF>();
            Service.AddScoped<IPermissionRepository, PermissionRepositoryEF>();
            Service.AddScoped<IPermissionDetailRepository, PermissionDetailRepositoryEF>();
            Service.AddScoped<ISurveyRepository, SurveyRepositoryEF>();
            Service.AddScoped<ISurveyDetailRepository, SurveyDetailRepositoryEF>();
            Service.AddScoped<IUserRepository, UserRepositoryEF>();
            Service.AddScoped<IUserDetailRepository, UserDetailRepositoryEF>();
            Service.AddScoped<IUserContactRepository, UserContactRepositoryEF>();
            Service.AddScoped<IUserEmailRepository, UserEmailRepositoryEF>();
            Service.AddScoped<IUserSettingsRepository, UserSettingsRepositoryEF>();
            Service.AddScoped<IUnitOfWork, UnitOfWork>();

            Service.AddSingleton<IValidator<Announce>, AnnounceValidator>();
            Service.AddSingleton<IValidator<AnnounceDetail>, AnnounceDetailValidator>();
            Service.AddSingleton<IValidator<Category>, CategoryValidator>();
            Service.AddSingleton<IValidator<ContentComment>, ContentCommentValidator>();
            Service.AddSingleton<IValidator<ContentDetail>, ContentDetailValidator>();
            Service.AddSingleton<IValidator<ContentLike>, ContentLikeValidator>();
            Service.AddSingleton<IValidator<ContentPicture>, ContentPictureValidator>();
            Service.AddSingleton<IValidator<ContentSettings>, ContentSettingsValidator>();
            Service.AddSingleton<IValidator<ContentType>, ContentTypeValidator>();
            Service.AddSingleton<IValidator<Content>, ContentValidator>();
            Service.AddSingleton<IValidator<ManagementContact>, ManagementContactValidator>();
            Service.AddSingleton<IValidator<ManagementDetail>, ManagementDetailValidator>();
            Service.AddSingleton<IValidator<ManagementSettings>, ManagementSettingsValidator>();
            Service.AddSingleton<IValidator<Management>, ManagementValidator>();
            Service.AddSingleton<IValidator<Permission>, PermissionValidator>();
            Service.AddSingleton<IValidator<PermissionDetail>, PermissionDetailValidator>();
            Service.AddSingleton<IValidator<Survey>, SurveyValidator>();
            Service.AddSingleton<IValidator<SurveyDetail>, SurveyDetailValidator>();
            Service.AddSingleton<IValidator<UserContact>, UserContactValidator>();
            Service.AddSingleton<IValidator<UserDetail>, UserDetailValidator>();
            Service.AddSingleton<IValidator<UserEmail>, UserEmailValidator>();
            Service.AddSingleton<IValidator<UserSettings>, UserSettingsValidator>();
            Service.AddSingleton<IValidator<User>, UserValidator>();

            Service.AddScoped<IAnnounceService, AnnounceManager>();
            Service.AddScoped<IAnnounceDetailService, AnnounceDetailManager>();
            Service.AddScoped<IAuthenticationService, AuthenticationManager>();
            Service.AddScoped<ICategoryService, CategoryManager>();
            Service.AddScoped<IContentService, ContentManager>();
            Service.AddScoped<IContentDetailService, ContentDetailManager>();
            Service.AddScoped<IContentCommentService, ContentCommentManager>();
            Service.AddScoped<IContentLikeService, ContentLikeManager>();
            Service.AddScoped<IContentPictureService, ContentPictureManager>();
            Service.AddScoped<IContentSettingsService, ContentSettingsManager>();
            Service.AddScoped<IContentTypeService, ContentTypeManager>();
            Service.AddScoped<IManagementService, ManagementManager>();
            Service.AddScoped<IManagementDetailService, ManagementDetailManager>();
            Service.AddScoped<IManagementContactService, ManagementContactManager>();
            Service.AddScoped<IManagementSettingsService, ManagementSettingsManager>();
            Service.AddScoped<IPermissionService, PermissionManager>();
            Service.AddScoped<IPermissionDetailService, PermissionDetailManager>();
            Service.AddScoped<ISurveyDetailService, SurveyDetailManager>();
            Service.AddScoped<ISurveyService, SurveyManager>();
            Service.AddScoped<ITokenHandlerService, TokenHandlerManager>();
            Service.AddScoped<IUserService, UserManager>();
            Service.AddScoped<IUserDetailService, UserDetailManager>();
            Service.AddScoped<IUserContactService, UserContactManager>();
            Service.AddScoped<IUserEmailService, UserEmailManager>();
            Service.AddScoped<IUserSettingsService, UserSettingsManager>();

            return Service;
        }
    }
}