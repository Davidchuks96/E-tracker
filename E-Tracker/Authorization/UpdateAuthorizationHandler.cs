﻿using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace E_Tracker.Authorization
{
    public class UpdateAuthorizationHandler : AuthorizationHandler<AccountAuthorizationRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AccountAuthorizationRequirement requirement)
        {
            if (context.User == null) return Task.CompletedTask;
            if (context.User.HasClaim(CustomClaims.Permission, CustomClaimsValues.Update)) context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}
