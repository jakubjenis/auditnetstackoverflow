using System;
using System.Threading.Tasks;
using Audit.Core;

namespace Ef6Audit
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Audit.Core.Configuration.Setup()
                .UseEntityFramework(ef => ef
                    .AuditTypeExplicitMapper(m => m
                        .Map<Blog, Audit_Blog>((source, audit) => { audit.BlogId = source.Id; })
                    )
                );

            using (var context = new MyContext("Server=.;Database=test2;Trusted_Connection=True;"))
            {
                context.Blogs.Add(new Blog
                {
                    Name = "123456789123456789"
                });

                await context.SaveChangesAsync();
            }
        }
    }
}