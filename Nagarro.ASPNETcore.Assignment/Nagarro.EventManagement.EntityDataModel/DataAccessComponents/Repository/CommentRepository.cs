using Nagarro.EventManagement.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nagarro.EventManagement.EntityDataModel.DataAccessComponents
{
    public class CommentRepository : ICommentRepository
    {
        private readonly BookEventContext _bookEventContext;

        public CommentRepository(BookEventContext bookEventContext)
        {
            _bookEventContext = bookEventContext;
        }

        /// <summary>
        /// Adding the comments in the database
        /// </summary>
        /// <param name="commentsDTO"></param>
        public void AddComment(CommentsDTO commentsDTO)
        {
            var nc = new Comments()
            {
                Message = commentsDTO.Message,
                Commentor = commentsDTO.Commentor,
                EventId = commentsDTO.EventId
            };

            _bookEventContext.Comments.Add(nc);
            _bookEventContext.SaveChanges();

            return;
        }
    }
}
