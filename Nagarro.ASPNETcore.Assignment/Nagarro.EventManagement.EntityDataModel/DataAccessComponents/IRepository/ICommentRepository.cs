using Nagarro.EventManagement.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nagarro.EventManagement.EntityDataModel.DataAccessComponents
{
    public interface ICommentRepository
    {
        void AddComment(CommentsDTO commentsDTO);
    }
}
