using System.ComponentModel.DataAnnotations;

namespace Nagarro.EventManagement.Shared
{
    public class CommentsDTO
    {
        [Key]
        public int CommentID { get; set; }

        [Required]
        public string Message { get; set; }
        public string Commentor { get; set; }
        public int EventId { get; set; }
    }
}
