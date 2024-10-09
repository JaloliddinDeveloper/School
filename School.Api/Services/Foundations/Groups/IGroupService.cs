//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using System.Linq;
using System.Threading.Tasks;
using System;
using School.Api.Models.Foundations.Groups;

namespace School.Api.Services.Foundations.Groups
{
    public interface IGroupService
    {
        ValueTask<Group> AddGroupAsync(Group group);
        IQueryable<Group> RetrieveAllGroups();
        ValueTask<Group> RetrieveGroupByIdAsync(Guid groupId);
        ValueTask<Group> ModifyGroupAsync(Group group);
        ValueTask<Group> RemoveGroupAsync(Guid groupId);
    }
}
