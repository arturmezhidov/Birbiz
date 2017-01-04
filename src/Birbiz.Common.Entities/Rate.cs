namespace Birbiz.Common.Entities
{
    public class Rate : BaseEntity
    {
        public double Ratio { get; set; }

        public double Coefficient { get; set; }

        public int FirstCurrencyId { get; set; }

        public int SecondCurrencyId { get; set; }
    }
}