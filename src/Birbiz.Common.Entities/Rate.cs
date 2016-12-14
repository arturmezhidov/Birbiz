namespace Birbiz.Common.Entities
{
    public class Rate : BaseEntity
    {
        public double Ratio { get; set; }

        public double Coefficient { get; set; }

        public virtual Currency FirstCurrency { get; set; }

        public virtual Currency SecondCurrency { get; set; }
    }
}