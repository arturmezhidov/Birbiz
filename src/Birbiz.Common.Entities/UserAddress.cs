namespace Birbiz.Common.Entities
{
    public class UserAddress : BaseEntity
    {
        public int UserId { get; set; }

        public int FlatId { get; set; }

        public virtual ProfileUser User { get; set; }

        public virtual Flat Flat { get; set; }
    }
}