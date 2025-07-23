using ApiTarefas.Application.Repositories;
using ApiTarefas.Application.Repositories.InMemory;
using ApiTarefas.Application.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<TaskRepository, InMemoryRepository>();
builder.Services.AddSingleton<TaskService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
