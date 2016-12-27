namespace Birbiz.Common.Entities
{
    public class Favorite : BaseEntity
    {
        public FavoriteTargetType Type { get; set; }

        public int TargetId { get; set; }

        public virtual ProfileUser User { get; set; }
    }
}