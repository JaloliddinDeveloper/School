//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------

using School.Api.Models.Foundations.Students;
using System.Linq;
using System.Threading.Tasks;
using System;
using School.Api.Services.Foundations.Students;
using School.Api.Services.Processings.Groups;

namespace School.Api.Services.Processings.Students
{
    public class StudentProcessingService: IStudentProcessingService
    {
        private readonly IStudentService studentService;
        private readonly IGroupProcessingService groupProcessingService;
        public StudentProcessingService(
            IStudentService studentService,
            IGroupProcessingService groupProcessingService)
         
        {
            this.studentService = studentService;
            this.groupProcessingService = groupProcessingService;
        }

        public async ValueTask<Student> AddStudentAsync(Student student)
        {
            student.Id = Guid.NewGuid();
            return await this.studentService.AddStudentAsync(student);
        }

        
        public async ValueTask<Student> RetrieveStudentByIdAsync(Guid studentId) =>
            await this.studentService.RetrieveStudentByIdAsync(studentId);

        public async ValueTask<IQueryable<Student>> RetrieveAllStudentsAsync()=>
           await this.studentService.RetrieveAllStudentsAsync();

        public async ValueTask<Student> ModifyStudentAsync(Student student)=>
            await this.studentService.ModifyStudentAsync(student);

        public async ValueTask<Student> RemoveStudentAsync(Guid studentId) =>
            await this.studentService.RemoveStudentAsync(studentId);
    }
}
