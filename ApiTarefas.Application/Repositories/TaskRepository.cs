using ApiTarefas.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTarefas.Application.Repositories;

public interface TaskRepository
{
    public Task createTasks(CreateTaskDto task);

    public Task updateTask(int id, CreateTaskDto task);

    public Task<TaskModel> selectTaskById(int id);

    public Task<List<TaskModel>> selectAllTasks();

    public Task deleteTask(int id);
}
