﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileTime.BAL;
using FileTime.DAO.Common;
using FileTime.DapperDAL;
using FileTime.EFM;
using FileTime.IBAL;
using FileTime.IDAL;
using FileTime.IEFM;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FileTime.GrpcService
{
	public class Startup
	{

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddGrpc();
			MappingModule(services);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapGrpcService<GreeterService>();
				endpoints.MapGrpcService<FilerService>();

				endpoints.MapGet("/", async context =>
				{
					await context.Response.WriteAsync("Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
				});
			});
		}


		private void MappingModule(IServiceCollection services)
		{
			services.Configure<AppSettings>(options => Configuration.GetSection("AppSettings").Bind(options));
			services.Configure<ConnectionStrings>(options => Configuration.GetSection("ConnectionStrings").Bind(options));

			services.AddScoped<IFilerDAL, FilerDAL>();
			services.AddScoped<IUserServiceWrapper, UserServiceWrapper>();
			services.AddScoped<IFilerBAL, FilerBAL>();
			
		}

	}
}
