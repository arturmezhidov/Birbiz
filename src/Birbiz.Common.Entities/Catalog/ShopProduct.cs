namespace Birbiz.Common.Entities.Catalog
{
    public class ShopProduct : BaseEntity
    {
        public int Count { get; set; }

        public decimal Price { get; set; }

        public virtual Discount Discount { get; set; }

        public virtual Product Product { get; set; }

        public virtual Shop Shop { get; set; }
    }
}