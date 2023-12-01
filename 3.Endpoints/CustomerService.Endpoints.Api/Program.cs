using CustomerService.Core.ApplicationService.People.Commands.PersonCreate;
using CustomerService.Core.ApplicationService.People.Contracts;
using CustomerService.Core.Domain.People;
using CustomerService.Infra.Sql;
using CustomerService.Infra.Sql.People;
using FluentValidation;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<PersonCreateCommandHandler>();
builder.Services.AddScoped<IPersonCommandRepository, PersonCommandRepository>();
builder.Services.AddDbContext<CustomerDbContext>();
//builder.Services.AddFluentValidationClientsideAdapters.
builder.Services.AddScoped<IValidator<PersonCreateCommand>, PersonCreateValidator>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
