using System.Collections.Generic;

namespace Birbiz.Common.Entities.Catalog
{
    public class Shop : BaseEntity
    {
        public string Name { get; set; }

        public virtual Currency Currency { get; set; }

        public virtual Flat Address { get; set; }

        public virtual ProfileUser ProfileUser { get; set; }

        public virtual ICollection<ProductOrder> Orders { get; set; } = new HashSet<ProductOrder>();

        public virtual ICollection<ShopProduct> Products { get; set; } = new HashSet<ShopProduct>();
    }
}