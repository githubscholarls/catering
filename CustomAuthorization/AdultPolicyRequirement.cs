using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace catering.CustomAuthorization
{
    public class AdultPolicyRequirement:IAuthorizationRequirement
    {
        public int Age { get; }
        public AdultPolicyRequirement(int age)
        {
            this.Age = age;
        }
    }
    public class AdultAuthorizationHandler :AuthorizationHandler<AdultPolicyRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AdultPolicyRequirement requirement)
        {
            //获取当前http请求的context对象
            var mvcContext = context.Resource as AuthorizationFilterContext;
            if (mvcContext == null)
            {
                context.Succeed(requirement);
                return Task.CompletedTask;
            }

            //对于没带claim的重定向到登录页面（每个用户都应该有claim）
            var claim = context.User.FindFirst(c => c.Type == ClaimTypes.DateOfBirth);
            if (claim == null)
            {
                mvcContext.Result = new RedirectResult("/Account/Login");
                return Task.CompletedTask;
            }
            
            var dateOfBirth = Convert.ToDateTime(claim.Value);
            var age = DateTime.Now.Year - dateOfBirth.Year;
            if (age < requirement.Age)
            {
                context.Fail();
            }
            else
            {
                //通过验证，这句代码必须要有
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
    }
