//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using System.Linq;
using System.Threading.Tasks;
using System;
using School.Api.Models.Foundations.Groups;

namespace School.Api.Services.Processings.Groups
{
    public interface IGroupProcessingService
    {
        ValueTask<Group> AddGroupAsync(Group group);
        ValueTask<Group> RetrieveGroupByIdAsync(Guid groupId);
        IQueryable<Group> RetrieveAllGroups();
        ValueTask<Group> ModifyGroupAsync(Group group);
        ValueTask<Group> RemoveGroupAsync(Guid groupId);
    }
}
