using ApiTarefas.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTarefas.Application;

public class CreateTaskDto
{
    public string nome { get; set; }

    public Proridade proridade { get; set; }

    public DateOnly prazo { get; set; } = DateOnly.FromDateTime(DateTime.Now);

    public Status status { get; set; }
}
