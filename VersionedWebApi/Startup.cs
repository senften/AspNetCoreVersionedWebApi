﻿using System.Xml.XPath;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SwashbuckleAspNetVersioningShim;

namespace VersionedWebApi
{
	public class Startup
	{
		public Startup()
		{
		}

		public IConfigurationRoot Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			// Add framework services.
			var mvcBuilder = services.AddMvc();
            services.AddMvcCore().AddVersionedApiExplorer();

			// Adds versioning capabilities, defaulting to version 1.0 calls if available
			services.AddApiVersioning(o =>
			{
				o.AssumeDefaultVersionWhenUnspecified = true;
				o.DefaultApiVersion = new ApiVersion(1, 0);
			});

			// Add generated documentation
			services.AddSwaggerGen(c =>
			{
                var provider = services.BuildServiceProvider().GetRequiredService<IApiVersionDescriptionProvider>();
				SwaggerVersioner.ConfigureSwaggerVersions(c, provider);
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, ApplicationPartManager partManager, IApiVersionDescriptionProvider provider)
		{
			// Generate swagger.json
			app.UseSwagger();

			// Let's enable SwaggerUI
			app.UseSwaggerUI(c =>
			{
				SwaggerVersioner.ConfigureSwaggerVersions(c, provider);
			});

			app.UseMvc();
		}
	}
}
