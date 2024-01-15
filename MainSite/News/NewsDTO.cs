using MainSite.User;
using System.ComponentModel.DataAnnotations;

namespace MainSite.News
{
    public class NewsCreateDTO
    {
        [Required]
        [MinLength(10)]
        public string Title { get; set; }

        [Required]
        [MinLength(30)]
        public string Content { get; set; }
    }
    public class NewsDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
        public DateTime CreatedAt { get; set; }
        public int AuthorId { get; set; }
        public UserDTO Author { get; set; }
    }
}
