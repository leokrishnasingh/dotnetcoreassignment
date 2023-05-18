using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Nagarro.EventManagement.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EventManagement.EntityDataModel.DataAccessComponents
{
    public class EventRepository : IEventRepository
    {
        private readonly BookEventContext _bookEventContext;

        public EventRepository(BookEventContext bookEventContext)
        {
            _bookEventContext = bookEventContext;
        }


        /// <summary>
        /// adding event in database
        /// </summary>
        /// <param name="eventDTO"></param>
        /// <returns></returns>
        public async Task<int> AddEvent(EventDTO eventDTO)
        {
            Event newEvent = new Event();

            //Mapper.CreateMap<EventDTO, Event>();
            var myConfig = new MapperConfiguration(mc => mc.CreateMap<EventDTO, Event>());
            var DTOToEntityMapper = new Mapper(myConfig);
            newEvent = DTOToEntityMapper.Map<EventDTO, Event>(eventDTO);


            await _bookEventContext.AddAsync(newEvent);
            await _bookEventContext.SaveChangesAsync();

            return newEvent.EventId;
        }


        /// <summary>
        /// Details of an Event
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public EventDTO DetailOfEvent(int id)
        {
            var evt = _bookEventContext.Events.FirstOrDefault(evt => evt.EventId == id);

            var cmt = _bookEventContext.Comments.Where(cmt => cmt.EventId == id).ToList();

            var myConfig = new MapperConfiguration(mc =>
            {
                mc.CreateMap<Event, EventDTO>();
                mc.CreateMap<Comments, CommentsDTO>();
            });
            var EntityToDTOMapper = new Mapper(myConfig);

            var result = EntityToDTOMapper.Map<Event, EventDTO>(evt);

            result.Comments = EntityToDTOMapper.Map<List<Comments>, List<CommentsDTO>>(cmt);

            return result;
        }

        /// <summary>
        /// all the events
        /// </summary>
        /// <returns></returns>
        public List<EventDTO> GetAllEvents()
        {
            var allEvents = _bookEventContext.Events.ToList();

            //Mapper.CreateMap<EventDTO, Event>();
            var myConfig = new MapperConfiguration(mc => mc.CreateMap<Event, EventDTO>());
            var DTOToEntityMapperList = new Mapper(myConfig);

            var result = new List<EventDTO>();

            result = DTOToEntityMapperList.Map<List<Event>, List<EventDTO>>(allEvents);

            return (result);
        }

        /// <summary>
        /// to get the Invite bu Emails  strings
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<string> InviteString(int id)
        {
            Event e = await _bookEventContext.Events.FirstOrDefaultAsync(x => x.EventId == id);
            if (e == null)
            {
                return "";
            }
            else return e.InviteByEmails;
        }


        /// <summary>
        /// Events Created by user u
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public List<EventDTO> UserEvents(string UserName)
        {
            List<Event> list = new List<Event>();
            if (UserName == "myadmin@bookevents.com")
            {
                list = _bookEventContext.Events.ToList();
            }
            else
            {
                list = _bookEventContext.Events.Where(e => e.EventCreatedByEmail == UserName).ToList();
            }

            var myConfig = new MapperConfiguration(mc => mc.CreateMap<Event, EventDTO>());
            var DTOToEntityMapperList = new Mapper(myConfig);

            var result = new List<EventDTO>();

            result = DTOToEntityMapperList.Map<List<Event>, List<EventDTO>>(list);

            return (result);
        }

        /// <summary>
        /// Event in which user u is invited
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public List<EventDTO> UserInvitedInEvents(string UserName)
        {
            var list = new List<Event>();
            if (UserName == "myadmin@bookevents.com")
            {
                list = _bookEventContext.Events.ToList();
            }
            else
            {
                list = _bookEventContext.Events.Where(e => e.InviteByEmails.Contains(UserName)).ToList();
            }

            var myConfig = new MapperConfiguration(mc => mc.CreateMap<Event, EventDTO>());
            var DTOToEntityMapperList = new Mapper(myConfig);

            var result = new List<EventDTO>();

            result = DTOToEntityMapperList.Map<List<Event>, List<EventDTO>>(list);

            return (result);
        }

        /// <summary>
        /// get  a single event from EVents table olf database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<EventDTO> GetEvent(int id)
        {
            var evt = await _bookEventContext.Events.FirstOrDefaultAsync(evt => evt.EventId == id);

            var myConfig = new MapperConfiguration(m => m.CreateMap<Event, EventDTO>());
            var EntityToDTO = new Mapper(myConfig);

            var result = EntityToDTO.Map<Event, EventDTO>(evt);
            return result;
        }

        /// <summary>
        /// edit a event
        /// </summary>
        /// <param name="model"></param>
        public int Edit(int id, EventDTO model)
        {
            var evt = _bookEventContext.Events.FirstOrDefault(e => e.EventId == id);

            ///not using mapping here as we are not creating any new event from the event DTO
            if (evt != null)
            {
                evt.Title = model.Title;
                evt.Location = model.Location;
                evt.Date = model.Date;
                evt.StartTime = model.StartTime;
                evt.Type = model.Type;
                evt.Description = model.Description;
                evt.OtherDetails = model.OtherDetails;
                evt.InviteByEmails = model.InviteByEmails;
                evt.DurationInHours = model.DurationInHours;
                evt.EventCreatedByEmail = model.EventCreatedByEmail;
            }

            _bookEventContext.SaveChanges();

            return evt.EventId;

        }
    }
}
