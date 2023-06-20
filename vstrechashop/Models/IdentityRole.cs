using Microsoft.EntityFrameworkCore.Metadata;

namespace vstrechashop.Models
{
    public class IdentityRole
    {
        public virtual IKey Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string NormalizedName { get; set; }
        public virtual string ConcurrencyStamp { get; set; }
    }
}
