using Microsoft.AspNetCore.Mvc;

namespace Habits.Controllers;

[ApiController]
[Route("[controller]")]
public class HabitController : ControllerBase
{
    private readonly ILogger<HabitController> _logger;

    public HabitController(ILogger<HabitController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Habit> Get()
    {
        return new List<Habit> { new() { Trigger = "trigger" } };
    }

    [HttpGet(Name = "{id}")]
    public Habit GetById(int id)
    {
        return new() { Trigger = "trigger" };
    }

    [HttpPut(Name = "{id}")]
    public Habit Update(int id, Habit habit)
    {
        return habit;
    }

    [HttpPost]
    public Habit Add(Habit habit)
    {
        return habit;
    }

    [HttpDelete(Name = "{id}")]
    public void Delete()
    {

    }
}
