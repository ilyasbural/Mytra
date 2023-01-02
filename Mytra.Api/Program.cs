using Mytra.Api;

namespace Mytra.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}



//using FluentValidation.AspNetCore;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.Extensions.Configuration;
//using Mytra.Business;
//using Mytra.Core;

//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddControllers().AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null);
//builder.Services.LoadServices();
//builder.Services.AddAutoMapper(typeof(AnnounceMapper));

//var tokenOptions = builder.Configuration.GetValue<TokenOptions>("TokenOptions");

// or using the index property (which always returns a string)
//var configValue = builder.Configuration["Authentication:CookieAuthentication:LoginPath"];


//builder.Services.Configure<TokenOptions>(Configuration.GetSection("TokenOptions"));
//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(jwtbeareroptions =>
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

//builder.Services.AddCors(c => {
//    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
//});

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}


//app.UseAuthentication();
//app.UseStaticFiles();
//app.UseRouting();
//app.UseAuthorization();
//app.UseCors(options => options.AllowAnyOrigin());
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//        name: "default",
//        pattern: "{controller=Home}/{action=Index}/{id?}");
//});
//app.UseHttpsRedirection();
//app.MapControllers();
//app.Run();