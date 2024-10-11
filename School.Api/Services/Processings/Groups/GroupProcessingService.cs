//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using School.Api.Models.Foundations.Groups;
using School.Api.Services.Foundations.Groups;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace School.Api.Services.Processings.Groups
{
    public class GroupProcessingService : IGroupProcessingService
    {
        private readonly IGroupService groupService;

        public GroupProcessingService(IGroupService groupService)=>
            this.groupService = groupService;
        
        public async ValueTask<Group> AddGroupAsync(Group group) =>
           await this.groupService.AddGroupAsync(group);

        public async ValueTask<Group> RetrieveGroupByIdAsync(Guid groupId) =>
            await this.groupService.RetrieveGroupByIdAsync(groupId);

        public async ValueTask<IQueryable<Group>> RetrieveAllGroupsAsync() =>
            await this.groupService.RetrieveAllGroupsAsync();

        public async ValueTask<Group> ModifyGroupAsync(Group group) =>
            await this.groupService.ModifyGroupAsync(group);

        public async ValueTask<Group> RemoveGroupAsync(Guid groupId) =>
            await this.groupService.RemoveGroupAsync(groupId);
    }
}
