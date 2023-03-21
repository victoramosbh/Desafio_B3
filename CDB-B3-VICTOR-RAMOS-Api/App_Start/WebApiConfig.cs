﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CDB_B3_VICTOR_RAMOS_Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            
            config.MapHttpAttributeRoutes();            

            config.Routes.MapHttpRoute(
                name: "InvestimentosApi",
                routeTemplate: "api/investimentos/calcularcdb/{valor}/{meses}",
                defaults: new { controller = "investimentos" }
            );


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //força a resposta como JSON
            var formatters = GlobalConfiguration.Configuration.Formatters;
            formatters.Remove(formatters.XmlFormatter);
        }
    }
}
