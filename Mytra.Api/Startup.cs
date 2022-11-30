namespace Mytra.Api
{
    using Core;
    using Business;

    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection Service)
        {
            var tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
            
            Service.AddControllers().AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null);
            Service.AddControllersWithViews();
            Service.LoadMyServices();
            Service.AddAutoMapper(typeof(Startup));
            Service.Configure<TokenOptions>(Configuration.GetSection("TokenOptions"));
            //Service.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(jwtbeareroptions =>
            //{
            //    jwtbeareroptions.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
            //    {
            //        ValidateAudience = true,
            //        ValidateIssuer = true,
            //        ValidateLifetime = true,
            //        ValidateIssuerSigningKey = true,
            //        ValidIssuer = tokenOptions.Issuer,
            //        ValidAudience = tokenOptions.Audience,
            //        IssuerSigningKey = SignHandler.GetSecurityKey(tokenOptions.SecurityKey)
            //    };
            //});
            Service.AddCors(c => {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseCors(options => options.AllowAnyOrigin());
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}