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

            Service.AddScoped<IValidator<Announce>, AnnounceValidator>();
            Service.AddScoped<IValidator<AnnounceDetail>, AnnounceDetailValidator>();
            Service.AddScoped<IValidator<Category>, CategoryValidator>();
            Service.AddScoped<IValidator<ContentComment>, ContentCommentValidator>();
            Service.AddScoped<IValidator<ContentDetail>, ContentDetailValidator>();
            Service.AddScoped<IValidator<ContentLike>, ContentLikeValidator>();
            Service.AddScoped<IValidator<ContentPicture>, ContentPictureValidator>();
            Service.AddScoped<IValidator<ContentSettings>, ContentSettingsValidator>();
            Service.AddScoped<IValidator<ContentType>, ContentTypeValidator>();
            Service.AddScoped<IValidator<Content>, ContentValidator>();
            Service.AddScoped<IValidator<ManagementContact>, ManagementContactValidator>();
            Service.AddScoped<IValidator<ManagementDetail>, ManagementDetailValidator>();
            Service.AddScoped<IValidator<ManagementSettings>, ManagementSettingsValidator>();
            Service.AddScoped<IValidator<Management>, ManagementValidator>();
            Service.AddScoped<IValidator<Permission>, PermissionValidator>();
            Service.AddScoped<IValidator<PermissionDetail>, PermissionDetailValidator>();
            Service.AddScoped<IValidator<Survey>, SurveyValidator>();
            Service.AddScoped<IValidator<SurveyDetail>, SurveyDetailValidator>();
            Service.AddScoped<IValidator<UserContact>, UserContactValidator>();
            Service.AddScoped<IValidator<UserDetail>, UserDetailValidator>();
            Service.AddScoped<IValidator<UserEmail>, UserEmailValidator>();
            Service.AddScoped<IValidator<UserSettings>, UserSettingsValidator>();
            Service.AddScoped<IValidator<User>, UserValidator>();

            Service.AddScoped<IAnnounceService, AnnounceManager>();
            Service.AddScoped<IAnnounceDetailService, AnnounceDetailManager>();
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
            Service.AddScoped<ISurveyService, SurveyManager>();
            Service.AddScoped<ISurveyDetailService, SurveyDetailManager>();
            Service.AddScoped<IUserService, UserManager>();
            Service.AddScoped<IUserDetailService, UserDetailManager>();
            Service.AddScoped<IUserContactService, UserContactManager>();
            Service.AddScoped<IUserEmailService, UserEmailManager>();
            Service.AddScoped<IUserSettingsService, UserSettingsManager>();

            return Service;
        }
    }
}