using EPiServer.Cms.Shell;
using EPiServer.Cms.UI.AspNetIdentity;
using EPiServer.ContentApi.Core.Configuration;
using EPiServer.Scheduler;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Routing;

namespace Backend;

public class Startup
{
    private readonly IWebHostEnvironment _webHostingEnvironment;

    public Startup(IWebHostEnvironment webHostingEnvironment)
    {
        _webHostingEnvironment = webHostingEnvironment;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        if (_webHostingEnvironment.IsDevelopment())
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(_webHostingEnvironment.ContentRootPath, "App_Data"));

            services.Configure<SchedulerOptions>(options => options.Enabled = false);
        }

        services
            .AddCmsAspNetIdentity<ApplicationUser>()
            .AddCms()
            .AddAdminUserRegistration()
            .AddEmbeddedLocalization<Startup>();

        services.AddContentDeliveryApi(options =>
        {
            options.SiteDefinitionApiEnabled = true;
        });
        //services.Configure<ContentApiOptions>(options =>
        //{
        //    options.EnableAnonymousAccess = true; // Allow public API access
        //});


        //services.AddContentSearchApi(options =>
        //{
        //    options.MaximumSearchResults = 10;
        //});

        //services.ConfigureContentApiOptions(o => {
        //    o.HttpResponseExpireTime = TimeSpan.FromSeconds(1);
        //});

        services.AddCors(options =>
        {
            options.AddPolicy("AllowAll",
                builder =>
                {
                    builder.AllowAnyOrigin()
                           .WithExposedContentDeliveryApiHeaders()
                           .AllowAnyMethod()
                           .AllowAnyHeader();

                });
        });

        services.Configure<UIOptions>(uiOptions =>
        {
            uiOptions.UsePreviewTokens = true;
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseStaticFiles();
        app.UseRouting();
        app.UseCors("AllowAll");
        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapContent();
        });
    }
}
