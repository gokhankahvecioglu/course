using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController : Controller
{

    public IActionResult Index()
    {
        var kurs = new Course
        {
            Id = 1,
            Title = "aspnet core kursu",
            Description = "Güzel bir kurs"
        };
        return View(kurs);
    }

    public IActionResult List()
    {
        var kurslar = new List<Course>()
        {
            new Course() {Id = 1, Title = "aspnet kursu", Description = "güzel bir kurs"},
            new Course() {Id = 2, Title = "php kursu", Description = "güzel bir kurs"},
            new Course() {Id = 3, Title = "django kursu", Description = "güzel bir kurs"},
            new Course() {Id = 4, Title = "javascript kursu", Description = "güzel bir kurs"}
        };
        return View("CourseList", kurslar);
    }
}