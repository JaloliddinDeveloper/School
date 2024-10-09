//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using School.Api.Brokers.Storages;
using School.Api.Services.Foundations.Groups;
using School.Api.Services.Foundations.Students;
using School.Api.Services.Processings.Groups;
using School.Api.Services.Processings.Students;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        ConfigureBrokers(builder);
        builder.Services.AddTransient<IGroupService, GroupService>();
        builder.Services.AddTransient<IStudentService, StudentService>();
        builder.Services.AddTransient<IGroupProcessingService, GroupProcessingService>();
        builder.Services.AddTransient<IStudentProcessingService,StudentProcessingService>();


        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }

    private static void ConfigureBrokers(WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<IStorageBroker, StorageBroker>();
    }
}