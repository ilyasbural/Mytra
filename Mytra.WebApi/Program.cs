using Mytra.Service;
using Mytra.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;

WebApplicationBuilder Builder = WebApplication.CreateBuilder(args);
IConfiguration Configuration = Builder.Configuration;

Builder.Services.AddControllers().AddApplicationPart(typeof(Mytra.Presentation.AssemblyReferance).Assembly);
Builder.Services.AddEndpointsApiExplorer();
Builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(Option =>
{
	Option.RequireHttpsMetadata = false;
	Option.TokenValidationParameters = new TokenValidationParameters()
    {
        //ValidIssuer = JwtSettings.ValidIssuer,
        //ValidAudience = JwtSettings.ValidAudience,
        ClockSkew = TimeSpan.Zero,
        ValidateIssuerSigningKey = true,
        ValidateLifetime = true,
        //IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtSettings.SigningCredentials))
    };
});
Builder.Services.AddOpenApi();
Builder.Services.AddSwaggerGen(x =>
{
    x.SwaggerDoc("v1", new() { Title = "Mytra API", Version = "v1" });
    x.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme."
    });
    x.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference
                {
                    Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});
Builder.Services.LoadServices();
Builder.Services.AddAutoMapper(cfg => { }, typeof(CandidateAuthenticationMapper));
Builder.Services.AddCors(options => options.AddDefaultPolicy(builder => { builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); }));
Builder.Services.AddDbContext<MytraContext>(options =>
	options.UseSqlServer(Configuration.GetConnectionString("ConnectionStrings")));

var App = Builder.Build();

if (App.Environment.IsDevelopment())
{
	App.MapOpenApi();
}

App.UseSwagger();
App.UseSwaggerUI();
App.UseHttpsRedirection();
App.UseAuthentication();
App.UseAuthorization();
App.MapControllers();
App.UseCors();
App.Run();