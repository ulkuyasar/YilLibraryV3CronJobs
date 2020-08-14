using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BackGroudService.ServiceAdapters.SensorTransactionServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;

namespace BackGroudService
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			services.AddSingleton<ISensorTransactionCheckService, SensorTransactionCheckAdapter>();
			services.AddHostedService<YilCronHostedService>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{

			Core.Utilities.DefaultValues.DefaultValue.IsDevelopmetEnvironment = false;
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				Core.Utilities.DefaultValues.DefaultValue.IsDevelopmetEnvironment = true;
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
			yilSetAppSettingValues();

		}

		private void yilSetAppSettingValues()
		{
			JToken jAppSettings = null;
			if (Core.Utilities.DefaultValues.DefaultValue.IsDevelopmetEnvironment)
				jAppSettings = JToken.Parse(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "appsettings.Development.json")));
			else
				jAppSettings = JToken.Parse(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "appsettings.json")));

			DefaultValues.Defaults.WebApiUrl = jAppSettings["Urls"].SelectToken("WebApiUrl").ToString();
		}
	}
}
