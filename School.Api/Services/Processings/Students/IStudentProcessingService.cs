//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using School.Api.Models.Foundations.Students;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace School.Api.Services.Processings.Students
{
    public interface IStudentProcessingService
    {
        ValueTask<Student> AddStudentAsync(Student student);
        IQueryable<Student> RetrieveAllStudents();
        ValueTask<Student> RetrieveStudentByIdAsync(Guid studentId);
        ValueTask<Student> ModifyStudentAsync(Student student);
        ValueTask<Student> RemoveStudentAsync(Guid studentId);
    }
}
