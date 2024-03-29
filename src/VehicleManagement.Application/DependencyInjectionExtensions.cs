﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace VehicleManagement.Application
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services) =>
            services.AddMediatR(typeof(DependencyInjectionExtensions).Assembly);
    }
}