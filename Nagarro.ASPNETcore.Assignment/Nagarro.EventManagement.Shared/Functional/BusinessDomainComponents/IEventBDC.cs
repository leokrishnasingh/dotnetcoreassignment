using Nagarro.EventManagement.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EventManagement.Shared
{
    public interface IEventBDC
    {
        Task<int> AddEvent(EventDTO eventDTO);

        List<EventDTO> GetAllEvents();

        EventDTO DetailOfEvent(int id);

        List<EventDTO> UserEvents(string UserName);

        List<EventDTO> UserInvitedInEvents(string UserName);

        Task<string> InviteString(int id);

        Task<EventDTO> GetEvent(int id);

        int Edit(int id, EventDTO model);
    }
}
