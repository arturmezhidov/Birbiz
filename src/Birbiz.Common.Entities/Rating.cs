namespace Birbiz.Common.Entities
{
    public class Rating : BaseEntity
    {
        public RatingTargetType Type { get; set; }

        public int Value { get; set; }

        public int TargetId { get; set; }

        public int UserId { get; set; }

        public virtual ProfileUser User { get; set; }
    }
}