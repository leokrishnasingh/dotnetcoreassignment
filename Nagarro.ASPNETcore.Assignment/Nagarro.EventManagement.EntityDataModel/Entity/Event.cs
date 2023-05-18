using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Nagarro.EventManagement.EntityDataModel
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string Title { get; set; }
        public System.DateTime Date { get; set; }
        public string Location { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<bool> Type { get; set; }
        public Nullable<int> DurationInHours { get; set; }
        public string Description { get; set; }
        public string OtherDetails { get; set; }
        public string InviteByEmails { get; set; }
        public string EventCreatedByEmail { get; set; }
        public virtual ICollection<Comments> Comments{ get; set; }
    }
}
