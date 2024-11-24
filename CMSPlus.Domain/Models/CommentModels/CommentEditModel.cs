namespace CMSPlus.Domain.Models.CommentModels;

public class CommentEditModel:BaseCommentModel
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Comment { get; set; }
    public int TopicId { get; set; }
    public DateTime? CreatedOnUtc { get; set; }
    public DateTime? UpdatedOnUtc { get; set; }
}