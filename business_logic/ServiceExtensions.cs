using AutoMapper;
using business_logic.Interfaces;
using business_logic.Profiles;
using business_logic.Services;
using data_access.data.Entities;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic
{
    public static class ServiceExtensions
    {
        public static void AutoMapper(this IServiceCollection services)
        {
            services.AddSingleton(provider => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ReviewProfile());
                cfg.AddProfile(new CategoryProfile());
                cfg.AddProfile(new EditionProfile(provider.CreateScope().ServiceProvider.GetService<IFileService>()!));
            }).CreateMapper());
        }

        public static void AddFluentValidators(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
        }
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IEditionsService, EditionsService>();
            services.AddScoped<IAccountsService, AccountsService>();
            services.AddScoped<IFileService, LocalFileService>();
            services.AddScoped<IEmailSender, MailJetSender>();
            services.AddScoped<IReviewService, ReviewsService>();
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
