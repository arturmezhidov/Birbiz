﻿namespace Birbiz.Common.Entities.Catalog
{
    public class ProductAttribute : BaseEntity
    {
        public string Value { get; set; }

        public int? ProductId { get; set; }

        public int SchemaId { get; set; }

        public virtual Product Product { get; set; }

        public virtual ProductAttributeSchema Schema { get; set; }
    }
}