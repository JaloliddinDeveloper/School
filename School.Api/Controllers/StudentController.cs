//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;
using School.Api.Models.Foundations.Students;
using School.Api.Services.Processings.Students;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace School.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : RESTFulController
    {
        private readonly IStudentProcessingService studentProcessingService;

        public StudentController(
            IStudentProcessingService studentProcessingService) =>
            this.studentProcessingService = studentProcessingService;

        [HttpPost]
        public async ValueTask<ActionResult<Student>> PostGuestAsync(Student student)
        {
            try
            {
                Student postedStudent = await this.studentProcessingService.AddStudentAsync(student);
                return Created(postedStudent);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<IQueryable<Student>> GetAllStudents()
        {
            try
            {
                var groups = this.studentProcessingService.RetrieveAllStudents();
                return Ok(groups);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{studentId}")]
        public async Task<ActionResult<Student>> GetStudentById(Guid studentId)
        {
            try
            {
                var student = await this.studentProcessingService.RetrieveStudentByIdAsync(studentId);
                return Ok(student);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async ValueTask<ActionResult<Student>> PutStudentAsync(Student student)
        {
            try
            {
                Student modifiedStudent =
                    await this.studentProcessingService.ModifyStudentAsync(student);

                return Ok(modifiedStudent);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public async ValueTask<ActionResult<Student>> DeleteStudentByIdAsync(Guid studentId)
        {
            try
            {
                Student deletedStudent = await this.studentProcessingService.RemoveStudentAsync(studentId);

                return Ok(deletedStudent);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}



