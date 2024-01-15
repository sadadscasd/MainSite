using MainSite.News;

namespace MainSite.User
{
    public class News_Entity
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
        public DateTime CreatedAt { get; set; }
        public int AuthorId { get; set; }
        public UserEntity Author { get; set; }
    }
}
