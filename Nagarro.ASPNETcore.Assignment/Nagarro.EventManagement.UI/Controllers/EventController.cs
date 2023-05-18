using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nagarro.EventManagement.Business;
using Nagarro.EventManagement.EntityDataModel;
using Nagarro.EventManagement.Shared;
using System;
using System.Threading.Tasks;

namespace Nagarro.EventManagement.UI.Controllers
{
    public class EventController : Controller
    {
        private readonly ICommentBDC _commentBDC;
        private readonly IEventBDC _eventBDC;
        public EventController(ICommentBDC commentBDC,IEventBDC eventBDC)
        {
            _commentBDC = commentBDC;
            _eventBDC = eventBDC;
        }

        /// <summary>
        /// Taking Event Information from the User on the browser(Only for Loggedin Users)
        /// </summary>
        /// <returns></returns>
        public IActionResult Create(bool isSuccess = false)
        {
            ViewBag.IsSuccess = isSuccess;
            return View();
        }

        /// <summary>
        /// Posting from controller to the Business Layer
        /// </summary>
        /// <param name="eventDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(EventDTO eventDTO)
        {
            eventDTO.EventCreatedByEmail = User.Identity.Name;

            if (ModelState.IsValid)
            {
                var result = await _eventBDC.AddEvent(eventDTO);

                if (result > 0)
                {
                    return RedirectToAction(nameof(Create), new { isSuccess = true });
                }
            }
            
            return View();
        }

        /// <summary>
        /// Details of an Event
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            ///to count the number of people invited in the event
            int count = 0;
            string str = await _eventBDC.InviteString(id);

            if (str != null) 
            {
                int l = str.Length;
                for (int i = 0; i < l; i++)
                {
                    if (str[i] == '@') count++;
                }
            }
            
            ViewBag.TotalInvite = count;

            var result = _eventBDC.DetailOfEvent(id);
            if (result==null)
            {
                ModelState.AddModelError("", "Event is not available!!");
                return View();
            }
            else
            {
                
                var eventComment= new EventCommentVM();
                eventComment.Event = result;
                eventComment.Comment = new CommentsDTO();
                eventComment.Comment.EventId = id;
                return View(eventComment);
            }   
        }

        /// <summary>
        /// Method to store comments in Databases 
        /// </summary>
        /// <param name="EC"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CommentPost(EventCommentVM EC)
        {
            EC.Comment.Commentor = User.Identity.Name;
            CommentsDTO newComment = EC.Comment;
            _commentBDC.AddComment(newComment);
            return RedirectToAction("Details",new { id = EC.Comment.EventId});
        }

        /// <summary>
        /// Events which is created by current user
        /// </summary>
        /// <returns></returns>
        public IActionResult UserEvents()
        {
            var result = _eventBDC.UserEvents(User.Identity.Name);
            if (result == null)
            {
                ModelState.AddModelError("", "Event is not available!!");
                return View();
            }
            else
            {
                return View(result);
            }
        }

        /// <summary>
        /// Events in Which user is Invited
        /// </summary>
        /// <returns></returns>
        public IActionResult UserInvitedInEvents()
        {
            var result = _eventBDC.UserInvitedInEvents(User.Identity.Name);
            if (result == null)
            {
                ModelState.AddModelError("", "Event is not available!!");
                return View();
            }
            else
            {
                return View(result);
            }
        }

        /// <summary>
        /// Get part of Edit of a Event
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async  Task<IActionResult> Edit(int id)
        {
            TempData["ID"] = id;
            var res = await _eventBDC.GetEvent(id);
            return View(res);
        }
        
        /// <summary>
        /// Post part of edit method
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(EventDTO model)
        {
            int id = int.Parse(TempData["ID"].ToString());
            var res = _eventBDC.Edit(id,model);

            if (res != 0) return RedirectToAction("UserEvents");

            else throw new NotImplementedException();
        }

        /// <summary>
        /// getting all events from the Database
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllEvents()
        {
            var res = _eventBDC.GetAllEvents();
            return View(res);
        }


    }
}
