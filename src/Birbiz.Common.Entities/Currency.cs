namespace Birbiz.Common.Entities
{
    public class Currency : BaseEntity
    {
        public string Abbreviation { get; set; }

        public string FullName { get; set; }

        public string Symbol { get; set; }
    }
}