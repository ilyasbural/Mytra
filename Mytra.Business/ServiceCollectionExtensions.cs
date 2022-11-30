namespace Mytra.Business
{
    using Core;
    using DataAccess;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection Service)
        {
            Service.AddDbContext<MytraContext>();

            //Service.AddScoped<IAnnounceRepository, AnnounceRepositoryEF>();
            Service.AddScoped<IAnnounceDetailRepository, AnnounceDetailRepositoryEF>();
            //Service.AddScoped<ICategoryRepository, CategoryRepositoryEF>();
            //Service.AddScoped<IContentRepository, ContentRepositoryEF>();
            //Service.AddScoped<IContentCommentRepository, ContentCommentRepositoryEF>();
            //Service.AddScoped<IContentDetailRepository, ContentDetailRepositoryEF>();
            //Service.AddScoped<IContentLikeRepository, ContentLikeRepositoryEF>();
            //Service.AddScoped<IContentPictureRepository, ContentPictureRepositoryEF>();
            //Service.AddScoped<IContentSettingsRepository, ContentSettingsRepositoryEF>();
            //Service.AddScoped<IContentTypeRepository, ContentTypeRepositoryEF>();
            //Service.AddScoped<IManagementRepository, ManagementRepositoryEF>();
            //Service.AddScoped<IManagementDetailRepository, ManagementDetailRepositoryEF>();
            //Service.AddScoped<IManagementContactRepository, ManagementContactRepositoryEF>();
            //Service.AddScoped<IManagementSettingsRepository, ManagementSettingsRepositoryEF>();
            //Service.AddScoped<IPermissionRepository, PermissionRepositoryEF>();
            //Service.AddScoped<IPermissionDetailRepository, PermissionDetailRepositoryEF>();
            //Service.AddScoped<ISurveyRepository, SurveyRepositoryEF>();
            //Service.AddScoped<ISurveyDetailRepository, SurveyDetailRepositoryEF>();
            //Service.AddScoped<IUserRepository, UserRepositoryEF>();
            //Service.AddScoped<IUserDetailRepository, UserDetailRepositoryEF>();
            //Service.AddScoped<IUserContactRepository, UserContactRepositoryEF>();
            //Service.AddScoped<IUserEmailRepository, UserEmailRepositoryEF>();
            //Service.AddScoped<IUserSettingsRepository, UserSettingsRepositoryEF>();
            Service.AddScoped<IUnitOfWork, UnitOfWork>();

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