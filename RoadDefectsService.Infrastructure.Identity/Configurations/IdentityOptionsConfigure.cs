﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace RoadDefectsService.Infrastructure.Identity.Configurations
{
    public class IdentityOptionsConfigure : IConfigureOptions<IdentityOptions>
    {
        public void Configure(IdentityOptions options)
        {
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireUppercase = true;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequiredLength = 6;
            options.Password.RequiredUniqueChars = 0;

            options.User.RequireUniqueEmail = true;
        }
    }
}
