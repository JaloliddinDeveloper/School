//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Microsoft.AspNetCore.Mvc;
using School.Api.Models.Foundations.Groups;
using School.Api.Services.Processings.Groups;
using School.Api.Services.Processings.Students;
using System.Threading.Tasks;

namespace School.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GroupController
    {
        private readonly IGroupProcessingService groupProcessingService;
        private readonly IStudentProcessingService studentProcessingService;

        public GroupController(
            IGroupProcessingService groupProcessingService, 
            IStudentProcessingService studentProcessingService)
        {
            this.groupProcessingService = groupProcessingService;
            this.studentProcessingService = studentProcessingService;
        }
        [HttpPost]
        public async ValueTask<IActionResult> PostGroup(Group group)
        {
           
        }
    }
}
