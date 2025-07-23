using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTarefas.Application.Models;

public class TaskModel
{
    public int id { get; set; }
    
    public string nome { get; set; }

    public Proridade proridade { get; set; }

    public DateOnly prazo { get; set; } = DateOnly.FromDateTime(DateTime.Now);

    public Status status { get; set; }
}
