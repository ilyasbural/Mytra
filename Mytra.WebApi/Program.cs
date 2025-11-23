using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Mytra.DataAccess;
using Mytra.Service;
using Mytra.Utilize;
using System;
using System.Text;

WebApplicationBuilder Builder = WebApplication.CreateBuilder(args);
IConfiguration Configuration = Builder.Configuration;

Builder.Services.AddControllers()
	.AddApplicationPart(typeof(Mytra.Presentation.AssemblyReferance).Assembly);

Builder.Services.AddEndpointsApiExplorer();
Builder.Services.AddAuthentication(options =>
{
	options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
	options.RequireHttpsMetadata = false;
	options.TokenValidationParameters = new TokenValidationParameters
	{
		ValidateIssuer = true,
		ValidateAudience = true,
		ValidateLifetime = true,
		ValidateIssuerSigningKey = true,
		ClockSkew = TimeSpan.Zero, // Token süresi dolduysa hemen reddedilsin
		ValidIssuer = Builder.Configuration["JwtTokenOptions:Issuer"],
		ValidAudience = Builder.Configuration["JwtTokenOptions:Audience"],
		IssuerSigningKey = new SymmetricSecurityKey(
			Encoding.UTF8.GetBytes(Builder.Configuration["JwtTokenOptions:Key"]))
	};
});
Builder.Services.AddSwaggerGen(x =>
{
	x.SwaggerDoc("v1", new() { Title = "Mytra API", Version = "v1" });
	//x.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
	//{
	//	Name = "Authorization",
	//	Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey,
	//	Scheme = "Bearer",
	//	BearerFormat = "JWT",
	//	In = Microsoft.OpenApi.Models.ParameterLocation.Header,
	//	Description = "JWT Authorization header using the Bearer scheme. Example: \"Bearer {your token}\""
	//});
	//x.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
	//{
	//	{
	//		new Microsoft.OpenApi.Models.OpenApiSecurityScheme
	//		{
	//			Reference = new Microsoft.OpenApi.Models.OpenApiReference
	//			{
	//				Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
	//				Id = "Bearer"
	//			}
	//		},
	//		Array.Empty<string>()
	//	}
	//});
});

Builder.Services.LoadServices();
Builder.Services.AddAutoMapper(Config => { }, typeof(CandidateAuthenticationMapper));
Builder.Services.AddCors(Options =>
	Options.AddDefaultPolicy(Builder =>
	{
		Builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
	}));

//Builder.Services.AddDbContext<MytraContext>(Options =>
//	Options.UseSqlServer(Configuration.GetConnectionString("ConnectionStrings")));

Builder.Services.AddDbContext<MytraContext>(options =>
	options.UseSqlServer(
		Configuration.GetConnectionString("ConnectionStrings"),
		b => b.MigrationsAssembly("Mytra")));

var App = Builder.Build();

if (App.Environment.IsDevelopment())
{
	App.MapOpenApi();
}

App.UseSwagger();
App.UseSwaggerUI();
App.UseHttpsRedirection();
App.UseRouting();
App.UseCors();
App.UseAuthentication();
App.UseAuthorization();
App.MapControllers();
App.Run();