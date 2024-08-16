
namespace Login_Logout_SignUp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    public partial class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext()
            :base("name=SECURITY_DBEntities")
            {
            }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<RoleMaster> RoleMasters { get; set; }
        public virtual DbSet<UserRolesMapping> UserRolesMappings { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}