//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using School.Api.Services.Foundations.Groups;
using System.Linq;
using System.Threading.Tasks;
using System;
using School.Api.Models.Foundations.Groups;

namespace School.Api.Services.Processings.Groups
{
    public class GroupProcessingService : IGroupProcessingService
    {
        private readonly IGroupService groupService;

        public GroupProcessingService(IGroupService groupService)=>
            this.groupService = groupService;
       
        public async ValueTask<Group> AddGroupAsync(Group group) =>
           await groupService.AddGroupAsync(group);

        public async ValueTask<Group> RetrieveGroupByIdAsync(Guid groupId) =>
            await groupService.RetrieveGroupByIdAsync(groupId);

        public IQueryable<Group> RetrieveAllGroups() =>
            groupService.RetrieveAllGroups();

        public async ValueTask<Group> ModifyGroupAsync(Group group) =>
            await groupService.ModifyGroupAsync(group);

        public async ValueTask<Group> RemoveGroupAsync(Guid groupId) =>
            await groupService.RemoveGroupAsync(groupId);
    }
}
