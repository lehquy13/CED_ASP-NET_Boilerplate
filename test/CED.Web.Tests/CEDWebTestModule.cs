﻿using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CED.EntityFrameworkCore;
using CED.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace CED.Web.Tests
{
    [DependsOn(
        typeof(CEDWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class CEDWebTestModule : AbpModule
    {
        public CEDWebTestModule(CEDEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CEDWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(CEDWebMvcModule).Assembly);
        }
    }
}