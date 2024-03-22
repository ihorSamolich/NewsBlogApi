namespace HackerNewsApi.Models.Comment
{
    public class CommentViewModel
    {
        public string Content { get; set; }
        public DateTime DataCreated { get; set; }
        public string UserName { get; set; }
        public string UserAvatar { get; set; }
    }
}
