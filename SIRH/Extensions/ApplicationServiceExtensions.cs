using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;

namespace SIRH.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddCors(option =>
            {
                option.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyHeader()
                    .AllowAnyMethod()
                    .WithExposedHeaders("WWW-Authenticate", "Pagination", "filename")
                    .WithOrigins("http://localhost:3000")
                    .AllowCredentials();
                });
            });

            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo
            //    {
            //        Title = "SIRH",
            //        Version = "v1",
            //        Description = "API .Net Core 3.1",
            //        Contact = new OpenApiContact
            //        {
            //            Name = "SIRH ATLATEL",
            //            Email = "sirh.atlatel@gmail.com",
            //        },
            //        License = new OpenApiLicense
            //        {
            //            Name = "ATLADEV",
            //            Url = new Uri("http://atladev.net/"),
            //        }
            //    });
            //    c.SchemaGeneratorOptions = new SchemaGeneratorOptions { SchemaIdSelector = type => type.FullName };
            //});

            services.AddMvc();
            //services.AddControllers(opt =>
            //{
            //    //Ajouter l'athentification security
            //    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
            //    opt.Filters.Add(new AuthorizeFilter(policy));
            //})
            //.AddFluentValidation(cfg => { cfg.RegisterValidatorsFromAssemblyContaining<Register>(); });

            //Scoped values
            //services.AddScoped<IUserAccessor, UserAccessor>();
            //services.AddScoped<IUserByRole, UserByRole>();
            //services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
            //services.AddScoped<IEmailSender, EmailSender>();
            //services.AddScoped<IProfilReader, ProfilReader>();
            //services.AddScoped<IPhotoAccessor, PhotoAccessor>();
            //services.AddScoped<IFileAccessor, FileAccessor>();

            return services;
        }

    }
}
