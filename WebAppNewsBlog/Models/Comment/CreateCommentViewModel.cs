namespace HackerNewsApi.Models.Comment
{
    public class CreateCommentViewModel
    {
        public int PostId { get; set; }

        public string Content { get; set; }

        public string UserEmail { get; set; }

    }
}
