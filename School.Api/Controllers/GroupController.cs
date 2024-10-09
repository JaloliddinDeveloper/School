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

namespace School.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GroupController : RESTFulController
    {
        private readonly IGroupProcessingService groupProcessingService;

        public GroupController(
            IGroupProcessingService groupProcessingService)
        {
            this.groupProcessingService = groupProcessingService;
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
        public ActionResult<IQueryable<Group>> GetAllGroups()
        {
            try
            {
                var groups = this.groupProcessingService.RetrieveAllGroups();
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
    }
}
