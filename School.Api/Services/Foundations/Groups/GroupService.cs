//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using School.Api.Brokers.Storages;
using System.Linq;
using System.Threading.Tasks;
using System;
using School.Api.Models.Foundations.Groups;

namespace School.Api.Services.Foundations.Groups
{
    public class GroupService: IGroupService
    {
        private readonly IStorageBroker storageBroker;

        public GroupService(IStorageBroker storageBroker)=>
            this.storageBroker = storageBroker;

        public async ValueTask<Group> AddGroupAsync(Group group)
        {
            group.Id = Guid.NewGuid();
            return await this.storageBroker.InsertGroupAsync(group);
        }
         
        
        public IQueryable<Group> RetrieveAllGroups() =>
            this.storageBroker.SelectAllGroups();

        public async ValueTask<Group> RetrieveGroupByIdAsync(Guid groupid) =>
            await this.storageBroker.SelectGroupByIdAsync(groupid);

        public async ValueTask<Group> ModifyGroupAsync(Group group) =>
            await this.storageBroker.UpdateGroupAsync(group);

        public async ValueTask<Group> RemoveGroupAsync(Guid groupid)
        {
            var maybeGroup = await this.storageBroker.SelectGroupByIdAsync(groupid);

            return await this.storageBroker.DeleteGroupAsync(maybeGroup);
        }
    }
}
