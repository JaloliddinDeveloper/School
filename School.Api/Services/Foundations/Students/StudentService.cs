//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using School.Api.Brokers.Storages;
using School.Api.Models.Foundations.Students;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace School.Api.Services.Foundations.Students
{
    public class StudentService: IStudentService
    {
        private readonly IStorageBroker storageBroker;

        public StudentService(IStorageBroker storageBroker)=>
            this.storageBroker = storageBroker;

        public async ValueTask<Student> AddStudentAsync(Student student)=>
            await this.storageBroker.InsertStudentAsync(student);
        
        public async ValueTask<Student> RetrieveStudentByIdAsync(Guid studentId)=>
            await this.storageBroker.SelectStudentByIdAsync(studentId);
        
        public async ValueTask<IQueryable<Student>> RetrieveAllStudentsAsync() =>
           await this.storageBroker.SelectAllStudentsAsync();

        public async ValueTask<Student> ModifyStudentAsync(Student student)=>
            await this.storageBroker.UpdateStudentAsync(student);

        public async ValueTask<Student> RemoveStudentAsync(Guid studentId)
        {
            var maybeStudent = await this.storageBroker.SelectStudentByIdAsync(studentId);

            return await this.storageBroker.DeleteStudentAsync(maybeStudent);
        }
    }
}
