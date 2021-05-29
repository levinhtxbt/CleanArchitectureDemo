using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CleanArchitectureDemo.Application.Common.Interfaces;
using Microsoft.AspNetCore.Http;

namespace CleanArchitectureDemo.WebUI.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            IsAuthenticated = UserId != null;
        }

        public string UserId { get; }

        public bool IsAuthenticated { get; }
    }
}
