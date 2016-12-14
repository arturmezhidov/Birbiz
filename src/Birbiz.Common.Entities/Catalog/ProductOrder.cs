namespace Birbiz.Common.Entities.Catalog
{
    public class ProductOrder : BaseEntity
    {
        public int Count { get; set; }

        public virtual Product Product { get; set; }

        public virtual Shop Shop { get; set; }

        public virtual ProfileUser ProfileUser { get; set; }
    }
}