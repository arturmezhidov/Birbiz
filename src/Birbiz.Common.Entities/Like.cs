﻿namespace Birbiz.Common.Entities
{
    public class Like : BaseEntity
    {
        public LikeType Type { get; set; }

        public int TargetId { get; set; }
    }
}