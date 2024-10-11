//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using School.Api.Models.Foundations.Groups;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace School.Api.Services.Processings.Groups
{
    public interface IGroupProcessingService
    {
        ValueTask<Group> AddGroupAsync(Group group);
        ValueTask<IQueryable<Group>> RetrieveAllGroupsAsync();
        ValueTask<Group> RetrieveGroupByIdAsync(Guid groupId);
        ValueTask<Group> ModifyGroupAsync(Group group);
        ValueTask<Group> RemoveGroupAsync(Guid groupId);
    }
}
