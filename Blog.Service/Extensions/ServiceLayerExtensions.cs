
using Blog.Service.FluentValidation;
using Blog.Service.Helpers.Abstraction.Images;
using Blog.Service.Helpers.Concretes.Images;
using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Concretes;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using NToastNotify;
using System.Globalization;
using System.Reflection;




namespace Blog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDashboardService, DashboardService>();
            services.AddScoped<IImageHelper, ImageHelper>();
            services.AddAutoMapper(assembly);
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            services.AddFluentValidation(opt =>
               {
                   opt.RegisterValidatorsFromAssemblyContaining<ArticleValidator>();
                   opt.DisableDataAnnotationsValidation = true;
                   opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
               });

            services.AddControllersWithViews()
            .AddNToastNotifyToastr(new ToastrOptions
            {
                ProgressBar = true,
                PositionClass = ToastPositions.TopRight,
                PreventDuplicates = true,
                CloseButton = true
            });

            return services;
        }
    }
}
