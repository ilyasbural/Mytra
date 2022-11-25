namespace Mytra.Business
{
    using Core;
    using DataAccess;
    using FluentValidation;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection Service)
        {
            Service.AddDbContext<MytraContext>();

            Service.AddScoped<IAnnounce, AnnounceRepositoryEF>();
            Service.AddScoped<IAnnounceDetail, AnnounceDetailRepositoryEF>();
            Service.AddScoped<ICategory, CategoryRepositoryEF>();
            Service.AddScoped<IContent, ContentRepositoryEF>();
            Service.AddScoped<IContentComment, ContentCommentRepositoryEF>();
            Service.AddScoped<IContentDetail, ContentDetailRepositoryEF>();
            Service.AddScoped<IContentLike, ContentLikeRepositoryEF>();
            Service.AddScoped<IContentPicture, ContentPictureRepositoryEF>();
            Service.AddScoped<IContentSettings, ContentSettingsRepositoryEF>();
            Service.AddScoped<IContentType, ContentTypeRepositoryEF>();
            Service.AddScoped<IManagement, ManagementRepositoryEF>();
            Service.AddScoped<IManagementDetail, ManagementDetailRepositoryEF>();
            Service.AddScoped<IManagementContact, ManagementContactRepositoryEF>();
            Service.AddScoped<IManagementSettings, ManagementSettingsRepositoryEF>();
            Service.AddScoped<IPermission, PermissionRepositoryEF>();
            Service.AddScoped<IPermissionDetail, PermissionDetailRepositoryEF>();
            Service.AddScoped<ISurvey, SurveyRepositoryEF>();
            Service.AddScoped<IUser, UserRepositoryEF>();
            Service.AddScoped<IUserDetail, UserDetailRepositoryEF>();
            Service.AddScoped<IUserContact, UserContactRepositoryEF>();
            Service.AddScoped<IUserEmail, UserEmailRepositoryEF>();
            Service.AddScoped<IUserSettings, UserSettingsRepositoryEF>();

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
            Service.AddScoped<ISurveyService, SurveyManager>();
            Service.AddScoped<IUserService, UserManager>();
            Service.AddScoped<IUserDetailService, UserDetailManager>();
            Service.AddScoped<IUserSettingsService, UserSettingsManager>();

            return Service;
        }
    }
}