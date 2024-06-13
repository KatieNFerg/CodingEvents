using CodingEvents.Models;
using CodingEvents.Data;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore.Metadata.Internal;
using CodingEvents.ViewModels;

namespace CodingEvents.Controllers;

// [Route("/EventCategory")]
public class EventCategoryController : Controller
{
    private EventDbContext context;
    public EventCategoryController(EventDbContext dbContext)
    {
        context = dbContext;
    }
    [HttpGet("/EventCategory")]
    public IActionResult Index()
    {
        List<EventCategory> categories = context.Categories.ToList();
        return View("index", categories);
    }

    [HttpGet("/EventCategory/Create")]
    public IActionResult Create()
    {
        AddEventCategoryViewModel addEventCategoryViewModel = new AddEventCategoryViewModel();

        return View("create", addEventCategoryViewModel);
    }

    [HttpPost("/EventCategory/Create")]
    // [Route("/EventCategory/Create")]
    public IActionResult ProcessCreateEventCategoryForm(AddEventCategoryViewModel addEventCategoryViewModel)
    {
        if (ModelState.IsValid)
        {
            EventCategory theCategory = new EventCategory
            {
                Name = addEventCategoryViewModel.Name
            };

            context.Categories.Add(theCategory);
            context.SaveChanges();

            return Redirect("index");

        }
        return View("create", addEventCategoryViewModel);
    }
}