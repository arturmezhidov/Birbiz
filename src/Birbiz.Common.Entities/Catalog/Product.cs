using System.Collections.Generic;

namespace Birbiz.Common.Entities.Catalog
{
    public class Product : BaseEntity
    {
        public string DisplayName { get; set; }

        public string HelpInfo { get; set; }

        public string HtmlContent { get; set; }

        public virtual Company Manufacture { get; set; }

        public virtual Country Country { get; set; }

        public virtual ProductSchema Schema { get; set; }

        public virtual ICollection<ProductAttribute> Attributes { get; set; } = new HashSet<ProductAttribute>();

        public virtual ICollection<ShopProduct> ShopProducts { get; set; } = new HashSet<ShopProduct>();

        public virtual ICollection<ProductOrder> Orders { get; set; } = new HashSet<ProductOrder>();
    }
}