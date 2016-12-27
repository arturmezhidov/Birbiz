using System.Collections.Generic;

namespace Birbiz.Common.Entities.Catalog
{
    public class ProductAttributeSchema : BaseEntity
    {
        public string DisplayName { get; set; }

        public string HelpInfo { get; set; }

        public AttributeValueType ValueType { get; set; }

        public virtual MeasurementUnit MeasurementUnit { get; set; }

        public virtual ProductAttributeGroup AttributeGroup { get; set; }

        public virtual ICollection<ProductAttributeEnumValue> AttributeEnumValue { get; set; } = new HashSet<ProductAttributeEnumValue>();

        public virtual ICollection<ProductAttributeRangeValue> AttributeRangeValue { get; set; } = new HashSet<ProductAttributeRangeValue>();

        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; } = new HashSet<ProductAttribute>();
    }
}