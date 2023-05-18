using Nagarro.EventManagement.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nagarro.EventManagement.Shared
{
    public interface ICommentBDC
    {
        void AddComment(CommentsDTO commentsDTO);
    }
}
