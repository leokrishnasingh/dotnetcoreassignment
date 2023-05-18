using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nagarro.EventManagement.Business;
using Nagarro.EventManagement.EntityDataModel;
using Nagarro.EventManagement.Shared;
using Nagarro.EventManagement.UI.Controllers;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using Nagarro.EventManagement.EntityDataModel.DataAccessComponents;

namespace Nagarro.EventManagement.xUnitTests
{
    public class EventControllerTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange 
            var options = new DbContextOptionsBuilder<BookEventContext>()
                .UseInMemoryDatabase("EventContextInMemory")
                .Options;


            using (var mockContext = new BookEventContext(options))
            {
                var evt1 = new Event { EventId = 1, Title = "The Guide by RK Narayan", Date = new DateTime(2020, 01, 01), Location = "New Delhi", StartTime = new TimeSpan(04, 20, 00), Type = false, DurationInHours = 2, Description = "The Guide is a 1958 novel written in English by the Indian author R. K. Narayan.", OtherDetails = "Like most of his works, the novel is based on Malgudi, the fictional town in South India.", InviteByEmails = "krishna@gmail.com", EventCreatedByEmail = "rahul@gmail.com", Comments = new List<Comments> { } };
                mockContext.Events.Add(evt1);

                var evt2 = new Event { EventId = 2, Title = "THE PRIVATE LIFE OF AN INDIAN PRINCE BY MULK RAJ ANAND", Date = new DateTime(2019, 01, 01), Location = "Jaipur", StartTime = new TimeSpan(10, 20, 00), Type = false, DurationInHours = 2, Description = "The Private Life of an Indian Prince is a novel by Mulk Raj Anand first published in 1953.", OtherDetails = "This book deals with the abolition of the princely states system in India.", InviteByEmails = "rahul@gmail.com", EventCreatedByEmail = "krishna@gmail.com", Comments = new List<Comments> {  } };
                mockContext.Events.Add(evt2);

                var evt3 = new Event { EventId = 3, Title = "MALGUDI DAYS BY R.K. NARAYAN", Date = new DateTime(2021, 01, 01), Location = "Vadodra", StartTime = new TimeSpan(11, 20, 00), Type = false, DurationInHours = 3, Description = "Malgudi Days is a collection of short stories by R.K. Narayan.", OtherDetails = "The book includes 32 stories, all set in the fictional town of Malgudi, located in South India.", InviteByEmails = "krishna@gmail.com,rahul@gmail.com", EventCreatedByEmail = "myadmin@bookevents.com", Comments = new List<Comments> {  } };
                mockContext.Events.Add(evt3);

                var evt4 = new Event { EventId = 4, Title = "GODAN BY MUNSHI PREMCHAND", Date = new DateTime(2022, 01, 01), Location = "Bengaluru", StartTime = new TimeSpan(09, 00, 00), Type = true, DurationInHours = 2, Description = "It is themed around the socio-economic deprivation as well as the exploitation of the village poor.", OtherDetails = "", InviteByEmails = "krishna@gmail.com,rahul@gmail.com", EventCreatedByEmail = "myadmin@bookevents.com", Comments = new List<Comments> { } };
                mockContext.Events.Add(evt4);


                mockContext.SaveChanges();

                var mockEventRepository = new EventRepository(mockContext);
                var mockCommentRepository = new CommentRepository(mockContext);

                var mockEventBDC = new EventBDC(mockEventRepository);
                var mockCommentBDC = new CommentBDC(mockCommentRepository);

                var inTestController = new EventController(mockCommentBDC,mockEventBDC);


                ///Act
                var userEvents = inTestController.GetAllEvents();


                var viewResult = Assert.IsType<ViewResult>(userEvents);
                Assert.NotNull(viewResult);
                //Assert.Equal(nameof(controller.Index), viewResult.ViewName);
                Assert.NotNull(viewResult.Model);
                Assert.Equal(typeof(List<EventDTO>), viewResult.Model.GetType());
                Assert.Equal(4, (viewResult.Model as List<EventDTO>).Count());
            }
        }

        
    }
}
