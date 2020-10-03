using Microsoft.EntityFrameworkCore;

namespace Istip.Blog.API.DataAccess
{
    public class BlogPostsContext : DbContext
    {
        public BlogPostsContext (DbContextOptions<BlogPostsContext> options)
            : base(options)
        {
        }

        public DbSet<Models.BlogPost> BlogPost { get; set; }
    }
}
