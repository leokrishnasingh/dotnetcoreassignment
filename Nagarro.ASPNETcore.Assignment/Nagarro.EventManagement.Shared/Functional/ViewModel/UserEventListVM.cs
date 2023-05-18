using System.Collections.Generic;

namespace Nagarro.EventManagement.Shared
{
    public class UserEventListVM
    {
        public List<EventDTO> Events { get; set; }
            
        public UserDTO User { get; set; }
    }
}
