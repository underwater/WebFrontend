﻿using Microsoft.Extensions.Configuration;

namespace CodingMilitia.PlayBall.WebFrontend.BackForFront.Web.Configuration
{
    public static class ConfigurationExtensions
    {
        public static T GetSection<T>(this IConfiguration configuration, string key)
            => configuration.GetSection(key).Get<T>();
        
    }
}
