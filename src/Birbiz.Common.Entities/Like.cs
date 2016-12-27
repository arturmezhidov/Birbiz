namespace Birbiz.Common.Entities
{
    public class Like : BaseEntity
    {
        public LikeTargetType Type { get; set; }

        public int TargetId { get; set; }
    }
}