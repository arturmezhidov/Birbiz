namespace Birbiz.Common.Entities.Catalog
{
    public class ProductAttributeRangeValue : BaseEntity
    {
        public int RangeValueId { get; set; }

        public int AttributeSchemaId { get; set; }

        public virtual RangeValue RangeValue { get; set; }

        public virtual ProductAttributeSchema AttributeSchema { get; set; }
    }
}