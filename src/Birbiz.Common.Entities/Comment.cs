namespace Birbiz.Common.Entities
{
    public class Comment : BaseEntity
    {
        public string Text { get; set; }

        public CommentTargetType Type { get; set; }

        public int ParentId { get; set; }

        public int TargetId { get; set; }

        public virtual ProfileUser User { get; set; }
    }
}