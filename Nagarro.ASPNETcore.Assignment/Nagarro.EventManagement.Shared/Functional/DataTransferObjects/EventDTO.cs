using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nagarro.EventManagement.Shared
{
    public class EventDTO
    {
        public int EventId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name ="Event Location")]
        public string Location { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }

        [Display(Name ="Do you want to make it a private Event")]
        public bool Type { get; set; }

        [Range(0,4)]
        [Display(Name = "Dauration in Hours")]
        public int DurationInHours { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(500)]
        [Display(Name = "Other Details")]
        public string OtherDetails { get; set; }

        [Display(Name ="Invite Others By their E-mails")]
        public string InviteByEmails { get; set; }

        public string EventCreatedByEmail { get; set; }

        public List<CommentsDTO> Comments { get; set; }

    }
}
