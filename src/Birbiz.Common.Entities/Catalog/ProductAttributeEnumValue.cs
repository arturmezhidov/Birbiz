namespace Birbiz.Common.Entities.Catalog
{
    public class ProductAttributeEnumValue
    {
        public int EnumValueId { get; set; }

        public virtual EnumValue EnumValue { get; set; }

        public virtual ProductAttributeSchema AttributeSchema { get; set; }
    }
}