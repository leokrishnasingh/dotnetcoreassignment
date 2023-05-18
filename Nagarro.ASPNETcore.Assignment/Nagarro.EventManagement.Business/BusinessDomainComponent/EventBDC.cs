using Nagarro.EventManagement.EntityDataModel.DataAccessComponents;
using Nagarro.EventManagement.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EventManagement.Business
{
    public class EventBDC : IEventBDC
    {
        private readonly IEventRepository _eventRepository;
        public EventBDC(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }


        public Task<int> AddEvent(EventDTO eventDTO)
        {
            return _eventRepository.AddEvent(eventDTO);
        }

        public EventDTO DetailOfEvent(int id)
        {
            return _eventRepository.DetailOfEvent(id);
        }

        public int Edit(int id, EventDTO model)
        {
            return _eventRepository.Edit(id, model);
        }

        public List<EventDTO> GetAllEvents()
        {
            return _eventRepository.GetAllEvents();
        }

        public Task<EventDTO> GetEvent(int id)
        {
            return _eventRepository.GetEvent(id);
        }

        public Task<string> InviteString(int id)
        {
            return _eventRepository.InviteString(id);
        }

        public List<EventDTO> UserEvents(string UserName)
        {
            return _eventRepository.UserEvents(UserName);
        }

        public List<EventDTO> UserInvitedInEvents(string UserName)
        {
            return _eventRepository.UserInvitedInEvents(UserName);
        }
    }
}
