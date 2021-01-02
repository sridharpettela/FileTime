using FileTime.EFMApi.App_Start;
using FileTime.Log.Handler;
using Microsoft.Web.Http;
using Microsoft.Web.Http.Versioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace FileTime.EFMApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.AddApiVersioning(o =>
            {
                o.ReportApiVersions = true;
                o.AssumeDefaultVersionWhenUnspecified = true;
                o.DefaultApiVersion = new ApiVersion(2, 0);
                o.ApiVersionReader = new HeaderApiVersionReader("version");
                o.ApiVersionSelector = new CurrentImplementationApiVersionSelector(o);
            }
          );
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            // Web API configuration and services
            config.Filters.Add(new CustomExceptionFilter());
            config.Services.Replace(typeof(IExceptionHandler), new GlobalExceptionHandler());
            //Registering UnhandledExceptionLogger
            config.Services.Replace(typeof(IExceptionLogger), new UnhandledExceptionLogger());

            //Registering RequestResponseHandler
            //config.MessageHandlers.Add(new RequestResponseHandler());


            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}
