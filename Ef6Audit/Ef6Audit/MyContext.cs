using System;
using System.Data.Entity;
using Audit.Core;
using Audit.EntityFramework;

namespace Ef6Audit
{
    public class MyContext : AuditDbContext
    {
        public MyContext(string connectionString): base(connectionString)
        {
        }
        
        public DbSet<Audit_Blog> Audit_Blogs { get; set; }
        
        public DbSet<Blog> Blogs { get; set; }
    }
}