using System;

namespace Birbiz.Common.Entities.Catalog
{
    public class Discount : BaseEntity
    {
        public double Value { get; set; }

        public bool IsPresent { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int ShopProductId { get; set; }

        public virtual ShopProduct ShopProduct { get; set; }
    }
}