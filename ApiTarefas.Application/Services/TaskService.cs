using ApiTarefas.Application.Models;
using ApiTarefas.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTarefas.Application.Services;

public class TaskService
{
    private readonly TaskRepository _taskRepository;

    public TaskService(TaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async Task CreateTask(CreateTaskDto taskDto)
    {
        await _taskRepository.createTasks(taskDto);
    }

    public async Task UpdateTask(int id, CreateTaskDto taskDto)
    {
        await _taskRepository.updateTask(id, taskDto);
    }

    public async Task<List<TaskModel>> SelectAllTasks()
    {
        return await _taskRepository.selectAllTasks();
    }

    public async Task<TaskModel> SelectTaskById(int id)
    {
        return await _taskRepository.selectTaskById(id);
    }

    public async Task DeleteTask(int id)
    {
        await _taskRepository.selectTaskById(id);
    }

}
