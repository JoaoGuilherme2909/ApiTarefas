using ApiTarefas.Application;
using ApiTarefas.Application.Repositories.InMemory;
using ApiTarefas.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiTarefas.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{

    private readonly TaskService _taskService;

    public TaskController(TaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllTasks()
    {
        return Ok(await _taskService.SelectAllTasks());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTaskById(int id)
    {
        try
        {
            return Ok(await _taskService.SelectTaskById(id));
        }
        catch (Exception ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpPost]
    public async Task<IActionResult> CreateTask([FromBody] CreateTaskDto createTaskDto)
    {

        await _taskService.CreateTask(createTaskDto);

        return Created();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTask(int id,[FromBody] CreateTaskDto createTaskDto)
    {
        try
        {
            await _taskService.UpdateTask(id, createTaskDto);
            return NoContent();
        }
        catch (Exception ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTask(int id)
    {
        try
        {
            await _taskService.DeleteTask(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return NotFound(ex.Message);
        }
    }
}
