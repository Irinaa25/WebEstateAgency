using AutoMapper;

using Business.Repositories;
using Business.Repositories.DataRepositories;
using Business.Services;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Repository;
using Repository.Data;
using Repository.Repositories;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace WebApplicationAgency
{
    public class Startup
    {
		private readonly IWebHostEnvironment _environment;

		private readonly IConfigurationRoot _configuration;

		public Startup(Microsoft.Extensions.Configuration.IConfiguration configuration, IWebHostEnvironment environment)
		{
			Configuration = configuration;
			_environment = environment;
			var builder = new ConfigurationBuilder()
				.SetBasePath(_environment.ContentRootPath)
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
				.AddJsonFile($"appsettings.{_environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
				.AddEnvironmentVariables();
			_configuration = builder.Build();
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			#region common 
			services.AddSingleton<IConfiguration>(_configuration);

			services.AddDbContext<Context>(
				options => options
					.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")),
				contextLifetime: ServiceLifetime.Singleton,
				optionsLifetime: ServiceLifetime.Transient);

			services.AddScoped<IClientRepository, ClientRepository>();
			services.AddScoped<IEstateRepository, EstateRepository>();
			services.AddScoped<IRealtorRepository, RealtorRepository>();
			services.AddScoped<IDealRepository, DealRepository>();
			services.AddScoped<IEstateTypeRepository, EstateTypeRepository>();
			services.AddScoped<IStreetRepository, StreetRepository>();
			services.AddScoped<IDistrictRepository, DistrictRepository>();
			services.AddScoped<ITownRepository, TownRepository>();


			var mappingConfig = new MapperConfiguration(mc =>
			{
				mc.AddProfile(new ServiceMappingProfile());
			});

			IMapper mapper = mappingConfig.CreateMapper();
			services.AddSingleton(mapper);

			services.AddControllersWithViews();
			#endregion

			services.AddScoped<IEstateService, EstateService>();
			services.AddScoped<IRealtorService, RealtorService>();
			services.AddScoped<IClientService, ClientService>();
			services.AddScoped<IDealService, DealService>();
			services.AddScoped<IEstateTypeService, EstateTypeService>();
			services.AddScoped<IStreetService, StreetService>();
			services.AddScoped<IDistrictService, DistrictService>();
			services.AddScoped<ITownService, TownService>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
