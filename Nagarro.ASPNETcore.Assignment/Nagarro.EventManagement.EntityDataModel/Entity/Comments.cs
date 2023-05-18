using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Nagarro.EventManagement.EntityDataModel
{
    public class Comments
    {
        [Key]
        public int CommentID{ get; set; }
        public string  Message { get; set; }
        public string Commentor { get; set; }
        
        public int EventId { get; set; }
        public virtual Event Event { get; set; }

    }
}
