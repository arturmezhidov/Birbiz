using System.Collections.Generic;
using Birbiz.Common.Entities.Catalog;

namespace Birbiz.Common.Entities
{
    public class ProfileUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string AboutMe { get; set; }

        public string WebSiteUrl { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual Flat Flat { get; set; }

        public virtual ICollection<Like> Likes { get; set; } = new HashSet<Like>();

        public virtual ICollection<Favorite> Favorites { get; set; } = new HashSet<Favorite>();

        public virtual ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();

        public virtual ICollection<Rating> Ratings { get; set; } = new HashSet<Rating>();

        public virtual ICollection<Shop> Shops { get; set; } = new HashSet<Shop>();

        public virtual ICollection<ProductOrder> Orders { get; set; } = new HashSet<ProductOrder>();
    }
}
