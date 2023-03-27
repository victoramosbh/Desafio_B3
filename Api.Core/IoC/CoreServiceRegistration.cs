﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;
using Api.Core.Business.Cdb.Calcular;
using AutoMapper;

namespace Api.Core.IoC
{
    public static class CoreServiceRegistration
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());            
            services.AddTransient<InvestimentoDtoValidator>();            
            return services;
        }
    }
}
