using Nagarro.EventManagement.EntityDataModel.DataAccessComponents;
using Nagarro.EventManagement.Shared;

namespace Nagarro.EventManagement.Business
{
    public class CommentBDC : ICommentBDC
    {
        private readonly ICommentRepository _commentRepository;
        public CommentBDC(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public void AddComment(CommentsDTO commentsDTO)
        {
            _commentRepository.AddComment(commentsDTO);
            return;
        }
    }
}
