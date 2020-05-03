using System.ComponentModel.DataAnnotations;

namespace Ef6Audit
{
    public class Audit_Blog
    {
        public int Id { get; set; }
        
        public int BlogId { get; set; }

        [MaxLength(10)]
        public string Name { get; set; }
        
    }
}