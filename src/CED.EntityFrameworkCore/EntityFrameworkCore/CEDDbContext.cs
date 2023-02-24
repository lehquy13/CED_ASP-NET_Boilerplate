using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CED.Authorization.Roles;
using CED.Authorization.Users;
using CED.MultiTenancy;
using CED.Subjects;
using CED.ClassInformations;

namespace CED.EntityFrameworkCore
{
    public class CEDDbContext : AbpZeroDbContext<Tenant, Role, User, CEDDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<ClassInformation> ClassInformations { get; set; }
        public DbSet<AvailableDate> AvailableDates { get; set; }
        public CEDDbContext(DbContextOptions<CEDDbContext> options)
            : base(options)
        {
        }
    }
}
