using System.ComponentModel.DataAnnotations;

namespace Ef6Audit
{
    public class Blog
    {
        public int Id { get; set; }

        [MaxLength(10)]
        public string Name { get; set; }
    }
}