namespace Birbiz.Common.Entities.Catalog
{
    public class ProductAttributeRangeValue
    {
        public virtual RangeValue RangeValue { get; set; }

        public virtual ProductAttributeSchema AttributeSchema { get; set; }
    }
}