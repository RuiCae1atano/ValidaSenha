using ValidaSenha.Infrastructure.Regex;
using ValidationPassword.API.Filters;
using ValidationPassword.Application.Interfaces;
using ValidationPassword.Domain.Models;
using ValidationPassword.Infrastructure.Messages;
using ValidationSenha.Appication.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IPasswordValidatorService, PasswordValidatorService>();
builder.Services.AddScoped<IRegexExpressions, RegexExpressions>();
builder.Services.AddScoped<IValidationResponse, ValidationResponse>();
builder.Services.AddScoped<IMessageService, MessageService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers(options =>
{
    options.Filters.Add(typeof(FilterExceptions));
});

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
