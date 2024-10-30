//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using School.Api.Models.Foundations.Groups;
using RESTFulSense.Controllers;
using School.Api.Services.Processings.Groups;
using School.Api.Services.Orcestrations;
using School.Api.Models.Foundations;

namespace School.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GroupController : RESTFulController
    {
        private readonly IGroupProcessingService groupProcessingService;
        private readonly IOrcestrationService orcestrationService;

        public GroupController(
            IGroupProcessingService groupProcessingService,
            IOrcestrationService orcestrationService)
        {
            this.groupProcessingService = groupProcessingService;
            this.orcestrationService = orcestrationService;
        }

        [HttpPost]
        public async ValueTask<ActionResult<Group>> PostGuestAsync(Group group)
        {
            try
            {
                Group postedGroup = await this.groupProcessingService.AddGroupAsync(group);
                return Created(postedGroup);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async ValueTask<ActionResult<IQueryable<Group>>> GetAllGroupAsync()
        {
            try
            {
                IQueryable<Group> groups =
                    await this.groupProcessingService.RetrieveAllGroupsAsync();

                return Ok(groups);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{groupId}")]
        public async Task<ActionResult<Group>> GetGroupById(Guid groupId)
        {
           try
            {
                var group = await this.groupProcessingService.RetrieveGroupByIdAsync(groupId);
                return Ok(group);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async ValueTask<ActionResult<Group>> PutGroupAsync(Group group)
        {
            try
            {
                Group modifiedGroup =
                    await this.groupProcessingService.ModifyGroupAsync(group);

                return Ok(modifiedGroup);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public async ValueTask<ActionResult<Group>> DeleteGroupByIdAsync(Guid groupId)
        {
            try
            {
                Group deletedGroup = await this.groupProcessingService.RemoveGroupAsync(groupId);

                return Ok(deletedGroup);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("with-students")]
        public async Task<IActionResult> GetAllGroupsWithStudentsAsync()
        {
            IQueryable<GroupStudent> groupStudents = await this.orcestrationService.RetrieveAllGroupsWithStudentsAsync();
            return Ok(groupStudents);
        }
    }
}
