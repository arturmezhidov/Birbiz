namespace Birbiz.Common.Entities.Catalog
{
    public class ProductAttributeEnumValue : BaseEntity
    {
        public int EnumValueId { get; set; }

        public int AttributeSchemaId { get; set; }

        public virtual EnumValue EnumValue { get; set; }

        public virtual ProductAttributeSchema AttributeSchema { get; set; }
    }
}