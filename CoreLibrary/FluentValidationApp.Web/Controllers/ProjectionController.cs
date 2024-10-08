using AutoMapper;
using FluentValidationApp.Web.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationApp.Web.Controllers
{
    public class ProjectionController(IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(EventDateDto eventDateDto)
        {
            Models.EventDate eventDate = _mapper.Map<Models.EventDate>(eventDateDto);

            ViewBag.date = eventDate.Date.ToShortDateString();

            return View();
        }
    }
}
