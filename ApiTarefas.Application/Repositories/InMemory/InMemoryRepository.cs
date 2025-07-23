using ApiTarefas.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTarefas.Application.Repositories.InMemory;

public class InMemoryRepository : TaskRepository
{
    List<TaskModel> TaskList = new List<TaskModel>();

    public async Task createTasks(CreateTaskDto task)
    {
        TaskModel taskToBeAdded = new TaskModel() { id = TaskList.Count > 0 ? TaskList.Last().id++ : 1, nome = task.nome, prazo = task.prazo, proridade = task.proridade, status = task.status };
        TaskList.Add(taskToBeAdded);
    }

    public async Task deleteTask(int id)
    {
        TaskModel task = TaskList.First(t => t.id == id);
        
        TaskList.Remove(task);

    }

    public async Task updateTask(int id, CreateTaskDto task)
    {
        TaskModel taskToBeUpdated = TaskList.First(t => t.id == id);

        taskToBeUpdated.nome = task.nome;
        taskToBeUpdated.status = task.status;
        taskToBeUpdated.proridade = task.proridade;
        taskToBeUpdated.prazo = task.prazo;
    }

    public async Task<List<TaskModel>> selectAllTasks()
    {
        return TaskList;
    }

    public async Task<TaskModel> selectTaskById(int id)
    {
        TaskModel task = TaskList.First(t => t.id == id);

        return task;
    }
}
